using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TunnelProxy.Interfaces;
using TunnelProxy.Util;

using Dimebrain.TweetSharp;
using Dimebrain.TweetSharp.Service;
using Dimebrain.TweetSharp.Model;

namespace TunnelProxy.Tunnels
{
	public class TwitterTunnel : ITunnel
	{
		private const int MAX_MESSAGE_SIZE = 140;

		private string _clientUserName;
		private string _clientPassword;
		private string _serverUserName;
		private TwitterService _service = new TwitterService();
		private System.Timers.Timer _pollTimer = new System.Timers.Timer(5000);
		private long _lastMessageReceivedId;

		public TwitterTunnel(string clientUserName, string clientPassword, string serverUserName)
		{
			_clientUserName = clientUserName;
			_clientPassword = clientPassword;
			_serverUserName = serverUserName;
			_service.AuthenticateAs(_clientUserName, _clientPassword);

			IEnumerable<TwitterDirectMessage> directMessages = _service.ListDirectMessagesReceived();
			if (directMessages.Count() > 0)
				_lastMessageReceivedId = _service.ListDirectMessagesReceived().Last().Id;
			else
				_lastMessageReceivedId = -1;

			_pollTimer.Elapsed += _pollTimer_Elapsed;
			_pollTimer.Start();
		}



		#region ITunnel Members

		public void Send(byte[] data)
		{
			byte[] messageBuffer = new byte[MAX_MESSAGE_SIZE];
			int currentIndex = 0;
			while (currentIndex < data.Length)
			{

				messageBuffer = data.Skip(currentIndex).Take(MAX_MESSAGE_SIZE).ToArray();
				string messageString = ConversionUtils.ConvertToString(messageBuffer);
				_service.SendDirectMessage(_serverUserName, messageString);
				currentIndex += MAX_MESSAGE_SIZE;
			}
		}

		public event EventHandler<DataReceivedEventArgs> DataReceived;

		#endregion

		private void _pollTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			List<byte> data = new List<byte>() ;
			IEnumerable<TwitterDirectMessage> directMessages;
			System.Console.Write(_service.GetRateLimitStatus().RemainingHits);
			if(_lastMessageReceivedId!=-1)
				directMessages = _service.ListDirectMessagesReceivedSince(_lastMessageReceivedId);
			else
				directMessages = _service.ListDirectMessagesReceived();
			foreach (TwitterDirectMessage directMessage in directMessages)
			{
				data.AddRange(ConversionUtils.ConvertToBytes(directMessage.Text));
			}

			if(data.Count >0)
			{
				if (DataReceived != null)
					DataReceived(this, new DataReceivedEventArgs(data.ToArray()));
			}
		}
	}
}
