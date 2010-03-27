using System;
using System.Collections;
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
        public HttpProxyHandler(ITunnel tunnel, IMessageWriter messageWriter)
        {
            _clients = new Hashtable();
            _tunnel = tunnel;
			_messageWriter = messageWriter;
            _tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);
        }

        private void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
        {
            byte[] data = e.Data;
            bool status = false;

            if (data[0] == 0)
            {
                foreach (byte key in _clients.Keys)
                {
                    data[0] = key;
                    status = HandleMessage(data);

                    if (status == true) break;
                }
            }
            else
            {
                status = HandleMessage(data);
            }

            if (status == false)
            {
                byte[] response = new byte[1];
                response[0] = 0;
                _tunnel.Send(response);
            }
        }

        private bool HandleMessage(byte[] data)
        {
            TcpClient client = null;
            int i = 0;
            byte[] respData = new Byte[1024];

            //print data for debugging
            string request = System.Text.Encoding.UTF8.GetString(data);
            client =(TcpClient)_clients[data[0]];
            respData[0] = data[0];

            if (client == null || !client.Connected)
            {
                if (request.Contains("Host") != false)
                {
                    client = ConnectToHost(request);
                    _clients.Add(data[0], client);
                }
                else
                {
                    return false;
                }
            }

            _messageWriter.WriteLine("--->Recvd {0} bytes from client", data.Length);
            _messageWriter.WriteLine(ConversionUtils.ConvertToString(data));

            NetworkStream networkStream = client.GetStream();

            if (data.Length > 1)
            {  
                networkStream.Write(data, 1, data.Length - 1);
				_messageWriter.WriteLine("<--->waiting for response");
            }

             try
             {
                if (networkStream.DataAvailable)//while (totalSize < dataLength)
                {
                   i = networkStream.Read(respData, 1, respData.Length - 1);
					_messageWriter.WriteLine("Read Resp: {0}", i);

                }

              }
              catch (Exception except)
              {
			     _messageWriter.WriteLine("Error: {0}", except.Message);
              }

             if (i == 0)
             {
                 return (false);
             }

              Array.Resize(ref respData, i + 1);
			  _messageWriter.WriteLine("--->Sent {0} bytes to client", respData.Length);
              _tunnel.Send(respData);
              return (true);
        }

        TcpClient ConnectToHost(string request)
        {
            TcpClient client;
            StringReader reader = new StringReader(request);
            string server;            

            string line = reader.ReadLine();

            while (line.Contains("Host: ") == false)
            {
                line = reader.ReadLine();
            }

            server = line.TrimStart("Host: ".ToCharArray());

            _messageWriter.WriteLine("Connecting to: {0}", server);
            client = new TcpClient(server, 80);

            return (client);
        }

        //Member Objects
        private ITunnel _tunnel;
		private IMessageWriter _messageWriter;
        //private Boolean _continued = false;
        Hashtable _clients = null;
    }
}
