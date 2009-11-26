namespace ActiveUp.Net.Samples.SMTP
{
    partial class SendingUsingAnSmtpServer
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
            this.toEmailLabel = new System.Windows.Forms.Label();
            this.toEmailTextbox = new System.Windows.Forms.TextBox();
            this.fromEmailLabel = new System.Windows.Forms.Label();
            this.fromEmailTextbox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectTextbox = new System.Windows.Forms.TextBox();
            this.bodyTextLabel = new System.Windows.Forms.Label();
            this.bodyTextTextbox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.smtpServerAddressLabel = new System.Windows.Forms.Label();
            this.smtpServerAddressTextbox = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.smtpServerAddressTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.smtpServerAddressLabel);
            this.splitContainer1.Panel1.Controls.Add(this.sendMessageButton);
            this.splitContainer1.Panel1.Controls.Add(this.bodyTextTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.bodyTextLabel);
            this.splitContainer1.Panel1.Controls.Add(this.subjectTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.subjectLabel);
            this.splitContainer1.Panel1.Controls.Add(this.fromEmailTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.fromEmailLabel);
            this.splitContainer1.Panel1.Controls.Add(this.toEmailTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.toEmailLabel);
            this.splitContainer1.Size = new System.Drawing.Size(942, 514);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 1;
            // 
            // toEmailLabel
            // 
            this.toEmailLabel.AutoSize = true;
            this.toEmailLabel.Location = new System.Drawing.Point(12, 49);
            this.toEmailLabel.Name = "toEmailLabel";
            this.toEmailLabel.Size = new System.Drawing.Size(50, 13);
            this.toEmailLabel.TabIndex = 2;
            this.toEmailLabel.Text = "To email:";
            // 
            // toEmailTextbox
            // 
            this.toEmailTextbox.Location = new System.Drawing.Point(15, 65);
            this.toEmailTextbox.Name = "toEmailTextbox";
            this.toEmailTextbox.Size = new System.Drawing.Size(206, 20);
            this.toEmailTextbox.TabIndex = 3;
            // 
            // fromEmailLabel
            // 
            this.fromEmailLabel.AutoSize = true;
            this.fromEmailLabel.Location = new System.Drawing.Point(12, 10);
            this.fromEmailLabel.Name = "fromEmailLabel";
            this.fromEmailLabel.Size = new System.Drawing.Size(60, 13);
            this.fromEmailLabel.TabIndex = 0;
            this.fromEmailLabel.Text = "From email:";
            // 
            // fromEmailTextbox
            // 
            this.fromEmailTextbox.Location = new System.Drawing.Point(15, 26);
            this.fromEmailTextbox.Name = "fromEmailTextbox";
            this.fromEmailTextbox.Size = new System.Drawing.Size(206, 20);
            this.fromEmailTextbox.TabIndex = 1;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(12, 88);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 4;
            this.subjectLabel.Text = "Subject:";
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Location = new System.Drawing.Point(15, 104);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.Size = new System.Drawing.Size(270, 20);
            this.subjectTextbox.TabIndex = 5;
            // 
            // bodyTextLabel
            // 
            this.bodyTextLabel.AutoSize = true;
            this.bodyTextLabel.Location = new System.Drawing.Point(12, 127);
            this.bodyTextLabel.Name = "bodyTextLabel";
            this.bodyTextLabel.Size = new System.Drawing.Size(105, 13);
            this.bodyTextLabel.TabIndex = 6;
            this.bodyTextLabel.Text = "Body text (plain text):";
            // 
            // bodyTextTextbox
            // 
            this.bodyTextTextbox.Location = new System.Drawing.Point(15, 143);
            this.bodyTextTextbox.Multiline = true;
            this.bodyTextTextbox.Name = "bodyTextTextbox";
            this.bodyTextTextbox.Size = new System.Drawing.Size(270, 189);
            this.bodyTextTextbox.TabIndex = 7;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(12, 403);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(270, 36);
            this.sendMessageButton.TabIndex = 10;
            this.sendMessageButton.Text = "Send message";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // smtpServerAddressLabel
            // 
            this.smtpServerAddressLabel.AutoSize = true;
            this.smtpServerAddressLabel.Location = new System.Drawing.Point(12, 335);
            this.smtpServerAddressLabel.Name = "smtpServerAddressLabel";
            this.smtpServerAddressLabel.Size = new System.Drawing.Size(240, 13);
            this.smtpServerAddressLabel.TabIndex = 8;
            this.smtpServerAddressLabel.Text = "SMTP server address (will use 25 as default port):";
            // 
            // smtpServerAddressTextbox
            // 
            this.smtpServerAddressTextbox.Location = new System.Drawing.Point(12, 351);
            this.smtpServerAddressTextbox.Name = "smtpServerAddressTextbox";
            this.smtpServerAddressTextbox.Size = new System.Drawing.Size(273, 20);
            this.smtpServerAddressTextbox.TabIndex = 9;
            // 
            // SendingUsingAnSmtpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 514);
            this.Name = "SendingUsingAnSmtpServer";
            this.Text = "Sending using an smtp server";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label toEmailLabel;
        private System.Windows.Forms.TextBox toEmailTextbox;
        private System.Windows.Forms.TextBox fromEmailTextbox;
        private System.Windows.Forms.Label fromEmailLabel;
        private System.Windows.Forms.TextBox subjectTextbox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox smtpServerAddressTextbox;
        private System.Windows.Forms.Label smtpServerAddressLabel;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.TextBox bodyTextTextbox;
        private System.Windows.Forms.Label bodyTextLabel;
    }
}