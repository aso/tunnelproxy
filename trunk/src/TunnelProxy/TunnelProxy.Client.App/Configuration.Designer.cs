﻿namespace TunnelProxy.Client.App
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCommunicationType = new System.Windows.Forms.ComboBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIPAddr = new System.Windows.Forms.MaskedTextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.rbIPAddr = new System.Windows.Forms.RadioButton();
            this.rbUrl = new System.Windows.Forms.RadioButton();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtTwitterClientUserName = new System.Windows.Forms.TextBox();
            this.lblTwitterClientUserName = new System.Windows.Forms.Label();
            this.txtTwitterClientPassword = new System.Windows.Forms.TextBox();
            this.txtTwitterServerUserName = new System.Windows.Forms.TextBox();
            this.lblTwitterClientPassword = new System.Windows.Forms.Label();
            this.lblTwitterServerUserName = new System.Windows.Forms.Label();
            this.pnlTwitter = new System.Windows.Forms.Panel();
            this.pnlHtml = new System.Windows.Forms.Panel();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.txtLocalIPAddr = new System.Windows.Forms.MaskedTextBox();
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
            this.pnlTwitter.SuspendLayout();
            this.pnlHtml.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Communication Type:";
            // 
            // cbCommunicationType
            // 
            this.cbCommunicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommunicationType.FormattingEnabled = true;
            this.cbCommunicationType.Items.AddRange(new object[] {
            "http",
            "twitter",
            "email"});
            this.cbCommunicationType.Location = new System.Drawing.Point(167, 11);
            this.cbCommunicationType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCommunicationType.Name = "cbCommunicationType";
            this.cbCommunicationType.Size = new System.Drawing.Size(132, 24);
            this.cbCommunicationType.TabIndex = 1;
            this.cbCommunicationType.SelectedIndexChanged += new System.EventHandler(this.cbCommunicationType_SelectedIndexChanged);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(5, 44);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(76, 17);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "IP Address";
            this.lblIP.Visible = false;
            // 
            // txtIPAddr
            // 
            this.txtIPAddr.Location = new System.Drawing.Point(155, 41);
            this.txtIPAddr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIPAddr.Mask = "000.000.000.000";
            this.txtIPAddr.Name = "txtIPAddr";
            this.txtIPAddr.Size = new System.Drawing.Size(132, 22);
            this.txtIPAddr.TabIndex = 4;
            this.txtIPAddr.Visible = false;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(5, 74);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 17);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port:";
            this.lblPort.Visible = false;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(155, 70);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(132, 22);
            this.txtPort.TabIndex = 6;
            this.txtPort.Visible = false;
            // 
            // rbIPAddr
            // 
            this.rbIPAddr.AutoSize = true;
            this.rbIPAddr.Location = new System.Drawing.Point(221, 11);
            this.rbIPAddr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbIPAddr.Name = "rbIPAddr";
            this.rbIPAddr.Size = new System.Drawing.Size(94, 21);
            this.rbIPAddr.TabIndex = 7;
            this.rbIPAddr.Text = "IP Address";
            this.rbIPAddr.UseVisualStyleBackColor = true;
            this.rbIPAddr.CheckedChanged += new System.EventHandler(this.rbIPAddr_CheckedChanged);
            // 
            // rbUrl
            // 
            this.rbUrl.AutoSize = true;
            this.rbUrl.Checked = true;
            this.rbUrl.Location = new System.Drawing.Point(155, 11);
            this.rbUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbUrl.Name = "rbUrl";
            this.rbUrl.Size = new System.Drawing.Size(54, 21);
            this.rbUrl.TabIndex = 8;
            this.rbUrl.TabStop = true;
            this.rbUrl.Text = "URL";
            this.rbUrl.UseVisualStyleBackColor = true;
            this.rbUrl.CheckedChanged += new System.EventHandler(this.rbUrl_CheckedChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(155, 41);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(200, 22);
            this.txtUrl.TabIndex = 9;
            this.txtUrl.Text = "http://localhost:8080";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(5, 44);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 17);
            this.lblUrl.TabIndex = 10;
            this.lblUrl.Text = "URL";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(341, 9);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtTwitterClientUserName
            // 
            this.txtTwitterClientUserName.Location = new System.Drawing.Point(155, 11);
            this.txtTwitterClientUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTwitterClientUserName.Name = "txtTwitterClientUserName";
            this.txtTwitterClientUserName.Size = new System.Drawing.Size(200, 22);
            this.txtTwitterClientUserName.TabIndex = 12;
            // 
            // lblTwitterClientUserName
            // 
            this.lblTwitterClientUserName.AutoSize = true;
            this.lblTwitterClientUserName.Location = new System.Drawing.Point(5, 15);
            this.lblTwitterClientUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTwitterClientUserName.Name = "lblTwitterClientUserName";
            this.lblTwitterClientUserName.Size = new System.Drawing.Size(122, 17);
            this.lblTwitterClientUserName.TabIndex = 13;
            this.lblTwitterClientUserName.Text = "Client User Name:";
            // 
            // txtTwitterClientPassword
            // 
            this.txtTwitterClientPassword.Location = new System.Drawing.Point(155, 41);
            this.txtTwitterClientPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTwitterClientPassword.Name = "txtTwitterClientPassword";
            this.txtTwitterClientPassword.Size = new System.Drawing.Size(200, 22);
            this.txtTwitterClientPassword.TabIndex = 14;
            // 
            // txtTwitterServerUserName
            // 
            this.txtTwitterServerUserName.Location = new System.Drawing.Point(155, 70);
            this.txtTwitterServerUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTwitterServerUserName.Name = "txtTwitterServerUserName";
            this.txtTwitterServerUserName.Size = new System.Drawing.Size(200, 22);
            this.txtTwitterServerUserName.TabIndex = 15;
            // 
            // lblTwitterClientPassword
            // 
            this.lblTwitterClientPassword.AutoSize = true;
            this.lblTwitterClientPassword.Location = new System.Drawing.Point(5, 44);
            this.lblTwitterClientPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTwitterClientPassword.Name = "lblTwitterClientPassword";
            this.lblTwitterClientPassword.Size = new System.Drawing.Size(112, 17);
            this.lblTwitterClientPassword.TabIndex = 16;
            this.lblTwitterClientPassword.Text = "Client Password:";
            // 
            // lblTwitterServerUserName
            // 
            this.lblTwitterServerUserName.AutoSize = true;
            this.lblTwitterServerUserName.Location = new System.Drawing.Point(5, 74);
            this.lblTwitterServerUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTwitterServerUserName.Name = "lblTwitterServerUserName";
            this.lblTwitterServerUserName.Size = new System.Drawing.Size(129, 17);
            this.lblTwitterServerUserName.TabIndex = 17;
            this.lblTwitterServerUserName.Text = "Server User Name:";
            // 
            // pnlTwitter
            // 
            this.pnlTwitter.Controls.Add(this.txtTwitterServerUserName);
            this.pnlTwitter.Controls.Add(this.lblTwitterClientPassword);
            this.pnlTwitter.Controls.Add(this.lblTwitterClientUserName);
            this.pnlTwitter.Controls.Add(this.txtTwitterClientPassword);
            this.pnlTwitter.Controls.Add(this.txtTwitterClientUserName);
            this.pnlTwitter.Controls.Add(this.lblTwitterServerUserName);
            this.pnlTwitter.Location = new System.Drawing.Point(5, 74);
            this.pnlTwitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTwitter.Name = "pnlTwitter";
            this.pnlTwitter.Size = new System.Drawing.Size(360, 107);
            this.pnlTwitter.TabIndex = 18;
            // 
            // pnlHtml
            // 
            this.pnlHtml.Controls.Add(this.txtUrl);
            this.pnlHtml.Controls.Add(this.txtIPAddr);
            this.pnlHtml.Controls.Add(this.lblIP);
            this.pnlHtml.Controls.Add(this.rbUrl);
            this.pnlHtml.Controls.Add(this.lblUrl);
            this.pnlHtml.Controls.Add(this.rbIPAddr);
            this.pnlHtml.Controls.Add(this.lblPort);
            this.pnlHtml.Controls.Add(this.txtPort);
            this.pnlHtml.Location = new System.Drawing.Point(5, 74);
            this.pnlHtml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHtml.Name = "pnlHtml";
            this.pnlHtml.Size = new System.Drawing.Size(376, 122);
            this.pnlHtml.TabIndex = 19;
            // 
            // lstMessages
            // 
            this.lstMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 16;
            this.lstMessages.Location = new System.Drawing.Point(0, 363);
            this.lstMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(819, 228);
            this.lstMessages.TabIndex = 20;
            this.lstMessages.SelectedIndexChanged += new System.EventHandler(this.lstMessages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Local IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Port:";
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(545, 117);
            this.txtLocalPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(140, 22);
            this.txtLocalPort.TabIndex = 23;
            this.txtLocalPort.Text = "13000";
            // 
            // txtLocalIPAddr
            // 
            this.txtLocalIPAddr.Location = new System.Drawing.Point(545, 84);
            this.txtLocalIPAddr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocalIPAddr.Mask = "000.000.000.000";
            this.txtLocalIPAddr.Name = "txtLocalIPAddr";
            this.txtLocalIPAddr.Size = new System.Drawing.Size(132, 22);
            this.txtLocalIPAddr.TabIndex = 25;
            this.txtLocalIPAddr.Text = "127000000001";
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
            this.pnlEmail.Location = new System.Drawing.Point(5, 74);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(360, 260);
            this.pnlEmail.TabIndex = 26;
            // 
            // txtPopServer
            // 
            this.txtPopServer.Location = new System.Drawing.Point(155, 70);
            this.txtPopServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPopServer.Name = "txtPopServer";
            this.txtPopServer.Size = new System.Drawing.Size(200, 22);
            this.txtPopServer.TabIndex = 27;
            this.txtPopServer.Text = "pop.gmail.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "POP3 Server:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "POP3 Port:";
            // 
            // txtPopPort
            // 
            this.txtPopPort.Location = new System.Drawing.Point(155, 100);
            this.txtPopPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPopPort.Name = "txtPopPort";
            this.txtPopPort.Size = new System.Drawing.Size(132, 22);
            this.txtPopPort.TabIndex = 26;
            this.txtPopPort.Text = "995";
            // 
            // txtEmailServerEmailAddress
            // 
            this.txtEmailServerEmailAddress.Location = new System.Drawing.Point(155, 218);
            this.txtEmailServerEmailAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailServerEmailAddress.Name = "txtEmailServerEmailAddress";
            this.txtEmailServerEmailAddress.Size = new System.Drawing.Size(200, 22);
            this.txtEmailServerEmailAddress.TabIndex = 22;
            this.txtEmailServerEmailAddress.Text = "tunnelproxyserver@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Server Email Address:";
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Location = new System.Drawing.Point(155, 11);
            this.txtSmtpServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(200, 22);
            this.txtSmtpServer.TabIndex = 21;
            this.txtSmtpServer.Text = "smtp.gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "SMTP Server:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "SMTP Port:";
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.Location = new System.Drawing.Point(155, 41);
            this.txtSmtpPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(132, 22);
            this.txtSmtpPort.TabIndex = 20;
            this.txtSmtpPort.Text = "587";
            // 
            // txtEmailClientEmailAddress
            // 
            this.txtEmailClientEmailAddress.Location = new System.Drawing.Point(155, 188);
            this.txtEmailClientEmailAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailClientEmailAddress.Name = "txtEmailClientEmailAddress";
            this.txtEmailClientEmailAddress.Size = new System.Drawing.Size(200, 22);
            this.txtEmailClientEmailAddress.TabIndex = 15;
            this.txtEmailClientEmailAddress.Text = "tunnelproxyclient@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Client Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Client User Name:";
            // 
            // txtEmailClientPassword
            // 
            this.txtEmailClientPassword.Location = new System.Drawing.Point(155, 159);
            this.txtEmailClientPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailClientPassword.Name = "txtEmailClientPassword";
            this.txtEmailClientPassword.Size = new System.Drawing.Size(200, 22);
            this.txtEmailClientPassword.TabIndex = 14;
            this.txtEmailClientPassword.Text = "siuecs547";
            this.txtEmailClientPassword.UseSystemPasswordChar = true;
            // 
            // txtEmailClientUserName
            // 
            this.txtEmailClientUserName.Location = new System.Drawing.Point(155, 129);
            this.txtEmailClientUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailClientUserName.Name = "txtEmailClientUserName";
            this.txtEmailClientUserName.Size = new System.Drawing.Size(200, 22);
            this.txtEmailClientUserName.TabIndex = 12;
            this.txtEmailClientUserName.Text = "tunnelproxyclient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Client Email Address:";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 591);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.txtLocalIPAddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocalPort);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.pnlHtml);
            this.Controls.Add(this.pnlTwitter);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbCommunicationType);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Configuration";
            this.Text = "Tunneling Proxy Client Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.pnlTwitter.ResumeLayout(false);
            this.pnlTwitter.PerformLayout();
            this.pnlHtml.ResumeLayout(false);
            this.pnlHtml.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbCommunicationType;
		private System.Windows.Forms.Label lblIP;
		private System.Windows.Forms.MaskedTextBox txtIPAddr;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.RadioButton rbIPAddr;
		private System.Windows.Forms.RadioButton rbUrl;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Label lblUrl;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtTwitterClientUserName;
		private System.Windows.Forms.Label lblTwitterClientUserName;
		private System.Windows.Forms.TextBox txtTwitterClientPassword;
		private System.Windows.Forms.TextBox txtTwitterServerUserName;
		private System.Windows.Forms.Label lblTwitterClientPassword;
		private System.Windows.Forms.Label lblTwitterServerUserName;
		private System.Windows.Forms.Panel pnlTwitter;
		private System.Windows.Forms.Panel pnlHtml;
		private System.Windows.Forms.ListBox lstMessages;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLocalPort;
		private System.Windows.Forms.MaskedTextBox txtLocalIPAddr;
		private System.Windows.Forms.Panel pnlEmail;
		private System.Windows.Forms.TextBox txtEmailClientEmailAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEmailClientPassword;
		private System.Windows.Forms.TextBox txtEmailClientUserName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSmtpServer;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtSmtpPort;
		private System.Windows.Forms.TextBox txtEmailServerEmailAddress;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtPopServer;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtPopPort;
	}
}

