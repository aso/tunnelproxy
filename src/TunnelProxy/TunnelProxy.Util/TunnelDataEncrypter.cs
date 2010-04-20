using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using System.Security.Cryptography; 

namespace TunnelProxy.Util
{
    public class TunnelDataEncrypter: ITunnel
	{
		public TunnelDataEncrypter(ITunnel tunnel, string keypass)
		{
			_tunnel = tunnel;
			_tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Decrypt_DataReceived);
			_myPass = keypass;
		}

		public void Send(byte[] data)
		{
			_tunnel.Send(Encrypt(data, _myPass));
		}

        private void Decrypt_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (DataReceived != null)
            {
                byte[] unencrypted = Decrypt(e.Data, _myPass);
                DataReceived(this, new DataReceivedEventArgs(unencrypted));
            }
        }

        public static byte[] Encrypt(byte[] clearData, string Password) 
        { 
            MemoryStream ms = new MemoryStream();
            Rijndael alg = CreateAlgorithm(Password);

            CryptoStream cs = new CryptoStream(ms,
               alg.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(clearData, 0, clearData.Length);

            cs.FlushFinalBlock();

            cs.Close();

            byte[] encryptedData = ms.ToArray();

            return encryptedData; 
        }

        public static byte[] Decrypt(byte[] cipherData, string Password) 
        { 
            MemoryStream ms = new MemoryStream();
 
            Rijndael alg = CreateAlgorithm(Password);
 
            CryptoStream cs = new CryptoStream(ms,
                alg.CreateDecryptor(), CryptoStreamMode.Write);
 
            cs.Write(cipherData, 0, cipherData.Length);
 
            cs.FlushFinalBlock();
 
            cs.Close();
 
            byte[] decryptedData = ms.ToArray();
 
            return decryptedData; 
        }

        private static Rijndael CreateAlgorithm(string Password)
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
                            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
 
            Rijndael alg = Rijndael.Create();
 
            alg.Key = pdb.GetBytes(32);
            alg.IV = pdb.GetBytes(16);
 
            return (alg);
        }

        private ITunnel _tunnel;

        private string _myPass; 

        public event EventHandler<DataReceivedEventArgs> DataReceived;
	}
}
