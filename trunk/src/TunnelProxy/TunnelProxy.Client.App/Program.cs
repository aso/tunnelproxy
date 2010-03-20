using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using TunnelProxy.Tunnels;
using TunnelProxy.Util;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TunnelProxy.Client.App
{
	class Program
	{
		public static ITunnel Tunnel { get; set; }

		static void Main(string[] args)
		{
			//put in for testing purposes
			//todo: replace with actually implementation

			Console.WriteLine("Client started");
			Console.WriteLine("Enter Address to request data from");




			//Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);
            Int32 port = 13000;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            //open server socket
            TcpListener tcpListener = new TcpListener(localAddr, port);
            tcpListener.Start();

            //create the Tunnel
            Tunnel = new HttpTunnel(new Uri("http://localhost:8080"), "POST");

            while (true)
            {
                //Wait for new connection
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                SocketClient sclient = new SocketClient(Tunnel, tcpClient);

                sclient.HandleMessages();
            }
            
			while (true)
			{
				string request = Console.ReadLine();
				byte[] data = ConversionUtils.ConvertToBytes(request);
				Tunnel.Send(data);
			}
            

		}

		static void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
		{
			byte[] data = e.Data;
			string response = ConversionUtils.ConvertToString(data);

			Console.WriteLine("Response from Server: " + response);
		}
	}
}
