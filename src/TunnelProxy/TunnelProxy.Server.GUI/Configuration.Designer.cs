﻿namespace TunnelProxy.Server.GUI
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
			this.btnSave = new System.Windows.Forms.Button();
			this.cbCommunicationType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlHtml.SuspendLayout();
			this.pnlTwitter.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHtml
			// 
			this.pnlHtml.Controls.Add(this.txtIPAddr);
			this.pnlHtml.Controls.Add(this.lblIP);
			this.pnlHtml.Controls.Add(this.rbUrl);
			this.pnlHtml.Controls.Add(this.rbIPAddr);
			this.pnlHtml.Controls.Add(this.lblPort);
			this.pnlHtml.Controls.Add(this.txtPort);
			this.pnlHtml.Location = new System.Drawing.Point(10, 44);
			this.pnlHtml.Name = "pnlHtml";
			this.pnlHtml.Size = new System.Drawing.Size(282, 99);
			this.pnlHtml.TabIndex = 24;
			// 
			// txtIPAddr
			// 
			this.txtIPAddr.Location = new System.Drawing.Point(113, 32);
			this.txtIPAddr.Mask = "000.000.000.000";
			this.txtIPAddr.Name = "txtIPAddr";
			this.txtIPAddr.Size = new System.Drawing.Size(100, 20);
			this.txtIPAddr.TabIndex = 4;
			this.txtIPAddr.Visible = false;
			// 
			// lblIP
			// 
			this.lblIP.AutoSize = true;
			this.lblIP.Location = new System.Drawing.Point(3, 32);
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
			this.rbUrl.Location = new System.Drawing.Point(113, 9);
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
			this.lblPort.Location = new System.Drawing.Point(1, 61);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(29, 13);
			this.lblPort.TabIndex = 5;
			this.lblPort.Text = "Port:";
			this.lblPort.Visible = false;
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(113, 58);
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
			this.pnlTwitter.Location = new System.Drawing.Point(11, 44);
			this.pnlTwitter.Name = "pnlTwitter";
			this.pnlTwitter.Size = new System.Drawing.Size(270, 87);
			this.pnlTwitter.TabIndex = 23;
			// 
			// txtTwitterClientUserName
			// 
			this.txtTwitterClientUserName.Location = new System.Drawing.Point(116, 55);
			this.txtTwitterClientUserName.Name = "txtTwitterClientUserName";
			this.txtTwitterClientUserName.Size = new System.Drawing.Size(151, 20);
			this.txtTwitterClientUserName.TabIndex = 15;
			// 
			// lblTwitterServerPassword
			// 
			this.lblTwitterServerPassword.AutoSize = true;
			this.lblTwitterServerPassword.Location = new System.Drawing.Point(3, 32);
			this.lblTwitterServerPassword.Name = "lblTwitterServerPassword";
			this.lblTwitterServerPassword.Size = new System.Drawing.Size(90, 13);
			this.lblTwitterServerPassword.TabIndex = 16;
			this.lblTwitterServerPassword.Text = "Server Password:";
			// 
			// lblTwitterServerUserName
			// 
			this.lblTwitterServerUserName.AutoSize = true;
			this.lblTwitterServerUserName.Location = new System.Drawing.Point(3, 6);
			this.lblTwitterServerUserName.Name = "lblTwitterServerUserName";
			this.lblTwitterServerUserName.Size = new System.Drawing.Size(97, 13);
			this.lblTwitterServerUserName.TabIndex = 13;
			this.lblTwitterServerUserName.Text = "Server User Name:";
			// 
			// txtTwitterServerPassword
			// 
			this.txtTwitterServerPassword.Location = new System.Drawing.Point(116, 29);
			this.txtTwitterServerPassword.Name = "txtTwitterServerPassword";
			this.txtTwitterServerPassword.Size = new System.Drawing.Size(151, 20);
			this.txtTwitterServerPassword.TabIndex = 14;
			// 
			// txtServerUserName
			// 
			this.txtServerUserName.Location = new System.Drawing.Point(116, 3);
			this.txtServerUserName.Name = "txtServerUserName";
			this.txtServerUserName.Size = new System.Drawing.Size(151, 20);
			this.txtServerUserName.TabIndex = 12;
			// 
			// lblTwitterClientUserName
			// 
			this.lblTwitterClientUserName.AutoSize = true;
			this.lblTwitterClientUserName.Location = new System.Drawing.Point(3, 58);
			this.lblTwitterClientUserName.Name = "lblTwitterClientUserName";
			this.lblTwitterClientUserName.Size = new System.Drawing.Size(92, 13);
			this.lblTwitterClientUserName.TabIndex = 17;
			this.lblTwitterClientUserName.Text = "Client User Name:";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(15, 169);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// cbCommunicationType
			// 
			this.cbCommunicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCommunicationType.FormattingEnabled = true;
			this.cbCommunicationType.Items.AddRange(new object[] {
            "http",
            "https",
            "twitter",
            "email"});
			this.cbCommunicationType.Location = new System.Drawing.Point(124, 6);
			this.cbCommunicationType.Name = "cbCommunicationType";
			this.cbCommunicationType.Size = new System.Drawing.Size(100, 21);
			this.cbCommunicationType.TabIndex = 21;
			this.cbCommunicationType.SelectedIndexChanged += new System.EventHandler(this.cbCommunicationType_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Communication Type:";
			// 
			// Configuration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 262);
			this.Controls.Add(this.pnlHtml);
			this.Controls.Add(this.pnlTwitter);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cbCommunicationType);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Configuration";
			this.Text = "Tunneling Proxy Server Configuration";
			this.pnlHtml.ResumeLayout(false);
			this.pnlHtml.PerformLayout();
			this.pnlTwitter.ResumeLayout(false);
			this.pnlTwitter.PerformLayout();
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
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cbCommunicationType;
		private System.Windows.Forms.Label label1;
	}
}

