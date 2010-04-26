using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;

using TunnelProxy.Interfaces;
using TunnelProxy.Tunnels;
using TunnelProxy.Util;
using System.Threading;

namespace SoftEther.Client.GUI.App
{
	public partial class Configuration : Form, IMessageWriter
	{
		NotifyIcon _trayIcon = new NotifyIcon();
		private TunnelLogic _tunnelLogic;

		public Configuration()
		{
			InitializeComponent();
			_tunnelLogic = new TunnelLogic(this);
			this.Resize += new EventHandler(Configuration_Resize);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
			_trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			_trayIcon.DoubleClick += new EventHandler(_trayIcon_DoubleClick);

			List<string> adapterNames = _tunnelLogic.GetAdapterNames();
			cbNetworkAdapter.Items.AddRange(adapterNames.ToArray());
			if (cbNetworkAdapter.Items.Count > 0)
				cbNetworkAdapter.SelectedIndex = 0;
		}

		void Configuration_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				_trayIcon.Visible = true;
			}
		}

		void _trayIcon_DoubleClick(object sender, EventArgs e)
		{
			_trayIcon.Visible = false;
			this.Show();
			this.BringToFront();
		}

		private void Configuration_Load(object sender, EventArgs e)
		{
			cbCommunicationType.SelectedIndex = 0;
		}

		private void cbCommunicationType_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cbCommunicationType.SelectedItem.ToString())
			{
				case "http":
					pnlTwitter.Visible = false;
					pnlHtml.Visible = true;
					pnlEmail.Visible = false;
					break;
				case "twitter":
					pnlTwitter.Visible = true;
					pnlHtml.Visible = false;
					pnlEmail.Visible = false;
					break;
				case "email":
					pnlTwitter.Visible = false;
					pnlHtml.Visible = false;
					pnlEmail.Visible = true;
					break;
				default:
					break;
			}
		}

		private void rbUrl_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			Thread tunnelThread = new Thread(new ParameterizedThreadStart(StartTunnel));
			tunnelThread.IsBackground = true;
			tunnelThread.Start(cbCommunicationType.Text);

			//tunnelLogic.StartTunnel(tunnel, txtLocalIPAddr.Text, Convert.ToInt32(txtLocalPort.Text));
		}

		private void StartTunnel(object param)
		{
			try
			{
				string tunnelType = param as string;
				
				ITunnel tunnel;
				if (tunnelType == "email")
					tunnel = new EmailTunnel(txtSmtpServer.Text, Convert.ToInt32(txtSmtpPort.Text),
						txtPopServer.Text, Convert.ToInt32(txtPopPort.Text), txtEmailServerEmailAddress.Text,
						txtEmailClientEmailAddress.Text, txtEmailClientUserName.Text,
						txtEmailClientPassword.Text);
				else
					tunnel = new HttpTunnel(new Uri(txtUrl.Text), "POST");


				if (chkEncryptData.Checked)
					tunnel = new TunnelDataEncrypter(tunnel, "testing");

				_tunnelLogic.StartTunnel(tunnel, cbNetworkAdapter.SelectedIndex);
			}
			catch
			{

			}
		}

		#region IMessageWriter Members

		private delegate void WriteLineDelegate(string value);
		private delegate void WriteLineFormatDelegate(string format, object arg0);

		public void WriteLine(string value)
		{
			if (lstMessages.InvokeRequired)
				lstMessages.Invoke(new WriteLineDelegate(WriteLine), value);
			else
			{
				lstMessages.Items.Add(value);
				lstMessages.SetSelected(lstMessages.Items.Count - 1, true);
				lstMessages.SetSelected(lstMessages.Items.Count - 1, false);
			}
		}

		public void WriteLine(string format, object arg0)
		{
			WriteLine(string.Format(format, arg0));
		}

		#endregion

        private void lstMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void Configuration_FormClosing(object sender, FormClosingEventArgs e)
		{
			_tunnelLogic.StopTunnel();
		}

	}
}
