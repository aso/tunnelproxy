namespace TunnelProxy.Server.App
{
	partial class Configuration
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
			this.pnlHtml = new System.Windows.Forms.Panel();
			this.lblUrl = new System.Windows.Forms.Label();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.txtIPAddr = new System.Windows.Forms.MaskedTextBox();
			this.lblIP = new System.Windows.Forms.Label();
			this.rbUrl = new System.Windows.Forms.RadioButton();
			this.rbIPAddr = new System.Windows.Forms.RadioButton();
			this.lblPort = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.pnlTwitter = new System.Windows.Forms.Panel();
			this.txtTwitterClientUserName = new System.Windows.Forms.TextBox();
			this.lblTwitterServerPassword = new System.Windows.Forms.Label();
			this.lblTwitterServerUserName = new System.Windows.Forms.Label();
			this.txtTwitterServerPassword = new System.Windows.Forms.TextBox();
			this.txtServerUserName = new System.Windows.Forms.TextBox();
			this.lblTwitterClientUserName = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.cbCommunicationType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lstMessages = new System.Windows.Forms.ListBox();
			this.pnlEmail = new System.Windows.Forms.Panel();
			this.txtPopServer = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtPopPort = new System.Windows.Forms.TextBox();
			this.txtEmailServerEmailAddress = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSmtpServer = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtSmtpPort = new System.Windows.Forms.TextBox();
			this.txtEmailClientEmailAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmailClientPassword = new System.Windows.Forms.TextBox();
			this.txtEmailClientUserName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pnlHtml.SuspendLayout();
			this.pnlTwitter.SuspendLayout();
			this.pnlEmail.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHtml
			// 
			this.pnlHtml.Controls.Add(this.lblUrl);
			this.pnlHtml.Controls.Add(this.txtUrl);
			this.pnlHtml.Controls.Add(this.txtIPAddr);
			this.pnlHtml.Controls.Add(this.lblIP);
			this.pnlHtml.Controls.Add(this.rbUrl);
			this.pnlHtml.Controls.Add(this.rbIPAddr);
			this.pnlHtml.Controls.Add(this.lblPort);
			this.pnlHtml.Controls.Add(this.txtPort);
			this.pnlHtml.Location = new System.Drawing.Point(4, 60);
			this.pnlHtml.Name = "pnlHtml";
			this.pnlHtml.Size = new System.Drawing.Size(282, 99);
			this.pnlHtml.TabIndex = 24;
			// 
			// lblUrl
			// 
			this.lblUrl.AutoSize = true;
			this.lblUrl.Location = new System.Drawing.Point(4, 36);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(29, 13);
			this.lblUrl.TabIndex = 9;
			this.lblUrl.Text = "URL";
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(116, 33);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(100, 20);
			this.txtUrl.TabIndex = 9;
			this.txtUrl.Text = "http://+:8080/";
			// 
			// txtIPAddr
			// 
			this.txtIPAddr.Location = new System.Drawing.Point(116, 33);
			this.txtIPAddr.Mask = "000.000.000.000";
			this.txtIPAddr.Name = "txtIPAddr";
			this.txtIPAddr.Size = new System.Drawing.Size(100, 20);
			this.txtIPAddr.TabIndex = 4;
			this.txtIPAddr.Visible = false;
			// 
			// lblIP
			// 
			this.lblIP.AutoSize = true;
			this.lblIP.Location = new System.Drawing.Point(4, 36);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new System.Drawing.Size(58, 13);
			this.lblIP.TabIndex = 2;
			this.lblIP.Text = "IP Address";
			this.lblIP.Visible = false;
			// 
			// rbUrl
			// 
			this.rbUrl.AutoSize = true;
			this.rbUrl.Checked = true;
			this.rbUrl.Location = new System.Drawing.Point(116, 9);
			this.rbUrl.Name = "rbUrl";
			this.rbUrl.Size = new System.Drawing.Size(47, 17);
			this.rbUrl.TabIndex = 8;
			this.rbUrl.TabStop = true;
			this.rbUrl.Text = "URL";
			this.rbUrl.UseVisualStyleBackColor = true;
			// 
			// rbIPAddr
			// 
			this.rbIPAddr.AutoSize = true;
			this.rbIPAddr.Location = new System.Drawing.Point(166, 9);
			this.rbIPAddr.Name = "rbIPAddr";
			this.rbIPAddr.Size = new System.Drawing.Size(76, 17);
			this.rbIPAddr.TabIndex = 7;
			this.rbIPAddr.Text = "IP Address";
			this.rbIPAddr.UseVisualStyleBackColor = true;
			this.rbIPAddr.CheckedChanged += new System.EventHandler(this.rbIPAddr_CheckedChanged);
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(4, 60);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(29, 13);
			this.lblPort.TabIndex = 5;
			this.lblPort.Text = "Port:";
			this.lblPort.Visible = false;
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(116, 57);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(100, 20);
			this.txtPort.TabIndex = 6;
			this.txtPort.Visible = false;
			// 
			// pnlTwitter
			// 
			this.pnlTwitter.Controls.Add(this.txtTwitterClientUserName);
			this.pnlTwitter.Controls.Add(this.lblTwitterServerPassword);
			this.pnlTwitter.Controls.Add(this.lblTwitterServerUserName);
			this.pnlTwitter.Controls.Add(this.txtTwitterServerPassword);
			this.pnlTwitter.Controls.Add(this.txtServerUserName);
			this.pnlTwitter.Controls.Add(this.lblTwitterClientUserName);
			this.pnlTwitter.Location = new System.Drawing.Point(4, 60);
			this.pnlTwitter.Name = "pnlTwitter";
			this.pnlTwitter.Size = new System.Drawing.Size(270, 87);
			this.pnlTwitter.TabIndex = 23;
			// 
			// txtTwitterClientUserName
			// 
			this.txtTwitterClientUserName.Location = new System.Drawing.Point(116, 57);
			this.txtTwitterClientUserName.Name = "txtTwitterClientUserName";
			this.txtTwitterClientUserName.Size = new System.Drawing.Size(151, 20);
			this.txtTwitterClientUserName.TabIndex = 15;
			// 
			// lblTwitterServerPassword
			// 
			this.lblTwitterServerPassword.AutoSize = true;
			this.lblTwitterServerPassword.Location = new System.Drawing.Point(4, 36);
			this.lblTwitterServerPassword.Name = "lblTwitterServerPassword";
			this.lblTwitterServerPassword.Size = new System.Drawing.Size(90, 13);
			this.lblTwitterServerPassword.TabIndex = 16;
			this.lblTwitterServerPassword.Text = "Server Password:";
			// 
			// lblTwitterServerUserName
			// 
			this.lblTwitterServerUserName.AutoSize = true;
			this.lblTwitterServerUserName.Location = new System.Drawing.Point(4, 12);
			this.lblTwitterServerUserName.Name = "lblTwitterServerUserName";
			this.lblTwitterServerUserName.Size = new System.Drawing.Size(97, 13);
			this.lblTwitterServerUserName.TabIndex = 13;
			this.lblTwitterServerUserName.Text = "Server User Name:";
			// 
			// txtTwitterServerPassword
			// 
			this.txtTwitterServerPassword.Location = new System.Drawing.Point(116, 33);
			this.txtTwitterServerPassword.Name = "txtTwitterServerPassword";
			this.txtTwitterServerPassword.Size = new System.Drawing.Size(151, 20);
			this.txtTwitterServerPassword.TabIndex = 14;
			// 
			// txtServerUserName
			// 
			this.txtServerUserName.Location = new System.Drawing.Point(116, 9);
			this.txtServerUserName.Name = "txtServerUserName";
			this.txtServerUserName.Size = new System.Drawing.Size(151, 20);
			this.txtServerUserName.TabIndex = 12;
			// 
			// lblTwitterClientUserName
			// 
			this.lblTwitterClientUserName.AutoSize = true;
			this.lblTwitterClientUserName.Location = new System.Drawing.Point(4, 60);
			this.lblTwitterClientUserName.Name = "lblTwitterClientUserName";
			this.lblTwitterClientUserName.Size = new System.Drawing.Size(92, 13);
			this.lblTwitterClientUserName.TabIndex = 17;
			this.lblTwitterClientUserName.Text = "Client User Name:";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(256, 7);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 22;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// cbCommunicationType
			// 
			this.cbCommunicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCommunicationType.FormattingEnabled = true;
			this.cbCommunicationType.Items.AddRange(new object[] {
            "http",
            "twitter",
            "email"});
			this.cbCommunicationType.Location = new System.Drawing.Point(124, 9);
			this.cbCommunicationType.Name = "cbCommunicationType";
			this.cbCommunicationType.Size = new System.Drawing.Size(100, 21);
			this.cbCommunicationType.TabIndex = 21;
			this.cbCommunicationType.SelectedIndexChanged += new System.EventHandler(this.cbCommunicationType_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Communication Type:";
			// 
			// lstMessages
			// 
			this.lstMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lstMessages.FormattingEnabled = true;
			this.lstMessages.Location = new System.Drawing.Point(0, 282);
			this.lstMessages.Name = "lstMessages";
			this.lstMessages.Size = new System.Drawing.Size(438, 199);
			this.lstMessages.TabIndex = 25;
			// 
			// pnlEmail
			// 
			this.pnlEmail.Controls.Add(this.txtPopServer);
			this.pnlEmail.Controls.Add(this.label10);
			this.pnlEmail.Controls.Add(this.label11);
			this.pnlEmail.Controls.Add(this.txtPopPort);
			this.pnlEmail.Controls.Add(this.txtEmailServerEmailAddress);
			this.pnlEmail.Controls.Add(this.label9);
			this.pnlEmail.Controls.Add(this.txtSmtpServer);
			this.pnlEmail.Controls.Add(this.label7);
			this.pnlEmail.Controls.Add(this.label8);
			this.pnlEmail.Controls.Add(this.txtSmtpPort);
			this.pnlEmail.Controls.Add(this.txtEmailClientEmailAddress);
			this.pnlEmail.Controls.Add(this.label4);
			this.pnlEmail.Controls.Add(this.label5);
			this.pnlEmail.Controls.Add(this.txtEmailClientPassword);
			this.pnlEmail.Controls.Add(this.txtEmailClientUserName);
			this.pnlEmail.Controls.Add(this.label6);
			this.pnlEmail.Location = new System.Drawing.Point(4, 60);
			this.pnlEmail.Name = "pnlEmail";
			this.pnlEmail.Size = new System.Drawing.Size(270, 211);
			this.pnlEmail.TabIndex = 27;
			// 
			// txtPopServer
			// 
			this.txtPopServer.Location = new System.Drawing.Point(116, 57);
			this.txtPopServer.Name = "txtPopServer";
			this.txtPopServer.Size = new System.Drawing.Size(151, 20);
			this.txtPopServer.TabIndex = 27;
			this.txtPopServer.Text = "pop.gmail.com";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 60);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 13);
			this.label10.TabIndex = 24;
			this.label10.Text = "POP3 Server:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(4, 84);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 13);
			this.label11.TabIndex = 25;
			this.label11.Text = "POP3 Port:";
			// 
			// txtPopPort
			// 
			this.txtPopPort.Location = new System.Drawing.Point(116, 81);
			this.txtPopPort.Name = "txtPopPort";
			this.txtPopPort.Size = new System.Drawing.Size(100, 20);
			this.txtPopPort.TabIndex = 26;
			this.txtPopPort.Text = "995";
			// 
			// txtEmailServerEmailAddress
			// 
			this.txtEmailServerEmailAddress.Location = new System.Drawing.Point(116, 177);
			this.txtEmailServerEmailAddress.Name = "txtEmailServerEmailAddress";
			this.txtEmailServerEmailAddress.Size = new System.Drawing.Size(151, 20);
			this.txtEmailServerEmailAddress.TabIndex = 22;
			this.txtEmailServerEmailAddress.Text = "tunnelproxyclient@gmail.com";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(4, 180);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(110, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Server Email Address:";
			// 
			// txtSmtpServer
			// 
			this.txtSmtpServer.Location = new System.Drawing.Point(116, 9);
			this.txtSmtpServer.Name = "txtSmtpServer";
			this.txtSmtpServer.Size = new System.Drawing.Size(151, 20);
			this.txtSmtpServer.TabIndex = 21;
			this.txtSmtpServer.Text = "smtp.gmail.com";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "SMTP Server:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(4, 36);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "SMTP Port:";
			// 
			// txtSmtpPort
			// 
			this.txtSmtpPort.Location = new System.Drawing.Point(116, 33);
			this.txtSmtpPort.Name = "txtSmtpPort";
			this.txtSmtpPort.Size = new System.Drawing.Size(100, 20);
			this.txtSmtpPort.TabIndex = 20;
			this.txtSmtpPort.Text = "587";
			// 
			// txtEmailClientEmailAddress
			// 
			this.txtEmailClientEmailAddress.Location = new System.Drawing.Point(116, 153);
			this.txtEmailClientEmailAddress.Name = "txtEmailClientEmailAddress";
			this.txtEmailClientEmailAddress.Size = new System.Drawing.Size(151, 20);
			this.txtEmailClientEmailAddress.TabIndex = 15;
			this.txtEmailClientEmailAddress.Text = "tunnelproxyserver@gmail.com";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Client Password:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Client User Name:";
			// 
			// txtEmailClientPassword
			// 
			this.txtEmailClientPassword.Location = new System.Drawing.Point(116, 129);
			this.txtEmailClientPassword.Name = "txtEmailClientPassword";
			this.txtEmailClientPassword.Size = new System.Drawing.Size(151, 20);
			this.txtEmailClientPassword.TabIndex = 14;
			this.txtEmailClientPassword.Text = "siuecs547";
			this.txtEmailClientPassword.UseSystemPasswordChar = true;
			// 
			// txtEmailClientUserName
			// 
			this.txtEmailClientUserName.Location = new System.Drawing.Point(116, 105);
			this.txtEmailClientUserName.Name = "txtEmailClientUserName";
			this.txtEmailClientUserName.Size = new System.Drawing.Size(151, 20);
			this.txtEmailClientUserName.TabIndex = 12;
			this.txtEmailClientUserName.Text = "tunnelproxyserver";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(4, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Client Email Address:";
			// 
			// Configuration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 481);
			this.Controls.Add(this.pnlEmail);
			this.Controls.Add(this.lstMessages);
			this.Controls.Add(this.pnlHtml);
			this.Controls.Add(this.pnlTwitter);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.cbCommunicationType);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Configuration";
			this.Text = "Tunneling Proxy Server Configuration";
			this.pnlHtml.ResumeLayout(false);
			this.pnlHtml.PerformLayout();
			this.pnlTwitter.ResumeLayout(false);
			this.pnlTwitter.PerformLayout();
			this.pnlEmail.ResumeLayout(false);
			this.pnlEmail.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlHtml;
		private System.Windows.Forms.MaskedTextBox txtIPAddr;
		private System.Windows.Forms.Label lblIP;
		private System.Windows.Forms.RadioButton rbUrl;
		private System.Windows.Forms.RadioButton rbIPAddr;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Panel pnlTwitter;
		private System.Windows.Forms.TextBox txtTwitterClientUserName;
		private System.Windows.Forms.Label lblTwitterServerPassword;
		private System.Windows.Forms.Label lblTwitterServerUserName;
		private System.Windows.Forms.TextBox txtTwitterServerPassword;
		private System.Windows.Forms.TextBox txtServerUserName;
		private System.Windows.Forms.Label lblTwitterClientUserName;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ComboBox cbCommunicationType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Label lblUrl;
		private System.Windows.Forms.ListBox lstMessages;
		private System.Windows.Forms.Panel pnlEmail;
		private System.Windows.Forms.TextBox txtPopServer;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtPopPort;
		private System.Windows.Forms.TextBox txtEmailServerEmailAddress;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtSmtpServer;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtSmtpPort;
		private System.Windows.Forms.TextBox txtEmailClientEmailAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEmailClientPassword;
		private System.Windows.Forms.TextBox txtEmailClientUserName;
		private System.Windows.Forms.Label label6;
	}
}

