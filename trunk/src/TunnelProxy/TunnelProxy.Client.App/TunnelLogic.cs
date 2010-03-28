using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TunnelProxy.Interfaces;
using System.Net;
using System.Net.Sockets;
using TunnelProxy.Util;


namespace TunnelProxy.Client.App
{
	public class TunnelLogic
	{
		//public static ITunnel Tunnel { get; set; }
		private IMessageWriter _messageWriter;

		public TunnelLogic(IMessageWriter messageWriter)
		{
			_messageWriter = messageWriter;
		}

		public void StartTunnel(ITunnel tunnel, string localIPAddress, int localPort )
		{
            UInt16 connectionNum = 1;
			IPAddress localAddr = IPAddress.Parse(localIPAddress);
            _tunnel = tunnel;

			//open server socket
			TcpListener tcpListener = new TcpListener(localAddr, localPort);
			tcpListener.Start();

            _messageWriter.WriteLine("Starting Tunnel Client");

            //Start Polling Thread
            Thread bgThread = new Thread(new ThreadStart(PollingLoop));
            bgThread.Name = "PollingThread";
            bgThread.Start();

			while (true)
			{
				//Wait for new connection
				TcpClient tcpClient = tcpListener.AcceptTcpClient();
                SocketClient sclient = new SocketClient(tunnel, tcpClient, _messageWriter, connectionNum++);

                bgThread = new Thread(new ThreadStart(sclient.HandleMessages));
                bgThread.Name = "SocketClientThread";
                bgThread.Start();
			}

		}

		private void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
		{
			byte[] data = e.Data;
			string response = ConversionUtils.ConvertToString(data);

			_messageWriter.WriteLine("Response from Server: " + response);
		}

        public void PollingLoop()
        {
            UInt16 connNumber = 0;
            Byte[] temp = new Byte[(int)HeaderIndex.HeaderSize];
            byte[] connBytes = BitConverter.GetBytes(connNumber);
            Array.Copy(connBytes, 0, temp, (int)HeaderIndex.ConnectionNumber, connBytes.Length);

            while (true)
            {
                Thread.Sleep(500);
                _tunnel.Send(temp);
            }

        }

        private ITunnel _tunnel;
	}
}
