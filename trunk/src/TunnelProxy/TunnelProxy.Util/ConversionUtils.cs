using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TunnelProxy.Util
{
	public static class ConversionUtils
	{
		public static byte[] ConvertToBytes(string str)
		{
			return Encoding.UTF8.GetBytes(str);
		}

		public static string ConvertToString(byte[] bytes)
		{
			return Encoding.UTF8.GetString(bytes);
		}
	}
}
