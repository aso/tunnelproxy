using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SharpPcap;
using TunnelProxy.Interfaces;
using TunnelProxy.Util;
using TunnelProxy.Tunnels;

namespace SoftEther.Client.GUI.App
{
	public class TunnelLogic
	{

		//static void Main(string[] args)
		//{
		//    SoftEtherClient client = new SoftEtherClient();
		//    client.Run();
		//}

		private IMessageWriter _messageWriter;

		public TunnelLogic(IMessageWriter messageWriter)
		{
			_messageWriter = messageWriter;
		}

		public List<string> GetAdapterNames()
		{
			// Retrieve the device list
			var devices = LivePcapDeviceList.Instance;

			// If no devices were found print an error
			if (devices.Count < 1)
			{
				_messageWriter.WriteLine("No devices were found on this machine");
				return new List<string>();
			}

			List<string> deviceNames = new List<string>();
			int i = 0;
	
			// Print out the devices
			foreach (LivePcapDevice dev in devices)
			{
				/* Description */
				deviceNames.Add(string.Format("{0}) {1} {2}", i, dev.Name, dev.Description));
				i++;
			}

			return deviceNames;
		}

		public void StartTunnel(ITunnel tunnel, int adapterIndex)
		{
			SetupTunnel(tunnel);
			SetupInterfaceCapture(adapterIndex);
			Run();
		}

        private void Run()
        {


			_messageWriter.WriteLine(string.Empty);
			_messageWriter.WriteLine("-- Listening on {0}.",
                _device.Description);

            // Start the capturing process
            _device.StartCapture();

        }

		public void StopTunnel()
		{
			// Stop the capturing process
			_device.StopCapture();

			_messageWriter.WriteLine("-- Capture stopped.");

			// Print out the device statistics
			_messageWriter.WriteLine(_device.Statistics().ToString());

			// Close the pcap device
			_device.Close();
		}

        void SetupTunnel(ITunnel tunnel)
        {
			_tunnel = tunnel;
            _tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);

            //Start Polling Thread
            Thread bgThread = new Thread(new ThreadStart(PollingLoop));
            bgThread.Name = "PollingThread";
			bgThread.IsBackground = true;
            bgThread.Start();
        }

        void SetupInterfaceCapture(int adapterIndex)
        {
            _packets = new ArrayList();

            // Retrieve the device list
            var devices = LivePcapDeviceList.Instance;

            // If no devices were found print an error
            if (devices.Count < 1)
            {
                _messageWriter.WriteLine("No devices were found on this machine");
                return;
            }

            _device = devices[adapterIndex];

            // Open the device for capturing
            int readTimeoutMilliseconds = 1000;
            _device.Open(DeviceMode.Promiscuous, readTimeoutMilliseconds);

            //string filter = "ether host 02:50:F2:00:00:01 or ether host FF:FF:FF:FF:FF:FF";
            //_device.SetFilter(filter);

            // Register our handler function to the 'packet arrival' event
            _device.OnPacketArrival +=
                new PacketArrivalEventHandler(device_OnPacketArrival);
        }

        private void device_OnPacketArrival(object sender, CaptureEventArgs e)
        {


                        //do I need to put some kind of lock here?

            byte[] dupPacket = null;
            byte[] incomingPacket = e.Packet.Data;

            while(_lock){}
            _lock = true;

            foreach (byte[] ba in _packets)
            {
                if (ba.Length != incomingPacket.Length)
                    continue;

                int cnt = 0;

                for (; cnt < ba.Length; cnt++)
                {
                    if (ba[cnt] != incomingPacket[cnt])
                        break;
                }

                if (cnt == ba.Length)
                {
                    dupPacket = ba;
                    break;
                }
            }

            if (dupPacket != null)
            {
                _packets.Remove(dupPacket);
            }
            else
            {
                byte[] data = new byte[e.Packet.Data.Length + _headerSize];
                data[0] = (byte)(e.Packet.Data.Length % 256);
                data[1] = (byte)(e.Packet.Data.Length / 256);
                Array.Copy(e.Packet.Data, 0, data, _headerSize, e.Packet.Data.Length);
				_messageWriter.WriteLine("Sending Packet across tunnel");
                if (_tunnel != null) _tunnel.Send(data);
            }

            _lock = false;
        
        }

        void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
        {
            int index = 0;
            int curPktSize = 0;
            byte[] curPkt = null;

            //read each packet from the stream
            while (index < e.Data.Length && e.Data.Length > 1)
            {
                // get the packet size
                curPktSize = e.Data[index] + e.Data[index + 1] * 256;
                curPkt = new byte[curPktSize];

                //copy the packet to it's own array to send on the interface
                Array.Copy(e.Data, index + _headerSize, curPkt, 0, curPktSize);
                _packets.Add(curPkt);

                try
                {
                    if (_device != null) _device.SendPacket(curPkt);
                }
                catch (System.Exception except)  // CS0168
                {
					_messageWriter.WriteLine(except.Message);
                }

				_messageWriter.WriteLine("Putting Packet on iface: {0}", index);
                index += curPktSize + _headerSize;
            }
        }

        private void PollingLoop()
        {
            Byte[] temp = new Byte[1];
            temp[0] = 0;

            while (true)
            {
                Thread.Sleep(500);
                _tunnel.Send(temp);
            }

        }

        private LivePcapDevice _device = null;
        private ITunnel _tunnel = null;
        private ArrayList _packets = null;
        private const int _headerSize = 2;
        private bool _lock = false;
	}
}



