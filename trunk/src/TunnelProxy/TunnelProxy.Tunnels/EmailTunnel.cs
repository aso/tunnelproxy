using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TunnelProxy.Interfaces;
using System.Threading;
using TunnelProxy.Util;
using System.Net;
using System.IO;

namespace TunnelProxy.Tunnels
{
	public class EmailTunnel : ITunnel
	{
		private bool _waiting = false;
		//private InterIMAP.IMAPClient _imapClient;
		//private Koolwired.Imap.ImapCommand _command;

		Higuchi.Net.Pop3.Pop3Client _client;
		System.Timers.Timer _updateTimer;
		long _previousMailCount;

		public string SmtpServer { get; set; }
		public int SmtpPort { get; set; }
		public string PopServer { get; set; }
		public int PopPort { get; set; }
		public string ServerEmailAddress { get; set; }
		public string ClientEmailAddress { get; set; }
		public string ClientUserName { get; set; }
		public string ClientPassword { get; set; }

		public EmailTunnel(string smtpServer, int smtpPort, string imapServer,
			int imapPort, string serverEmailAddress, string clientEmailAdress,
			string clientUserName, string clientPassword)
		{
			SmtpServer = smtpServer;
			SmtpPort = smtpPort;
			PopServer = imapServer;
			PopPort = imapPort;
			ServerEmailAddress = serverEmailAddress;
			ClientEmailAddress = clientEmailAdress;
			ClientUserName = clientUserName;
			ClientPassword = clientPassword;

			//Koolwired.Imap.ImapConnect connection = new Koolwired.Imap.ImapConnect(ImapServer, ImapPort, true);
			//connection.LoginType = Koolwired.Imap.LoginType.LOGIN;
			//Koolwired.Imap.ImapCommand _command = new Koolwired.Imap.ImapCommand(connection);
			//Koolwired.Imap.ImapAuthenticate authenticate = new Koolwired.Imap.ImapAuthenticate(connection, ClientUserName, ClientPassword);
			//connection.Open();
			//authenticate.Login();

			//InterIMAP.IMAPConfig config = new InterIMAP.IMAPConfig(imapServer, ClientUserName, ClientPassword,
			//    true, true, "INBOX");
			//_imapClient = new InterIMAP.IMAPClient();
			//_imapClient.Config = config;
			//_imapClient.Logon();

			//Pop3.Pop3Client popclient = new Pop3.Pop3Client();
			//popclient.Connect(, ClientUserName, ClientPassword);
			_client = new Higuchi.Net.Pop3.Pop3Client();
			_client.UserName = ClientUserName;
			_client.Password = ClientPassword;
			_client.ServerName = PopServer;
			_client.Port = PopPort;
			_client.Ssl = true;
			_client.ReceiveTimeout = 30000;
			_client.Authenticate();
			_previousMailCount = _client.GetTotalMessageCount();
			_updateTimer = new System.Timers.Timer(100);
			_updateTimer.Elapsed += updateTimer_Elapsed;
			_updateTimer.Start();
		}

		void updateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			_updateTimer.Stop();

			_client = new Higuchi.Net.Pop3.Pop3Client();
			_client.UserName = ClientUserName;
			_client.Password = ClientPassword;
			_client.ServerName = PopServer;
			_client.Port = PopPort;
			_client.Ssl = true;
			_client.ReceiveTimeout = 30000;
			_client.Authenticate();
			long mailCount = _client.GetTotalMessageCount();
			if (mailCount > _previousMailCount)
			{
				for (long i = _previousMailCount + 1; i <= mailCount; i++)
				{
					Higuchi.Net.Pop3.Pop3Message message = _client.GetMessage(i);
					if (message.To == ClientEmailAddress && message.From == ServerEmailAddress && message.Subject == "TunnelProxy")
					{
						string body = message.BodyText;
						byte[] data = ConversionUtils.ConvertToBytes(body);
						if (DataReceived != null)
							DataReceived(this, new DataReceivedEventArgs(data));
						//_client.DeleteEMail(i);
						//_client.ExecuteDele(listResult.MailIndex);
						//_client.ExecuteQuit();
						//_client.Authenticate();
					}
				}
				_previousMailCount = mailCount;
			}

			_updateTimer.Start();

			//InterIMAP.IMAPMessageCollection messages = _imapClient.Folders[0].Messages;
			//foreach (InterIMAP.IMAPMessage message in messages)
			//{
			//    InterIMAP.IMAPMessage filledMessage =  _imapClient.Folders[0].GetMessageByID(message.Uid);
			//    //message.
			//    if (DataReceived != null)
			//    {
			//        if (filledMessage.TextData != null)
			//        {
			//            byte[] data = ConversionUtils.ConvertToBytes(filledMessage.TextData.TextData);
			//            DataReceived(this, new DataReceivedEventArgs(data));
			//        }
			//    }
			//}

			
			//Koolwired.Imap.ImapMailbox mailbox = _command.Select("INBOX");
			//mailbox = _command.Fetch(mailbox);
			////authenticate.Logout();
			////connection.Close();
			//foreach (Koolwired.Imap.ImapMailboxMessage message in mailbox.Messages)
			//{
			//    if(DataReceived!=null)
			//    {
			//        Koolwired.Imap.ImapMailboxMessage fetchedMessage = _command.FetchBodyStructure(message);
			//        byte[] data = ConversionUtils.ConvertToBytes(fetchedMessage.BodyParts[0].BodyPart);

			//    }
			//}
		}

		#region ITunnel Members

		public void Send(byte[] data)
		{
			WebResponse response = null;
			Stream dataStream = null;

			while (_waiting) Thread.Sleep(1);

			_waiting = true;

			try
			{
				System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(SmtpServer, SmtpPort);
				smtpClient.Credentials = new System.Net.NetworkCredential(ClientUserName, ClientPassword);
				System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(ClientEmailAddress, ServerEmailAddress);
				message.IsBodyHtml = false;
				message.Body = ConversionUtils.ConvertToString(data);
				message.Subject = "TunnelProxy";
				smtpClient.EnableSsl = true;
				smtpClient.Send(message);
			}
			finally
			{
				if (dataStream != null)
					dataStream.Close();
				if (response != null)
					response.Close();
			}

			_waiting = false;

		}

		//private void EmailReceived()
		//{
		//    string body = string.Empty;
		//    byte[] data = ConversionUtils.ConvertToBytes(body);
		//    if (DataReceived != null)
		//    {
		//        DataReceived(this, new DataReceivedEventArgs(data));
		//    }
		//}

		public event EventHandler<DataReceivedEventArgs> DataReceived;

		#endregion
	}
}
