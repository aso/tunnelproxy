using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using System.Net;
using System.IO;

namespace TunnelProxy.Tunnels
{
	public class HttpTunnel : ITunnel
	{
		public Uri Address { get; set; }
		public string RequestMethod { get; set; }

		public HttpTunnel(Uri address, string requestMethod)
		{
			Address = address;
			RequestMethod = requestMethod;
		}

		#region ITunnel Members

		public void Send(byte[] data)
		{
			WebResponse response = null;
			Stream dataStream = null;
			StreamReader reader = null;
			try
			{
				WebRequest request = WebRequest.Create(Address);
				request.Method = RequestMethod;
				//request.ContentType = "application/x-www-form-urlencoded";
				request.ContentLength = data.Length;
				dataStream = request.GetRequestStream();
				dataStream.Write(data, 0, data.Length);
				dataStream.Close();

				response = request.GetResponse();
				dataStream = response.GetResponseStream();

				reader = new StreamReader(dataStream);
				string responseString = reader.ReadToEnd();
				byte[] results = System.Text.Encoding.UTF8.GetBytes(responseString);

				//byte[] results = new byte[dataStream.Length - 1];

				//dataStream.Read(results, 0, results.Length);
				if (DataReceived != null)
					DataReceived(this, new DataReceivedEventArgs(results));

			}
			finally
			{
				if (dataStream != null)
					dataStream.Close();
				if (response != null)
					response.Close();
			}

		}
		public event EventHandler<DataReceivedEventArgs> DataReceived;


		#endregion


	}
}
