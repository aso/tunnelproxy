using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TunnelProxy.Server.GUI
{
	public partial class Configuration : Form
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
			}
			else
			{
				lblIP.Visible = false;
				txtIPAddr.Visible = false;
				lblPort.Visible = false;
				txtPort.Visible = false;
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
	}
}
