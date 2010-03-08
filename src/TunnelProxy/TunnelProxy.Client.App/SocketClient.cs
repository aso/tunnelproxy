using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using System.Net;
using System.Net.Sockets;

namespace TunnelProxy.Client.App
{

    class SocketClient
    {
        public SocketClient(ITunnel Tunnel)
        {

            this.Tunnel = Tunnel;
            //Register DataReceived handler with the tunnel
            Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(SocketClient_DataReceived);

            //open server socket

            Int32 port = 13000;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            tcpListener = new TcpListener(localAddr, port);
            tcpListener.Start();
        }

        public void HandleMessages()
        {
            int i;
            Byte[] bytes = new Byte[1024];

            //Wait for new connection
            client = tcpListener.AcceptTcpClient();
            networkStream = client.GetStream();

            // Loop to receive all the data sent by the client.
            while ((i = networkStream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Send through Tunnel
                System.Console.WriteLine(Encoding.UTF8.GetString(bytes));
                Tunnel.Send(bytes);
            }

            // Shutdown and end connection
            client.Close();
        }

        void SocketClient_DataReceived(object sender, DataReceivedEventArgs e)
		{
			byte[] data = e.Data;
            System.Console.WriteLine("Got Some Data from server");
            networkStream.Write(data, 0, data.Length);
		}

        //Member Objects
        ITunnel Tunnel;
        TcpListener tcpListener;
        TcpClient client;
        NetworkStream networkStream;
    }




}
