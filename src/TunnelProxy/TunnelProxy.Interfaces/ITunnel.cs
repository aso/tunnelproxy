using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TunnelProxy.Interfaces
{
	public class DataReceivedEventArgs:EventArgs
	{
		public byte[] Data { get; set; }

		public DataReceivedEventArgs(byte[] data)
		{
			Data = data;
		}
	}

	public interface ITunnel
	{
		void Send(byte[] data);
		event EventHandler<DataReceivedEventArgs> DataReceived;
	}
}
