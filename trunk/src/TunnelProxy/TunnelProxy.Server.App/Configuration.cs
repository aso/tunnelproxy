using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TunnelProxy.Interfaces;
using TunnelProxy.Tunnels;
using System.Threading;

namespace TunnelProxy.Server.App
{
	public partial class Configuration : Form, IMessageWriter
	{
		public Configuration()
		{
			InitializeComponent();
			cbCommunicationType.SelectedIndex = 0;
		}

		private void Configuration_Load(object sender, EventArgs e)
		{
			cbCommunicationType.SelectedIndex = 0;
		}

		private void rbIPAddr_CheckedChanged(object sender, EventArgs e)
		{
			if (rbIPAddr.Checked)
			{
				lblIP.Visible = true;
				txtIPAddr.Visible = true;
				lblPort.Visible = true;
				txtPort.Visible = true;
				lblUrl.Visible = false;
				txtUrl.Visible = false;
			}
			else
			{
				lblIP.Visible = false;
				txtIPAddr.Visible = false;
				lblPort.Visible = false;
				txtPort.Visible = false;
				lblUrl.Visible = true;
				txtUrl.Visible = true;
			}
		}

		private void cbCommunicationType_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cbCommunicationType.SelectedItem.ToString())
			{
				case "http":
				case "https":
					pnlTwitter.Visible = false;
					pnlHtml.Visible = true;
					break;
				case "twitter":
					pnlTwitter.Visible = true;
					pnlHtml.Visible = false;
					break;
				case "email":
					break;
				default:
					break;
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			Thread tunnelThread = new Thread(new ThreadStart(StartTunnel));
			tunnelThread.IsBackground = true;
			tunnelThread.Start();

			//tunnelLogic.StartTunnel(tunnel, txtLocalIPAddr.Text, Convert.ToInt32(txtLocalPort.Text));
		}

		private void StartTunnel()
		{
			TunnelLogic tunnelLogic = new TunnelLogic(this);
			HttpServerTunnel tunnel = new HttpServerTunnel(txtUrl.Text);
			tunnelLogic.StartTunnel(tunnel);

            while (true) ;
		}

		#region IMessageWriter Members

		private delegate void WriteLineDelegate(string value);
		private delegate void WriteLineFormatDelegate(string format, object arg0);

		public void WriteLine(string value)
		{
			if (lstMessages.InvokeRequired)
				lstMessages.Invoke(new WriteLineDelegate(WriteLine), value);
			else
				lstMessages.Items.Add(value);
		}

		public void WriteLine(string format, object arg0)
		{
			WriteLine(string.Format(format, arg0));
		}

		#endregion
	}
}
