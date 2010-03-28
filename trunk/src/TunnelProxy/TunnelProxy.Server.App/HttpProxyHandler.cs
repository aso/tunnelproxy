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
    enum SocksStatus
    {
        ReqGranted = 0x5a,
        ReqRejected = 0x5b,
        ReqNotReachable = 0x5c,
        ReqBadUserId = 0x5d
    }

    enum SocksCommands
    {
        EstablishStream = 0x01,
        EstablishPortBind = 0x02
    }

    enum SocksHeaderDataIndex : int
    {
        Version = 0,
        Command = 1,
        Status = 1,
        Port = 2,
        IP = 4,
        HeaderEnd = 8
    }

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
            byte[] data = new byte[e.Data.Length - (int)HeaderIndex.HeaderSize];
            byte[] respData = null;

            //Fill in data array
            Array.Copy(e.Data, (int)HeaderIndex.HeaderSize, data, 0, e.Data.Length - (int)HeaderIndex.HeaderSize);

            UInt16 connNumber = BitConverter.ToUInt16(e.Data, (int)HeaderIndex.ConnectionNumber);
            byte command = e.Data[(int)HeaderIndex.Command];

            //If we received a poll command, loop through all open connections and see if there is any data 
            // to send
            if (connNumber == 0)
            {                
                foreach (UInt16 key in _clients.Keys)
                {
                    connNumber = key;
                    respData = HandleMessage((TcpClient)_clients[key], data);

                    if (respData.Length > 0) break; 
                }
            }
            else 
            {
                //We received data for a specific destination, open if needed
                TcpClient client = (TcpClient)_clients[connNumber];

                if (client == null)
                {
                    //Check to see if it is a SOCKS connection request
                    if (data[(int)SocksHeaderDataIndex.Version] == 0x04)
                    {
                        respData = HandleSOCKSConnection(connNumber, data);
                    }
                    else  //Try as a HTTP request
                    {
                        if (HandleHTTPConnection(connNumber, data))
                        {
                            client = (TcpClient)_clients[connNumber];
                            respData = HandleMessage(client, data);
                        }
                        else
                        {
                            //error handle-- future: close client connection?
                            command = (byte)HeaderCommands.CloseConnection;
                        }
                    }
                }
                else
                {
                    //seems like we already have a connection established, send data
                    respData = HandleMessage(client, data);
                }
            }

            if (respData == null)
            {
                //we're expecting this array to be allocated below, 
                //size of zero makes our math work for no data received
                respData = new byte[0];
            }
            else
            {
                _messageWriter.WriteLine("--->Sent {0} bytes to client", respData.Length);
            }

            //Create response packet, fill in header and data
            byte[] response = new byte[respData.Length + (int)HeaderIndex.HeaderSize];
            byte[] connBytes = BitConverter.GetBytes(connNumber);
            Array.Copy(connBytes, 0, response, (int)HeaderIndex.ConnectionNumber, connBytes.Length);
            Array.Copy(respData, 0, response, (int)HeaderIndex.HeaderSize, respData.Length);

            _tunnel.Send(response);         

        }

        private byte[] HandleMessage(TcpClient client, byte[] data)
        {
            int i = 0;
            NetworkStream networkStream = client.GetStream();
            byte[] respData = new byte[1024];

            if (data.Length > 0)
            {
               _messageWriter.WriteLine("--->Recvd {0} bytes from client", data.Length);
               _messageWriter.WriteLine(ConversionUtils.ConvertToString(data));

                //write new data from client to socket
                networkStream.Write(data, 0, data.Length);
            }

             try
             {
                if (networkStream.DataAvailable)
                {
                   i = networkStream.Read(respData, 0, respData.Length);
					_messageWriter.WriteLine("Read Resp: {0}", i);

                }

              }
              catch (Exception except)
              {
			     _messageWriter.WriteLine("Error: {0}", except.Message);
              }

              Array.Resize(ref respData, i);

              return (respData);
        }

        private bool HandleHTTPConnection(UInt16 connIndex, byte[] data)
        {
            TcpClient client = null;

            //print data for debugging
            string request = System.Text.Encoding.UTF8.GetString(data);
 
            if (request.Contains("Host") != false)
            {
                client = ConnectToHost(request);
                _clients.Add(connIndex, client);             
            }

            return (client != null);
        }

        private byte[] HandleSOCKSConnection(UInt16 connIndex, byte[] data)
        {
            TcpClient client = null;
            byte[] respData = new Byte[(int)SocksHeaderDataIndex.HeaderEnd];
            UInt16 port;
            UInt32 ip;            

            //print data for debugging
            _messageWriter.WriteLine("Handling SOCKS Request");

            //fill in reponse data
            Array.Copy(data, 0, respData, 0, respData.Length); //copy port & ip to resp

            respData[(int)SocksHeaderDataIndex.Version] = 0x00; //just set to NULL
            

            //convert port & IP from network byte order
            Array.Reverse(data, (int)SocksHeaderDataIndex.Port, 2);
            //Array.Reverse(data, (int)SocksHeaderDataIndex.IP, 4);
            port = BitConverter.ToUInt16(data, (int)SocksHeaderDataIndex.Port);
            ip = BitConverter.ToUInt32(data, (int)SocksHeaderDataIndex.IP);

            //Handle request to open stream connection
            if (data[(int)SocksHeaderDataIndex.Command] == 0x01)
            {
                IPAddress ipAddr = new IPAddress(ip);

                client = new TcpClient(ipAddr.ToString(), port);
                _clients.Add(connIndex, client);
                respData[(int)SocksHeaderDataIndex.Status] = (byte)SocksStatus.ReqGranted;
            }
            else
            {
                _messageWriter.WriteLine("Req denied, port binding not handled");
                respData[(int)SocksHeaderDataIndex.Status] = (byte)SocksStatus.ReqRejected;
            }

            return (respData);
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
