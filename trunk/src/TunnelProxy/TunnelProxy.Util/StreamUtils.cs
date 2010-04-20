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

        /* Random number functions based on sample code by  Mahesh Chand */
        /* http://www.c-sharpcorner.com/UploadFile/mahesh/RandomNumber11232005010428AM/RandomNumber.aspx */

        private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        /// Generates a random string with the given length
        private static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }

            return builder.ToString();
        }


        public static string GetRandomName()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
    }
}
