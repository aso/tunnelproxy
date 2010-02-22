namespace TunnelProxy.Client.GUI
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
			this.btnSave = new System.Windows.Forms.Button();
			this.txtClientUserName = new System.Windows.Forms.TextBox();
			this.lblTwitterClientUserName = new System.Windows.Forms.Label();
			this.txtTwitterClientPassword = new System.Windows.Forms.TextBox();
			this.txtTwitterServerUserName = new System.Windows.Forms.TextBox();
			this.lblTwitterClientPassword = new System.Windows.Forms.Label();
			this.lblTwitterServerUserName = new System.Windows.Forms.Label();
			this.pnlTwitter = new System.Windows.Forms.Panel();
			this.pnlHtml = new System.Windows.Forms.Panel();
			this.pnlTwitter.SuspendLayout();
			this.pnlHtml.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 24);
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
            "https",
            "twitter",
            "email"});
			this.cbCommunicationType.Location = new System.Drawing.Point(125, 21);
			this.cbCommunicationType.Name = "cbCommunicationType";
			this.cbCommunicationType.Size = new System.Drawing.Size(121, 21);
			this.cbCommunicationType.TabIndex = 1;
			this.cbCommunicationType.SelectedIndexChanged += new System.EventHandler(this.cbCommunicationType_SelectedIndexChanged);
			// 
			// lblIP
			// 
			this.lblIP.AutoSize = true;
			this.lblIP.Location = new System.Drawing.Point(1, 35);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new System.Drawing.Size(58, 13);
			this.lblIP.TabIndex = 2;
			this.lblIP.Text = "IP Address";
			this.lblIP.Visible = false;
			// 
			// txtIPAddr
			// 
			this.txtIPAddr.Location = new System.Drawing.Point(120, 32);
			this.txtIPAddr.Mask = "000.000.000.000";
			this.txtIPAddr.Name = "txtIPAddr";
			this.txtIPAddr.Size = new System.Drawing.Size(100, 20);
			this.txtIPAddr.TabIndex = 4;
			this.txtIPAddr.Visible = false;
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
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(113, 32);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(151, 20);
			this.txtUrl.TabIndex = 9;
			// 
			// lblUrl
			// 
			this.lblUrl.AutoSize = true;
			this.lblUrl.Location = new System.Drawing.Point(8, 35);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(29, 13);
			this.lblUrl.TabIndex = 10;
			this.lblUrl.Text = "URL";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(16, 184);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// txtClientUserName
			// 
			this.txtClientUserName.Location = new System.Drawing.Point(116, 3);
			this.txtClientUserName.Name = "txtClientUserName";
			this.txtClientUserName.Size = new System.Drawing.Size(151, 20);
			this.txtClientUserName.TabIndex = 12;
			// 
			// lblTwitterClientUserName
			// 
			this.lblTwitterClientUserName.AutoSize = true;
			this.lblTwitterClientUserName.Location = new System.Drawing.Point(3, 6);
			this.lblTwitterClientUserName.Name = "lblTwitterClientUserName";
			this.lblTwitterClientUserName.Size = new System.Drawing.Size(92, 13);
			this.lblTwitterClientUserName.TabIndex = 13;
			this.lblTwitterClientUserName.Text = "Client User Name:";
			// 
			// txtTwitterClientPassword
			// 
			this.txtTwitterClientPassword.Location = new System.Drawing.Point(116, 29);
			this.txtTwitterClientPassword.Name = "txtTwitterClientPassword";
			this.txtTwitterClientPassword.Size = new System.Drawing.Size(151, 20);
			this.txtTwitterClientPassword.TabIndex = 14;
			// 
			// txtTwitterServerUserName
			// 
			this.txtTwitterServerUserName.Location = new System.Drawing.Point(116, 55);
			this.txtTwitterServerUserName.Name = "txtTwitterServerUserName";
			this.txtTwitterServerUserName.Size = new System.Drawing.Size(151, 20);
			this.txtTwitterServerUserName.TabIndex = 15;
			// 
			// lblTwitterClientPassword
			// 
			this.lblTwitterClientPassword.AutoSize = true;
			this.lblTwitterClientPassword.Location = new System.Drawing.Point(3, 32);
			this.lblTwitterClientPassword.Name = "lblTwitterClientPassword";
			this.lblTwitterClientPassword.Size = new System.Drawing.Size(85, 13);
			this.lblTwitterClientPassword.TabIndex = 16;
			this.lblTwitterClientPassword.Text = "Client Password:";
			// 
			// lblTwitterServerUserName
			// 
			this.lblTwitterServerUserName.AutoSize = true;
			this.lblTwitterServerUserName.Location = new System.Drawing.Point(3, 58);
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
			this.pnlTwitter.Controls.Add(this.txtClientUserName);
			this.pnlTwitter.Controls.Add(this.lblTwitterServerUserName);
			this.pnlTwitter.Location = new System.Drawing.Point(12, 59);
			this.pnlTwitter.Name = "pnlTwitter";
			this.pnlTwitter.Size = new System.Drawing.Size(270, 87);
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
			this.pnlHtml.Location = new System.Drawing.Point(12, 59);
			this.pnlHtml.Name = "pnlHtml";
			this.pnlHtml.Size = new System.Drawing.Size(282, 99);
			this.pnlHtml.TabIndex = 19;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 238);
			this.Controls.Add(this.pnlHtml);
			this.Controls.Add(this.pnlTwitter);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cbCommunicationType);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Tunneling Proxy Client Configuration";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlTwitter.ResumeLayout(false);
			this.pnlTwitter.PerformLayout();
			this.pnlHtml.ResumeLayout(false);
			this.pnlHtml.PerformLayout();
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
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtClientUserName;
		private System.Windows.Forms.Label lblTwitterClientUserName;
		private System.Windows.Forms.TextBox txtTwitterClientPassword;
		private System.Windows.Forms.TextBox txtTwitterServerUserName;
		private System.Windows.Forms.Label lblTwitterClientPassword;
		private System.Windows.Forms.Label lblTwitterServerUserName;
		private System.Windows.Forms.Panel pnlTwitter;
		private System.Windows.Forms.Panel pnlHtml;
	}
}

