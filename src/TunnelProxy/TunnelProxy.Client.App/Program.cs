using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using TunnelProxy.Tunnels;

namespace TunnelProxy.Client.App
{
	class Program
	{
		public static ITunnel Tunnel { get; set; }

		static void Main(string[] args)
		{
			//put in for testing purposes
			//todo: replace with actually implementation

			Tunnel = new HttpTunnel(new Uri("http://localhost:8080"), "POST");
			Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);

			while (true)
			{
				string request = Console.ReadLine();
				byte[] data = System.Text.Encoding.UTF8.GetBytes(request);
				Tunnel.Send(data);
			}

		}

		static void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
		{
			byte[] data = e.Data;
			string response = System.Text.Encoding.UTF8.GetString(data);

			Console.WriteLine("Response from Server: " + response);
		}
	}
}
