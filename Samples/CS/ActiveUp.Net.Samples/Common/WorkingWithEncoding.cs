using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ActiveUp.Net.Samples.Utils;
using ActiveUp.Net.Mail;

namespace ActiveUp.Net.Samples.Common
{
    public partial class WorkingWithEncoding : ActiveUp.Net.Samples.Utils.MasterForm
    {
        public WorkingWithEncoding(SamplesConfiguration config)
        {
            this.Config = config;
            InitializeComponent();
            InitializeSample();
        }

        protected override void InitializeSample()
        {
            base.InitializeSample();

            this._tbToEmail.Text = this.Config.ToEmail;
            this._tbFromEmail.Text = this.Config.FromEmail;
            this._tbSubject.Text = this.Config.DefaultSubject;
            this._tbBodyText.Text = this.Config.DefaultBodyText;
            this._tbSmtpServer.Text = this.Config.MainSmtpServer.Host;
        }

        private void _tbSendMessage_Click(object sender, EventArgs e)
        {
            this.AddLogEntry("Creating message.");

            // We create the message object
            ActiveUp.Net.Mail.Message message = new ActiveUp.Net.Mail.Message();

            // We assign the sender email
            message.From.Email = this._tbFromEmail.Text;

            // We assign the recipient email
            message.To.Add(this._tbToEmail.Text);

            // We assign the subject
            message.Subject = this._tbSubject.Text;

            // We assign the body text
            message.BodyText.Text = this._tbBodyText.Text;

            // We use base 64 encoding
            message.ContentTransferEncoding = ContentTransferEncoding.Base64;   

            message.BuildMimePartTree();

            // We send the email using the specified SMTP server
            this.AddLogEntry("Sending message.");

            try
            {
                message.Send(this._tbSmtpServer.Text);

                this.AddLogEntry("Message sent successfully.");
            }

            catch (SmtpException ex)
            {
                this.AddLogEntry(string.Format("Smtp Error: {0}", ex.Message));
            }

            catch (Exception ex)
            {
                this.AddLogEntry(string.Format("Failed: {0}", ex.Message));
            }
        }
    }
}

