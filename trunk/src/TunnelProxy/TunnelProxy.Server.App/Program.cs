using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using TunnelProxy.Tunnels;
using TunnelProxy.Util;
using System.Net;
using System.IO;


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


				//Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);

                HttpProxyHandler handler = new HttpProxyHandler(Tunnel);


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}

			Console.ReadLine();

		}

		static void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
		{
			byte[] data = e.Data;
			string request = ConversionUtils.ConvertToString(data);

			Console.WriteLine("Got message: " + request);

			byte[] responseData = GetHttpData(request);

			//string response = "Got the message";
			//byte[] responseData = ConversionUtils.ConvertToBytes(response);


			Tunnel.Send(responseData);
		}

		static byte[] GetHttpData(string address)
		{
			byte[] results;
			Stream responseStream = null;
			try
			{

				Uri uri = new Uri(address);
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				responseStream = response.GetResponseStream();
				results = StreamUtils.ReadAllBytes(responseStream);
			}
			finally
			{
				if (responseStream != null)
					responseStream.Close();
			}
			return results;

			
		}
	}
}
