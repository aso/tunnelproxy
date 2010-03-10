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
            byte[] buffer = new Byte[10240];
            byte[] respData = new Byte[2];
            byte[] tempData;
            
            respData[0] = (byte)'-';
            respData[1] = (byte)'-';

            //print data for debugging
            string request = System.Text.Encoding.UTF8.GetString(data);
            System.Console.WriteLine("--->Recvd {0} bytes from client", data.Length);



            if (!continued) ConnectToHost(request);


            System.Console.WriteLine(ConversionUtils.ConvertToString(data));
            NetworkStream networkStream = client.GetStream();
            networkStream.Write(data, 0, data.Length);
           
            // Shutdown and end connection
            if (request.Contains("\r\n\r\n"))
            {
                continued = false;
                
                System.Console.WriteLine("<--->waiting for response");
                // Loop to receive all the data sent by the client.            
                //while ((i = networkStream.Read(buffer, 0, buffer.Length)) != 0)
                i = networkStream.Read(buffer, 0, buffer.Length);
                {
                    System.Console.WriteLine("Read Resp: {0}", i);
                    tempData = new Byte[totalSize + i];

                    Array.Copy(respData, 0, tempData, 0, totalSize);
                    Array.Copy(buffer, 0, tempData, totalSize, i);

                    respData = tempData;
                    totalSize += i;
                }

                System.Console.WriteLine("Got Resp");
                System.Console.WriteLine("--->Sent {0} bytes to client", respData.Length);
                Tunnel.Send(respData);

                client.Close();
            }
            else
            {
                System.Console.WriteLine("<--->partial request, waiting for more");
                Tunnel.Send(respData);
                continued = true;
            }

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
        TcpClient client;
    }
}
