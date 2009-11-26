namespace ActiveUp.Net.Samples.POP3
{
    partial class SecureConnectionUsingApop
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
            this._tbPop3Server = new System.Windows.Forms.TextBox();
            this._lUserName = new System.Windows.Forms.Label();
            this._tbUserName = new System.Windows.Forms.TextBox();
            this._lPop3Server = new System.Windows.Forms.Label();
            this._tbPassword = new System.Windows.Forms.TextBox();
            this._lPassword = new System.Windows.Forms.Label();
            this._bRetrieveMessage = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._tbPop3Server);
            this.splitContainer1.Panel1.Controls.Add(this._lUserName);
            this.splitContainer1.Panel1.Controls.Add(this._bRetrieveMessage);
            this.splitContainer1.Panel1.Controls.Add(this._tbUserName);
            this.splitContainer1.Panel1.Controls.Add(this._lPassword);
            this.splitContainer1.Panel1.Controls.Add(this._lPop3Server);
            this.splitContainer1.Panel1.Controls.Add(this._tbPassword);
            this.splitContainer1.TabIndex = 1;
            // 
            // _tbPop3Server
            // 
            this._tbPop3Server.Location = new System.Drawing.Point(15, 104);
            this._tbPop3Server.Name = "_tbPop3Server";
            this._tbPop3Server.Size = new System.Drawing.Size(270, 20);
            this._tbPop3Server.TabIndex = 5;
            // 
            // _lUserName
            // 
            this._lUserName.AutoSize = true;
            this._lUserName.Location = new System.Drawing.Point(12, 10);
            this._lUserName.Name = "_lUserName";
            this._lUserName.Size = new System.Drawing.Size(61, 13);
            this._lUserName.TabIndex = 0;
            this._lUserName.Text = "User name:";
            // 
            // _tbUserName
            // 
            this._tbUserName.Location = new System.Drawing.Point(15, 26);
            this._tbUserName.Name = "_tbUserName";
            this._tbUserName.Size = new System.Drawing.Size(270, 20);
            this._tbUserName.TabIndex = 1;
            // 
            // _lPop3Server
            // 
            this._lPop3Server.AutoSize = true;
            this._lPop3Server.Location = new System.Drawing.Point(12, 88);
            this._lPop3Server.Name = "_lPop3Server";
            this._lPop3Server.Size = new System.Drawing.Size(244, 13);
            this._lPop3Server.TabIndex = 4;
            this._lPop3Server.Text = "POP3 server address (will use 110 as default port):";
            // 
            // _tbPassword
            // 
            this._tbPassword.Location = new System.Drawing.Point(15, 65);
            this._tbPassword.Name = "_tbPassword";
            this._tbPassword.Size = new System.Drawing.Size(270, 20);
            this._tbPassword.TabIndex = 3;
            // 
            // _lPassword
            // 
            this._lPassword.AutoSize = true;
            this._lPassword.Location = new System.Drawing.Point(12, 49);
            this._lPassword.Name = "_lPassword";
            this._lPassword.Size = new System.Drawing.Size(56, 13);
            this._lPassword.TabIndex = 2;
            this._lPassword.Text = "Password:";
            // 
            // _bRetrieveMessage
            // 
            this._bRetrieveMessage.Location = new System.Drawing.Point(15, 178);
            this._bRetrieveMessage.Name = "_bRetrieveMessage";
            this._bRetrieveMessage.Size = new System.Drawing.Size(270, 36);
            this._bRetrieveMessage.TabIndex = 6;
            this._bRetrieveMessage.Text = "Retrieve message";
            this._bRetrieveMessage.UseVisualStyleBackColor = true;
            this._bRetrieveMessage.Click += new System.EventHandler(this._bRetrieveMessage_Click);
            // 
            // SecureConnectionUsingApop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(910, 514);
            this.Name = "SecureConnectionUsingApop";
            this.Text = "Secure connection using APOP";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbPop3Server;
        private System.Windows.Forms.Label _lUserName;
        private System.Windows.Forms.TextBox _tbUserName;
        private System.Windows.Forms.Label _lPop3Server;
        private System.Windows.Forms.TextBox _tbPassword;
        private System.Windows.Forms.Label _lPassword;
        private System.Windows.Forms.Button _bRetrieveMessage;
    }
}
