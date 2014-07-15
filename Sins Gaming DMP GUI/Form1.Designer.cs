namespace Sins_Gaming_DMP_GUI
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
            this.consoleDisplayBox = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.Dekessler = new System.Windows.Forms.Button();
            this.NukeKSC = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.ServerMessageBox = new System.Windows.Forms.TextBox();
            this.SayButton = new System.Windows.Forms.Button();
            this.PMButton = new System.Windows.Forms.Button();
            this.PlayerList = new System.Windows.Forms.ListBox();
            this.KickButton = new System.Windows.Forms.Button();
            this.BanButton = new System.Windows.Forms.Button();
            this.RemoveAdminButton = new System.Windows.Forms.Button();
            this.AddAdminButton = new System.Windows.Forms.Button();
            this.BackupRetrievalButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consoleDisplayBox
            // 
            this.consoleDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleDisplayBox.Location = new System.Drawing.Point(200, 12);
            this.consoleDisplayBox.Name = "consoleDisplayBox";
            this.consoleDisplayBox.ReadOnly = true;
            this.consoleDisplayBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.consoleDisplayBox.Size = new System.Drawing.Size(782, 573);
            this.consoleDisplayBox.TabIndex = 0;
            this.consoleDisplayBox.Text = "";
            this.consoleDisplayBox.WordWrap = false;
            this.consoleDisplayBox.TextChanged += new System.EventHandler(this.consoleDisplayBox_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(11, 503);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(183, 38);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.start_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(11, 547);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(183, 38);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stop_Click);
            // 
            // Dekessler
            // 
            this.Dekessler.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Dekessler.Location = new System.Drawing.Point(12, 136);
            this.Dekessler.Name = "Dekessler";
            this.Dekessler.Size = new System.Drawing.Size(183, 28);
            this.Dekessler.TabIndex = 3;
            this.Dekessler.Text = "Clear All Debris from Server";
            this.Dekessler.UseVisualStyleBackColor = true;
            this.Dekessler.Click += new System.EventHandler(this.Dekessler_Click);
            // 
            // NukeKSC
            // 
            this.NukeKSC.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.NukeKSC.Location = new System.Drawing.Point(12, 170);
            this.NukeKSC.Name = "NukeKSC";
            this.NukeKSC.Size = new System.Drawing.Size(183, 28);
            this.NukeKSC.TabIndex = 4;
            this.NukeKSC.Text = "Clear All Vessels from Spacecenter";
            this.NukeKSC.UseVisualStyleBackColor = true;
            this.NukeKSC.Click += new System.EventHandler(this.NukeKSC_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPanel.BackgroundImage")));
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPanel.Location = new System.Drawing.Point(12, 12);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(183, 118);
            this.LogoPanel.TabIndex = 5;
            // 
            // ServerMessageBox
            // 
            this.ServerMessageBox.Location = new System.Drawing.Point(201, 606);
            this.ServerMessageBox.Name = "ServerMessageBox";
            this.ServerMessageBox.Size = new System.Drawing.Size(782, 20);
            this.ServerMessageBox.TabIndex = 6;
            // 
            // SayButton
            // 
            this.SayButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SayButton.Location = new System.Drawing.Point(110, 591);
            this.SayButton.Name = "SayButton";
            this.SayButton.Size = new System.Drawing.Size(85, 49);
            this.SayButton.TabIndex = 7;
            this.SayButton.Text = "Say";
            this.SayButton.UseVisualStyleBackColor = true;
            this.SayButton.Click += new System.EventHandler(this.SayButton_Click);
            // 
            // PMButton
            // 
            this.PMButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.PMButton.Location = new System.Drawing.Point(11, 591);
            this.PMButton.Name = "PMButton";
            this.PMButton.Size = new System.Drawing.Size(88, 49);
            this.PMButton.TabIndex = 8;
            this.PMButton.Text = "Private Message";
            this.PMButton.UseVisualStyleBackColor = true;
            this.PMButton.Click += new System.EventHandler(this.PMButton_Click);
            // 
            // PlayerList
            // 
            this.PlayerList.FormattingEnabled = true;
            this.PlayerList.Location = new System.Drawing.Point(12, 324);
            this.PlayerList.Name = "PlayerList";
            this.PlayerList.ScrollAlwaysVisible = true;
            this.PlayerList.Size = new System.Drawing.Size(182, 173);
            this.PlayerList.TabIndex = 9;
            // 
            // KickButton
            // 
            this.KickButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.KickButton.Location = new System.Drawing.Point(12, 294);
            this.KickButton.Name = "KickButton";
            this.KickButton.Size = new System.Drawing.Size(88, 24);
            this.KickButton.TabIndex = 10;
            this.KickButton.Text = "Kick";
            this.KickButton.UseVisualStyleBackColor = true;
            this.KickButton.Click += new System.EventHandler(this.KickButton_Click);
            // 
            // BanButton
            // 
            this.BanButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BanButton.Location = new System.Drawing.Point(106, 294);
            this.BanButton.Name = "BanButton";
            this.BanButton.Size = new System.Drawing.Size(88, 24);
            this.BanButton.TabIndex = 11;
            this.BanButton.Text = "Ban";
            this.BanButton.UseVisualStyleBackColor = true;
            this.BanButton.Click += new System.EventHandler(this.BanButton_Click);
            // 
            // RemoveAdminButton
            // 
            this.RemoveAdminButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.RemoveAdminButton.Location = new System.Drawing.Point(106, 264);
            this.RemoveAdminButton.Name = "RemoveAdminButton";
            this.RemoveAdminButton.Size = new System.Drawing.Size(88, 24);
            this.RemoveAdminButton.TabIndex = 13;
            this.RemoveAdminButton.Text = "Remove Admin";
            this.RemoveAdminButton.UseVisualStyleBackColor = true;
            this.RemoveAdminButton.Click += new System.EventHandler(this.RemoveAdminButton_Click);
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddAdminButton.Location = new System.Drawing.Point(12, 264);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(88, 24);
            this.AddAdminButton.TabIndex = 12;
            this.AddAdminButton.Text = "Make Admin";
            this.AddAdminButton.UseVisualStyleBackColor = true;
            this.AddAdminButton.Click += new System.EventHandler(this.AddAdminButton_Click);
            // 
            // BackupRetrievalButton
            // 
            this.BackupRetrievalButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackupRetrievalButton.Location = new System.Drawing.Point(13, 234);
            this.BackupRetrievalButton.Name = "BackupRetrievalButton";
            this.BackupRetrievalButton.Size = new System.Drawing.Size(182, 24);
            this.BackupRetrievalButton.TabIndex = 15;
            this.BackupRetrievalButton.Text = "Retrieve Backup";
            this.BackupRetrievalButton.UseVisualStyleBackColor = true;
            this.BackupRetrievalButton.Click += new System.EventHandler(this.BackupRetrievalButton_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackupButton.Location = new System.Drawing.Point(13, 204);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(182, 24);
            this.BackupButton.TabIndex = 14;
            this.BackupButton.Text = "Backup Server";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.SayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(995, 653);
            this.Controls.Add(this.BackupRetrievalButton);
            this.Controls.Add(this.BackupButton);
            this.Controls.Add(this.RemoveAdminButton);
            this.Controls.Add(this.AddAdminButton);
            this.Controls.Add(this.BanButton);
            this.Controls.Add(this.KickButton);
            this.Controls.Add(this.PlayerList);
            this.Controls.Add(this.PMButton);
            this.Controls.Add(this.SayButton);
            this.Controls.Add(this.ServerMessageBox);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.NukeKSC);
            this.Controls.Add(this.Dekessler);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.consoleDisplayBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sins Gaming - Dark Multiplayer GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox consoleDisplayBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button Dekessler;
        private System.Windows.Forms.Button NukeKSC;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.TextBox ServerMessageBox;
        private System.Windows.Forms.Button SayButton;
        private System.Windows.Forms.Button PMButton;
        private System.Windows.Forms.ListBox PlayerList;
        private System.Windows.Forms.Button KickButton;
        private System.Windows.Forms.Button BanButton;
        private System.Windows.Forms.Button RemoveAdminButton;
        private System.Windows.Forms.Button AddAdminButton;
        private System.Windows.Forms.Button BackupRetrievalButton;
        private System.Windows.Forms.Button BackupButton;
    }
}

