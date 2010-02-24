using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;

namespace TunnelProxy.Tunnels
{
	public class HttpTunnel:ITunnel
	{
		public Uri Address { get; set; }

		public HttpTunnel(Uri address)
		{
			Address = address;
		}

		#region ITunnel Members

		public void Send(byte[] data)
		{
			throw new NotImplementedException();
		}

		public byte[] Receive()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
