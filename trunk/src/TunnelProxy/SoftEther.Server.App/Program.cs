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

namespace SoftEther.Server.App
{
    class SoftEtherServer
    {
        static void Main(string[] args)
        {
            SoftEtherServer server = new SoftEtherServer();
            server.Run();
        }

        public SoftEtherServer()
        {
            string url = "http://+:8080/";


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
            _tunnel = new HttpServerTunnel(url);
            _tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);
        }

        void SetupInterfaceCapture()
        {
            _packets = new ArrayList();
            _dataToSend = new byte[_recvBufferSize];

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
            Console.Write("-- Please choose Physical adaptor: ");
            i = int.Parse(Console.ReadLine());

            _device = devices[i];

            // Open the device for capturing
            int readTimeoutMilliseconds = 1000;
            _device.Open(DeviceMode.Promiscuous, readTimeoutMilliseconds);

            string filter = "ether host 02:50:F2:00:00:01 or ether host FF:FF:FF:FF:FF:FF";
            _device.SetFilter(filter);

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
                // if the buffer isn't big enough, double it.
                if (_dataToSendIndex + incomingPacket.Length >= _recvBufferSize)
                {
                    _recvBufferSize *= 2;
                    _dataToSend = new byte[_recvBufferSize];
                }

                //copy packet into buffer until it is requested by the other side
                Array.Copy(incomingPacket, 0, _dataToSend, _dataToSendIndex + _headerSize, incomingPacket.Length);
                _dataToSend[_dataToSendIndex] = (byte)(incomingPacket.Length % 256);
                _dataToSend[_dataToSendIndex+1] = (byte)(incomingPacket.Length / 256);
                _dataToSendIndex += (incomingPacket.Length + _headerSize);
                Console.WriteLine("Adding Packet to buffer for tunnel");
            }

            _lock = false;
        }

        void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
        {
            int index = 0;
            int curPktSize = 0;
            byte[] curPkt = null;

            while (_lock) { }
            _lock = true;

            //read each packet from the stream
            while (index < e.Data.Length  && e.Data.Length > 1)
            {
                // get the packet size
                curPktSize = e.Data[index] + e.Data[index+1]*256;
                curPkt = new byte[curPktSize];

                //copy the packet to it's own array to send on the interface
                Array.Copy(e.Data, index + _headerSize, curPkt, 0, curPktSize);
                _packets.Add(curPkt);
                if (_device != null)
                {
                    _device.SendPacket(curPkt);
                    Console.WriteLine("Putting Packet on iface: {0}", index);
                }
                index += curPktSize + _headerSize;
            }

            //send any packets waiting to be sent
            if (_dataToSendIndex == 0)
            {
                _dataToSendIndex = 1;
                _dataToSend[0] = 0;
            }
            else
            {
                Console.WriteLine("Sending Packets");
            }

            Array.Resize(ref _dataToSend, _dataToSendIndex);
            _tunnel.Send(_dataToSend);

            _dataToSend = new byte[_recvBufferSize];
            _dataToSendIndex = 0;

            _lock = false;
        }
  
        private LivePcapDevice _device = null;
        private HttpServerTunnel _tunnel = null;

        private ArrayList _packets = null;
        private byte[] _dataToSend = null;
        private int _dataToSendIndex = 0;

        private int _recvBufferSize = 10000;
        private const int _headerSize = 2;

        private bool _lock = false;
    }
}