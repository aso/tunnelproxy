using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using System.Net;
using System.Net.Sockets;
using TunnelProxy.Util;

namespace TunnelProxy.Client.App
{

    class SocketClient
    {
        public SocketClient(ITunnel Tunnel)
        {

            this.Tunnel = Tunnel;
            //Register DataReceived handler with the tunnel
            Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);

            //open server socket

            Int32 port = 13000;
            IPAddress localAddr = IPAddress.Parse("192.168.1.102");

            tcpListener = new TcpListener(localAddr, port);
            tcpListener.Start();
        }

        public void HandleMessages()
        {
            int i;
            Byte[] temp = new Byte[10240];
            Byte[] bytes;

            //Wait for new connection
            client = tcpListener.AcceptTcpClient();
            networkStream = client.GetStream();

            // Loop to receive all the data sent by the client.
            while (client.Connected)
            {    
                i = networkStream.Read(temp, 0, temp.Length);
                bytes = new byte[i];
                Array.Copy(temp, 0, bytes, 0, i);

                System.Console.WriteLine("--->Sent {0} bytes to server", bytes.Length);
                System.Console.WriteLine(ConversionUtils.ConvertToString(bytes));
                Tunnel.Send(bytes);

            }

            // Shutdown and end connection
            client.Close();
        }

        void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
		{
			byte[] data = e.Data;
            System.Console.WriteLine("<---Recvd {0} bytes from server", data.Length);
            networkStream.Write(data, 2, data.Length - 2);
		}

        //Member Objects
        ITunnel Tunnel;
        TcpListener tcpListener;
        TcpClient client;
        NetworkStream networkStream;
    }




}
