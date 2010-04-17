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

namespace SoftEther.Client.App
{
    class SoftEtherClient
    {
        static void Main(string[] args)
        {
            SoftEtherClient client = new SoftEtherClient();
            client.Run();
        }

        public SoftEtherClient()
        {
            string url = "http://localhost:8080";
            SetupTunnel(url);
            SetupInterfaceCapture();
        }

        public void Run()
        {


            Console.WriteLine();
            Console.WriteLine("-- Listening on {0}, hit 'Enter' to stop...",
                _device.Description);

            // Start the capturing process
            _device.StartCapture();

            // Wait for 'Enter' from the user.
            Console.ReadLine();

            // Stop the capturing process
            _device.StopCapture();

            Console.WriteLine("-- Capture stopped.");

            // Print out the device statistics
            Console.WriteLine(_device.Statistics().ToString());

            // Close the pcap device
            _device.Close();

        }

        void SetupTunnel(string url)
        {
            _tunnel = new HttpTunnel(new Uri(url), "POST");
            _tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);

            //Start Polling Thread
            Thread bgThread = new Thread(new ThreadStart(PollingLoop));
            bgThread.Name = "PollingThread";
            bgThread.Start();
        }

        void SetupInterfaceCapture()
        {
            _packets = new ArrayList();

            // Retrieve the device list
            var devices = LivePcapDeviceList.Instance;

            // If no devices were found print an error
            if (devices.Count < 1)
            {
                Console.WriteLine("No devices were found on this machine");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("The following devices are available on this machine:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            int i = 0;

            // Print out the devices
            foreach (LivePcapDevice dev in devices)
            {
                /* Description */
                Console.WriteLine("{0}) {1} {2}", i, dev.Name, dev.Description);
                i++;
            }

            Console.WriteLine();
            Console.Write("-- Please choose virtual adaptor: ");
            i = int.Parse(Console.ReadLine());

            _device = devices[i];

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
                Console.WriteLine("Sending Packet across tunnel");
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
                    System.Console.WriteLine(except.Message);
                }

                Console.WriteLine("Putting Packet on iface: {0}", index);
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
        private HttpTunnel _tunnel = null;
        private ArrayList _packets = null;
        private const int _headerSize = 2;
        private bool _lock = false;
    }
}
