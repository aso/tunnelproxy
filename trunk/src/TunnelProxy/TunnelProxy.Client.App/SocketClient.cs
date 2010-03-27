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
        public SocketClient(ITunnel Tunnel, TcpClient tcpclient, IMessageWriter messageWriter, byte socketId)
        {
            _client = tcpclient;
            _tunnel = Tunnel;
			_messageWriter = messageWriter;
            _socketId = socketId;
            //Register DataReceived handler with the tunnel
            Tunnel.DataReceived += new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);
        }

        public void HandleMessages()
        {
            int i;
            Byte[] temp = new Byte[10240];
            Byte[] bytes;


            _networkStream = _client.GetStream();

            // Loop to receive all the data sent by the client.
            while (_client.Connected && !_disconnect)
            {    
                i = _networkStream.Read(temp, 0, temp.Length);

                if (i > 0)
                {
                    bytes = new byte[i + 1];
                    bytes[0] = _socketId;
                    Array.Copy(temp, 0, bytes, 1, i);

                    _messageWriter.WriteLine("--->Sent {0} bytes to server", bytes.Length);
                    _messageWriter.WriteLine(ConversionUtils.ConvertToString(bytes));
                    _tunnel.Send(bytes);
                }
                else
                {
                    _tunnel.DataReceived -= new EventHandler<DataReceivedEventArgs>(Tunnel_DataReceived);
                    break;
                }
            }

            // Shutdown and end connection
            _client.Close();
        }

        void Tunnel_DataReceived(object sender, DataReceivedEventArgs e)
		{
			byte[] data = e.Data;

            if (data[0] == _socketId)
            {
                _messageWriter.WriteLine("<---Recvd {0} bytes from server", data.Length);
                _networkStream.Write(data, 1, data.Length - 1);
            }
		}

        //Member Objects
		private ITunnel _tunnel;
        private TcpClient _client;
        private NetworkStream _networkStream;
        private byte _socketId;
        private bool _disconnect = false;
		private IMessageWriter _messageWriter;
    }




}
