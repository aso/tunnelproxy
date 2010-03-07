using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using TunnelProxy.Tunnels;
using TunnelProxy.Util;

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

			Tunnel = new HttpTunnel(new Uri("http://localhost:8080"), "POST");
			Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);

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
