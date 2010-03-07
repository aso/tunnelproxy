using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TunnelProxy.Util
{
	public static class StreamUtils
	{
		public static byte[] ReadAllBytes(Stream stream)
		{
			StreamReader reader = null;
			byte[] results;
			try
			{
				reader = new StreamReader(stream);
				string responseString = reader.ReadToEnd();
				results = ConversionUtils.ConvertToBytes(responseString);
			}
			finally
			{
				if (reader != null)
					reader.Close();
			}
			return results;
		}
	}
}
