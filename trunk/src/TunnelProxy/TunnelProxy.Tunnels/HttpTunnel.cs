using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using System.Net;
using System.IO;
using System.Threading;
using TunnelProxy.Util;

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

            while (waiting) Thread.Sleep(1);

            waiting = true;

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

				byte[] results = StreamUtils.ReadAllBytes(dataStream);

                if (DataReceived != null)
                {
                    DataReceived(this, new DataReceivedEventArgs(results));
                }

			}
			finally
			{
				if (dataStream != null)
					dataStream.Close();
				if (response != null)
					response.Close();
			}

            waiting = false;

		}

		public event EventHandler<DataReceivedEventArgs> DataReceived;


		#endregion

        bool waiting = false;
	}
}
