using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using TunnelProxy.Tunnels;
using TunnelProxy.Util;


namespace TunnelProxy.Server.App
{
	class Program
	{
		public static ITunnel Tunnel { get; set; }

		static void Main(string[] args)
		{
			//for testing purposes
			//todo: replace with actual implementation

			try
			{
				Console.WriteLine("Server Running...\nPress Enter to Quit.");
				Tunnel = new HttpServerTunnel("http://+:8080/");
				Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n"  + ex.StackTrace);
			}
			
			Console.ReadLine();

		}

		static void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
		{
			byte[] data = e.Data;
			string request = ConversionUtils.ConvertToString(data);

			Console.WriteLine(request);

			string response = "Got the message";
			byte[] responseData = ConversionUtils.ConvertToBytes(response);


			Tunnel.Send(responseData);
		}
	}
}
