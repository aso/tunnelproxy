using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TunnelProxy.Interfaces
{
	public interface IMessageWriter
	{
		void WriteLine(string value);

		void WriteLine(string format, object arg0);
	}
}
