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
            byte connectionNum = 1;
			IPAddress localAddr = IPAddress.Parse(localIPAddress);

			//open server socket
			TcpListener tcpListener = new TcpListener(localAddr, localPort);
			tcpListener.Start();

			while (true)
			{
				//Wait for new connection
				TcpClient tcpClient = tcpListener.AcceptTcpClient();
                SocketClient sclient = new SocketClient(tunnel, tcpClient, _messageWriter, connectionNum++);

                Thread bgThread = new Thread(new ThreadStart(sclient.HandleMessages));
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

	}
}
