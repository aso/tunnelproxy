using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using System.Net;
using System.Net.Sockets;
using System.IO;
using TunnelProxy.Util;

namespace TunnelProxy.Server.App
{
    class HttpProxyHandler
    {
        public HttpProxyHandler(ITunnel Tunnel)
        {
            this.Tunnel = Tunnel;
            Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);
        }

        void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
        {
            int i;
            int totalSize = 2;
            byte[] data = e.Data;
            byte[] buffer = new Byte[1024];
            byte[] respData = new Byte[2];
            byte[] tempData;
            
            respData[0] = (byte)'-';
            respData[1] = (byte)'-';

            //print data for debugging
            string request = System.Text.Encoding.UTF8.GetString(data);


            if (client == null || !client.Connected)
            {
                if(request.Contains("Host") != false)
                   ConnectToHost(request);
                else
                {
                   Tunnel.Send(respData);
                   return;
                }
            }

            System.Console.WriteLine("--->Recvd {0} bytes from client", data.Length);
            System.Console.WriteLine(ConversionUtils.ConvertToString(data));
            NetworkStream networkStream = client.GetStream();

            if (data.Length > 2)
            {  
                networkStream.Write(data, 0, data.Length);
                System.Console.WriteLine("<--->waiting for response");
            }

                try
                {
                    if (networkStream.DataAvailable)//while (totalSize < dataLength)
                    {
                        i = networkStream.Read(buffer, 0, buffer.Length);
                        System.Console.WriteLine("Read Resp: {0}", i);
                        tempData = new Byte[totalSize + i];

                        Array.Copy(respData, 0, tempData, 0, totalSize);
                        Array.Copy(buffer, 0, tempData, totalSize, i);

                        respData = tempData;
                        totalSize += i;
                    }
                }
                catch (Exception except)
                {
                    Console.WriteLine("Error: {0}", except.Message);
                }

                System.Console.WriteLine("--->Sent {0} bytes to client", respData.Length);
                Tunnel.Send(respData);
        }

        void ConnectToHost(string request)
        {
            StringReader reader = new StringReader(request);
            string server;            

            string line = reader.ReadLine();

            while (line.Contains("Host: ") == false)
            {
                line = reader.ReadLine();
            }

            server = line.TrimStart("Host: ".ToCharArray());

            Console.WriteLine("Connecting to: {0}", server);
            client = new TcpClient(server, 80);
        }

        //Member Objects
        ITunnel Tunnel;
        Boolean continued = false;
        TcpClient client = null;
    }
}
