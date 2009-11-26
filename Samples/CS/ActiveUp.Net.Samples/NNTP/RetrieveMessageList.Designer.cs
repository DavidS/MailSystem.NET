namespace ActiveUp.Net.Samples.NNTP
{
    partial class RetrieveMessageList
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
            this._tbNewsgroup = new System.Windows.Forms.TextBox();
            this._lNewsgroup = new System.Windows.Forms.Label();
            this._tbNntpServer = new System.Windows.Forms.TextBox();
            this._lNntpServer = new System.Windows.Forms.Label();
            this._bRetrieveMessageList = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._tbNewsgroup);
            this.splitContainer1.Panel1.Controls.Add(this._lNewsgroup);
            this.splitContainer1.Panel1.Controls.Add(this._bRetrieveMessageList);
            this.splitContainer1.Panel1.Controls.Add(this._tbNntpServer);
            this.splitContainer1.Panel1.Controls.Add(this._lNntpServer);
            this.splitContainer1.TabIndex = 1;
            // 
            // _tbNewsgroup
            // 
            this._tbNewsgroup.Location = new System.Drawing.Point(15, 27);
            this._tbNewsgroup.Name = "_tbNewsgroup";
            this._tbNewsgroup.Size = new System.Drawing.Size(270, 20);
            this._tbNewsgroup.TabIndex = 1;
            // 
            // _lNewsgroup
            // 
            this._lNewsgroup.AutoSize = true;
            this._lNewsgroup.Location = new System.Drawing.Point(12, 11);
            this._lNewsgroup.Name = "_lNewsgroup";
            this._lNewsgroup.Size = new System.Drawing.Size(64, 13);
            this._lNewsgroup.TabIndex = 0;
            this._lNewsgroup.Text = "Newsgroup:";
            // 
            // _tbNntpServer
            // 
            this._tbNntpServer.Location = new System.Drawing.Point(15, 68);
            this._tbNntpServer.Name = "_tbNntpServer";
            this._tbNntpServer.Size = new System.Drawing.Size(270, 20);
            this._tbNntpServer.TabIndex = 3;
            // 
            // _lNntpServer
            // 
            this._lNntpServer.AutoSize = true;
            this._lNntpServer.Location = new System.Drawing.Point(12, 52);
            this._lNntpServer.Name = "_lNntpServer";
            this._lNntpServer.Size = new System.Drawing.Size(246, 13);
            this._lNntpServer.TabIndex = 2;
            this._lNntpServer.Text = "NNTP server address (will use 119 as default port):";
            // 
            // _bRetrieveMessageList
            // 
            this._bRetrieveMessageList.Location = new System.Drawing.Point(15, 142);
            this._bRetrieveMessageList.Name = "_bRetrieveMessageList";
            this._bRetrieveMessageList.Size = new System.Drawing.Size(270, 36);
            this._bRetrieveMessageList.TabIndex = 4;
            this._bRetrieveMessageList.Text = "Retrieve message list";
            this._bRetrieveMessageList.UseVisualStyleBackColor = true;
            this._bRetrieveMessageList.Click += new System.EventHandler(this._bRetrieveMessageList_Click);
            // 
            // RetrieveMessageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(910, 514);
            this.Name = "RetrieveMessageList";
            this.Text = "Retrieve message list";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbNewsgroup;
        private System.Windows.Forms.Label _lNewsgroup;
        private System.Windows.Forms.Button _bRetrieveMessageList;
        private System.Windows.Forms.TextBox _tbNntpServer;
        private System.Windows.Forms.Label _lNntpServer;
    }
}
