using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using TunnelProxy.Interfaces;
using System.Threading;
using TunnelProxy.Util;
using System.Net;
using System.IO;
using System.Net.Mime;

namespace TunnelProxy.Tunnels
{
	public class EmailTunnel : ITunnel
	{
		private static object _emailLock = new object();
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

			lock (_emailLock)
			{
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
							List<Higuchi.Net.Pop3.Pop3Content> l = Higuchi.Net.Pop3.Pop3Message.GetAttachedContents(message);
							MemoryStream dataStream = new MemoryStream(10000);

							l[0].DecodeData(dataStream, false);
							dataStream.Flush();

							byte[] data = dataStream.ToArray();

							//byte[] data = ConversionUtils.ConvertToBytes(l[0].BodyText);

							//string body = message.BodyText;
							
							//if (body.EndsWith("\r\n\r\n"))
							//	body = body.Substring(0, body.Length - 4);
							//byte[] data = ConversionUtils.ConvertToBytes(body);
							if (DataReceived != null)
								DataReceived(this, new DataReceivedEventArgs(data));
						}
					}
					_previousMailCount = mailCount;
				}
			}
			_updateTimer.Start();
		}

		#region ITunnel Members

		public void Send(byte[] data)
		{
			WebResponse response = null;
			Stream dataStream = null;

			while (_waiting) Thread.Sleep(1);

			_waiting = true;
			lock (_emailLock)
			{
				try
				{
					SmtpClient smtpClient = new SmtpClient(SmtpServer, SmtpPort);
					smtpClient.Credentials = new System.Net.NetworkCredential(ClientUserName, ClientPassword);
					MailMessage message = new MailMessage(ClientEmailAddress, ServerEmailAddress);
					message.IsBodyHtml = false;
					//message.Body = ConversionUtils.ConvertToString(data);
					Stream attachmentStream = new MemoryStream(data);
					ContentType ct = new ContentType(MediaTypeNames.Text.Plain);
					// Attach the log file stream to the e-mail message.
					Attachment dataAttachment = new Attachment(attachmentStream, ct);
					ContentDisposition disposition = dataAttachment.ContentDisposition;
					disposition.FileName = "data.txt";
					message.Attachments.Add(dataAttachment);

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
			}
			_waiting = false;

		}

		public event EventHandler<DataReceivedEventArgs> DataReceived;

		#endregion
	}
}
