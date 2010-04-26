namespace SoftEther.Client.GUI.App
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cbNetworkAdapter = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.chkEncryptData = new System.Windows.Forms.CheckBox();
			this.pnlTwitter.SuspendLayout();
			this.pnlHtml.SuspendLayout();
			this.pnlEmail.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Communication Type:";
			// 
			// cbCommunicationType
			// 
			this.cbCommunicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCommunicationType.FormattingEnabled = true;
			this.cbCommunicationType.Items.AddRange(new object[] {
            "http",
            "email"});
			this.cbCommunicationType.Location = new System.Drawing.Point(125, 9);
			this.cbCommunicationType.Name = "cbCommunicationType";
			this.cbCommunicationType.Size = new System.Drawing.Size(100, 21);
			this.cbCommunicationType.TabIndex = 1;
			this.cbCommunicationType.SelectedIndexChanged += new System.EventHandler(this.cbCommunicationType_SelectedIndexChanged);
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(116, 9);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(151, 20);
			this.txtUrl.TabIndex = 9;
			this.txtUrl.Text = "http://localhost:8080";
			// 
			// lblUrl
			// 
			this.lblUrl.AutoSize = true;
			this.lblUrl.Location = new System.Drawing.Point(4, 12);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(29, 13);
			this.lblUrl.TabIndex = 10;
			this.lblUrl.Text = "URL";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(256, 7);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 11;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtTwitterClientUserName
			// 
			this.txtTwitterClientUserName.Location = new System.Drawing.Point(116, 9);
			this.txtTwitterClientUserName.Name = "txtTwitterClientUserName";
			this.txtTwitterClientUserName.Size = new System.Drawing.Size(151, 20);
			this.txtTwitterClientUserName.TabIndex = 12;
			// 
			// lblTwitterClientUserName
			// 
			this.lblTwitterClientUserName.AutoSize = true;
			this.lblTwitterClientUserName.Location = new System.Drawing.Point(4, 12);
			this.lblTwitterClientUserName.Name = "lblTwitterClientUserName";
			this.lblTwitterClientUserName.Size = new System.Drawing.Size(92, 13);
			this.lblTwitterClientUserName.TabIndex = 13;
			this.lblTwitterClientUserName.Text = "Client User Name:";
			// 
			// txtTwitterClientPassword
			// 
			this.txtTwitterClientPassword.Location = new System.Drawing.Point(116, 33);
			this.txtTwitterClientPassword.Name = "txtTwitterClientPassword";
			this.txtTwitterClientPassword.Size = new System.Drawing.Size(151, 20);
			this.txtTwitterClientPassword.TabIndex = 14;
			// 
			// txtTwitterServerUserName
			// 
			this.txtTwitterServerUserName.Location = new System.Drawing.Point(116, 57);
			this.txtTwitterServerUserName.Name = "txtTwitterServerUserName";
			this.txtTwitterServerUserName.Size = new System.Drawing.Size(151, 20);
			this.txtTwitterServerUserName.TabIndex = 15;
			// 
			// lblTwitterClientPassword
			// 
			this.lblTwitterClientPassword.AutoSize = true;
			this.lblTwitterClientPassword.Location = new System.Drawing.Point(4, 36);
			this.lblTwitterClientPassword.Name = "lblTwitterClientPassword";
			this.lblTwitterClientPassword.Size = new System.Drawing.Size(85, 13);
			this.lblTwitterClientPassword.TabIndex = 16;
			this.lblTwitterClientPassword.Text = "Client Password:";
			// 
			// lblTwitterServerUserName
			// 
			this.lblTwitterServerUserName.AutoSize = true;
			this.lblTwitterServerUserName.Location = new System.Drawing.Point(4, 60);
			this.lblTwitterServerUserName.Name = "lblTwitterServerUserName";
			this.lblTwitterServerUserName.Size = new System.Drawing.Size(97, 13);
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
			this.pnlTwitter.Location = new System.Drawing.Point(4, 66);
			this.pnlTwitter.Name = "pnlTwitter";
			this.pnlTwitter.Size = new System.Drawing.Size(270, 87);
			this.pnlTwitter.TabIndex = 18;
			// 
			// pnlHtml
			// 
			this.pnlHtml.Controls.Add(this.txtUrl);
			this.pnlHtml.Controls.Add(this.lblUrl);
			this.pnlHtml.Location = new System.Drawing.Point(4, 66);
			this.pnlHtml.Name = "pnlHtml";
			this.pnlHtml.Size = new System.Drawing.Size(282, 43);
			this.pnlHtml.TabIndex = 19;
			// 
			// lstMessages
			// 
			this.lstMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lstMessages.FormattingEnabled = true;
			this.lstMessages.HorizontalScrollbar = true;
			this.lstMessages.Location = new System.Drawing.Point(0, 294);
			this.lstMessages.Name = "lstMessages";
			this.lstMessages.Size = new System.Drawing.Size(974, 186);
			this.lstMessages.TabIndex = 20;
			this.lstMessages.SelectedIndexChanged += new System.EventHandler(this.lstMessages_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(314, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 21;
			this.label2.Text = "Local IP Address:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(314, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "Port:";
			// 
			// txtLocalPort
			// 
			this.txtLocalPort.Location = new System.Drawing.Point(426, 77);
			this.txtLocalPort.Name = "txtLocalPort";
			this.txtLocalPort.Size = new System.Drawing.Size(106, 20);
			this.txtLocalPort.TabIndex = 23;
			this.txtLocalPort.Text = "13000";
			// 
			// txtLocalIPAddr
			// 
			this.txtLocalIPAddr.Location = new System.Drawing.Point(426, 50);
			this.txtLocalIPAddr.Mask = "000.000.000.000";
			this.txtLocalIPAddr.Name = "txtLocalIPAddr";
			this.txtLocalIPAddr.Size = new System.Drawing.Size(100, 20);
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
			this.pnlEmail.Location = new System.Drawing.Point(4, 66);
			this.pnlEmail.Name = "pnlEmail";
			this.pnlEmail.Size = new System.Drawing.Size(270, 211);
			this.pnlEmail.TabIndex = 26;
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
			this.txtEmailServerEmailAddress.Text = "tunnelproxyserver@gmail.com";
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
			this.txtEmailClientEmailAddress.Text = "tunnelproxyclient@gmail.com";
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
			this.txtEmailClientUserName.Text = "tunnelproxyclient";
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
			// panel1
			// 
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.cbNetworkAdapter);
			this.panel1.Location = new System.Drawing.Point(310, 126);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(652, 100);
			this.panel1.TabIndex = 27;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(4, 36);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(32, 13);
			this.label14.TabIndex = 27;
			this.label14.Text = "Filter:";
			this.label14.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(116, 33);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(520, 20);
			this.textBox1.TabIndex = 28;
			this.textBox1.Text = "13000";
			this.textBox1.Visible = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(4, 12);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(90, 13);
			this.label12.TabIndex = 22;
			this.label12.Text = "Network Adapter:";
			// 
			// cbNetworkAdapter
			// 
			this.cbNetworkAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNetworkAdapter.FormattingEnabled = true;
			this.cbNetworkAdapter.Location = new System.Drawing.Point(116, 9);
			this.cbNetworkAdapter.Name = "cbNetworkAdapter";
			this.cbNetworkAdapter.Size = new System.Drawing.Size(520, 21);
			this.cbNetworkAdapter.TabIndex = 0;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(8, 54);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 13);
			this.label15.TabIndex = 28;
			this.label15.Text = "Encrypt Data:";
			// 
			// chkEncryptData
			// 
			this.chkEncryptData.AutoSize = true;
			this.chkEncryptData.Location = new System.Drawing.Point(120, 49);
			this.chkEncryptData.Name = "chkEncryptData";
			this.chkEncryptData.Size = new System.Drawing.Size(15, 14);
			this.chkEncryptData.TabIndex = 29;
			this.chkEncryptData.UseVisualStyleBackColor = true;
			// 
			// Configuration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 480);
			this.Controls.Add(this.chkEncryptData);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.panel1);
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
			this.Name = "Configuration";
			this.Text = "SoftEther Client Configuration";
			this.Load += new System.EventHandler(this.Configuration_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configuration_FormClosing);
			this.pnlTwitter.ResumeLayout(false);
			this.pnlTwitter.PerformLayout();
			this.pnlHtml.ResumeLayout(false);
			this.pnlHtml.PerformLayout();
			this.pnlEmail.ResumeLayout(false);
			this.pnlEmail.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbCommunicationType;
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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cbNetworkAdapter;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.CheckBox chkEncryptData;
	}
}

