using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TunnelProxy.Util
{
    public enum HeaderIndex
    {
        ConnectionNumber = 0,
        Command = 2,
        HeaderSize
    }

    public enum HeaderCommands : byte
    {
        DataTransfer = 0,
        CloseConnection = 1
    }

	public static class StreamUtils
	{
		public static byte[] ReadAllBytes(Stream stream)
		{
			BinaryReader reader = null;
			byte[] results = new byte[0];
			try
			{
				reader = new BinaryReader(stream);
				//string responseString = reader.ReadToEnd();
				//results = ConversionUtils.ConvertToBytes(responseString);

                
                results = reader.ReadBytes(1000000);
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
