using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
			//Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);
			//Int32 port = 13000;
			IPAddress localAddr = IPAddress.Parse(localIPAddress);

			//open server socket
			TcpListener tcpListener = new TcpListener(localAddr, localPort);
			tcpListener.Start();

			//create the Tunnel
			//Tunnel = new HttpTunnel(new Uri("http://localhost:8080"), "POST");

			while (true)
			{
				//Wait for new connection
				TcpClient tcpClient = tcpListener.AcceptTcpClient();

				SocketClient sclient = new SocketClient(tunnel, tcpClient, _messageWriter);

				sclient.HandleMessages();
			}

			//while (true)
			//{
			//    string request = Console.ReadLine();
			//    byte[] data = ConversionUtils.ConvertToBytes(request);
			//    tunnel.Send(data);
			//}
		}

		private void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
		{
			byte[] data = e.Data;
			string response = ConversionUtils.ConvertToString(data);

			_messageWriter.WriteLine("Response from Server: " + response);
		}

	}
}
