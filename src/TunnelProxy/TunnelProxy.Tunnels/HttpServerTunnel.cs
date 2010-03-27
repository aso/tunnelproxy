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
	public class HttpServerTunnel : ITunnel
	{
		private HttpListener _httpListener = new HttpListener();
		private HttpListenerContext _tempContext;

		public HttpServerTunnel(string prefix)
		{
			_httpListener.Prefixes.Add(prefix);

			_httpListener.Start();

			_httpListener.BeginGetContext(new AsyncCallback(GetContextCallBack), null);

		}

		private void GetContextCallBack(IAsyncResult result)
		{
			Stream inputStream = null;
			try
			{
				_tempContext = _httpListener.EndGetContext(result);
				inputStream = _tempContext.Request.InputStream;
				byte[] temp = StreamUtils.ReadAllBytes(inputStream);

                if (DataReceived != null)
                {
                    byte[] data = new byte[temp.Length - 2];
                    Array.Copy(temp, 2, data, 0, data.Length);
                    DataReceived(this, new DataReceivedEventArgs(data));
                }

                waiting = false;

			}
			finally
			{
				if (inputStream != null)
					inputStream.Close();
			}
		}

		#region ITunnel Members

		public void Send(byte[] data)
		{
			HttpListenerResponse response = null;
			Stream dataStream = null;
			try
			{
                while(waiting) Thread.Sleep(1);

                waiting = true;

                byte[] temp = new byte[data.Length + 2];

                Array.Copy(data, 0, temp, 2, data.Length);

				response = _tempContext.Response;
                response.ContentLength64 = temp.Length;
				dataStream = response.OutputStream;
                dataStream.Write(temp, 0, temp.Length);

				_httpListener.BeginGetContext(new AsyncCallback(GetContextCallBack), null);
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

        bool waiting = false;

	}
}
