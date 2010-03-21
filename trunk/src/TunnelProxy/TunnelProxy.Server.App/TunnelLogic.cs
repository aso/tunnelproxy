using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

using TunnelProxy.Interfaces;
using TunnelProxy.Tunnels;
using TunnelProxy.Util;


namespace TunnelProxy.Server.App
{
	class TunnelLogic
	{
		private IMessageWriter _messageWriter;

		public TunnelLogic(IMessageWriter messageWriter)
		{
			_messageWriter = messageWriter;
		}

		public void StartTunnel(ITunnel tunnel)
		{
			//for testing purposes
			//todo: replace with actual implementation

			try
			{
				_messageWriter.WriteLine("Server Running...\nPress Enter to Quit.");

				//Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);

                HttpProxyHandler handler = new HttpProxyHandler(tunnel, _messageWriter);


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}

			//Console.ReadLine();

		}

		//private void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
		//{
		//    byte[] data = e.Data;
		//    string request = ConversionUtils.ConvertToString(data);

		//    Console.WriteLine("Got message: " + request);

		//    byte[] responseData = GetHttpData(request);

		//    //string response = "Got the message";
		//    //byte[] responseData = ConversionUtils.ConvertToBytes(response);


		//    Tunnel.Send(responseData);
		//}

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
