using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using System.Net;
using System.IO;

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
			StreamReader reader = null;
			try
			{
				_tempContext = _httpListener.EndGetContext(result);
				inputStream = _tempContext.Request.InputStream;
				reader = new StreamReader(inputStream);
				string request = reader.ReadToEnd();
				byte[] data = System.Text.Encoding.UTF8.GetBytes(request);
				//inputStream.Read(data, 0, data.Length);
				if (DataReceived != null)
					DataReceived(this, new DataReceivedEventArgs(data));

			}
			finally
			{
				if (inputStream != null)
					inputStream.Close();
				if(reader!=null)
					reader.Close();
			}
		}

		#region ITunnel Members

		public void Send(byte[] data)
		{
			HttpListenerResponse response = null;
			Stream dataStream = null;
			try
			{
				response = _tempContext.Response;
				response.ContentLength64 = data.Length;
				dataStream = response.OutputStream;
				dataStream.Write(data, 0, data.Length);

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


	}
}
