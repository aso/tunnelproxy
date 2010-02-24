using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TunnelProxy.Interfaces
{
	public interface ITunnel
	{
		void Send(byte[] data);
		byte[] Receive();
	}
}
