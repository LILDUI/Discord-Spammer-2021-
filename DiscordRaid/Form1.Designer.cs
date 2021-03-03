namespace DiscordRaid
{
    partial class LilDui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LilDui));
            this.startSpam = new MetroFramework.Controls.MetroButton();
            this.stopSpam = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tokenLoaded = new MetroFramework.Controls.MetroLabel();
            this.tokenTextBox = new MetroFramework.Controls.MetroTextBox();
            this.messageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.channelTextBox = new MetroFramework.Controls.MetroTextBox();
            this.inviteTextBox = new MetroFramework.Controls.MetroTextBox();
            this.quitButton = new MetroFramework.Controls.MetroButton();
            this.leaveServer = new MetroFramework.Controls.MetroButton();
            this.timeoutTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inviteButton = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reactionButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.emojiTextBox = new MetroFramework.Controls.MetroTextBox();
            this.reactionMessageID = new MetroFramework.Controls.MetroTextBox();
            this.reactionChannelID = new MetroFramework.Controls.MetroTextBox();
            this.failedTokensTextBox = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startSpam
            // 
            this.startSpam.Location = new System.Drawing.Point(19, 252);
            this.startSpam.Name = "startSpam";
            this.startSpam.Size = new System.Drawing.Size(111, 23);
            this.startSpam.TabIndex = 12;
            this.startSpam.Text = "เริ่ม";
            this.startSpam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startSpam.Click += new System.EventHandler(this.startSpam_Click);
            // 
            // stopSpam
            // 
            this.stopSpam.Location = new System.Drawing.Point(134, 252);
            this.stopSpam.Name = "stopSpam";
            this.stopSpam.Size = new System.Drawing.Size(101, 23);
            this.stopSpam.TabIndex = 13;
            this.stopSpam.Text = "หยด";
            this.stopSpam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stopSpam.Click += new System.EventHandler(this.stopSpam_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(18, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "ใส่ โค้ดเซิพเวอร์";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "ใส่ ID ห้องเเชท";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "ข้อความที่ใช้สเเปม";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tokenLoaded
            // 
            this.tokenLoaded.AutoSize = true;
            this.tokenLoaded.ForeColor = System.Drawing.Color.Fuchsia;
            this.tokenLoaded.Location = new System.Drawing.Point(193, 453);
            this.tokenLoaded.Name = "tokenLoaded";
            this.tokenLoaded.Size = new System.Drawing.Size(126, 19);
            this.tokenLoaded.TabIndex = 19;
            this.tokenLoaded.Text = "โทเค็นทําการโหลดแล้ว";
            this.tokenLoaded.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.ForeColor = System.Drawing.Color.White;
            this.tokenTextBox.Location = new System.Drawing.Point(5, 475);
            this.tokenTextBox.Multiline = true;
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.ReadOnly = true;
            this.tokenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tokenTextBox.Size = new System.Drawing.Size(542, 187);
            this.tokenTextBox.TabIndex = 23;
            this.tokenTextBox.TabStop = false;
            this.tokenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tokenTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tokenTextBox.Click += new System.EventHandler(this.tokenTextBox_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(19, 147);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.PromptText = "u r loser lol";
            this.messageTextBox.Size = new System.Drawing.Size(216, 20);
            this.messageTextBox.TabIndex = 21;
            this.messageTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(18, 102);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.PromptText = "769013685929902110";
            this.channelTextBox.Size = new System.Drawing.Size(217, 20);
            this.channelTextBox.TabIndex = 22;
            this.channelTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inviteTextBox
            // 
            this.inviteTextBox.Location = new System.Drawing.Point(18, 57);
            this.inviteTextBox.Name = "inviteTextBox";
            this.inviteTextBox.PromptText = "K3zW8psRTp";
            this.inviteTextBox.Size = new System.Drawing.Size(217, 20);
            this.inviteTextBox.TabIndex = 20;
            this.inviteTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(527, 0);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(36, 18);
            this.quitButton.TabIndex = 24;
            this.quitButton.Text = "ออก";
            this.quitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // leaveServer
            // 
            this.leaveServer.Location = new System.Drawing.Point(18, 281);
            this.leaveServer.Name = "leaveServer";
            this.leaveServer.Size = new System.Drawing.Size(217, 23);
            this.leaveServer.TabIndex = 25;
            this.leaveServer.Text = "ออก";
            this.leaveServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.leaveServer.Click += new System.EventHandler(this.leaveServer_Click);
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.Location = new System.Drawing.Point(18, 193);
            this.timeoutTextBox.Name = "timeoutTextBox";
            this.timeoutTextBox.PromptText = "300";
            this.timeoutTextBox.Size = new System.Drawing.Size(217, 20);
            this.timeoutTextBox.TabIndex = 26;
            this.timeoutTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 168);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(129, 19);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "หมดเวลาเป็นมิลลิวินาที";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inviteButton);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.timeoutTextBox);
            this.groupBox1.Controls.Add(this.leaveServer);
            this.groupBox1.Controls.Add(this.inviteTextBox);
            this.groupBox1.Controls.Add(this.channelTextBox);
            this.groupBox1.Controls.Add(this.messageTextBox);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.stopSpam);
            this.groupBox1.Controls.Add(this.startSpam);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 333);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เชิญ/สเเปม";
            // 
            // inviteButton
            // 
            this.inviteButton.Location = new System.Drawing.Point(18, 219);
            this.inviteButton.Name = "inviteButton";
            this.inviteButton.Size = new System.Drawing.Size(216, 27);
            this.inviteButton.TabIndex = 28;
            this.inviteButton.Text = "เชิญ";
            this.inviteButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.inviteButton.Click += new System.EventHandler(this.inviteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reactionButton);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.emojiTextBox);
            this.groupBox2.Controls.Add(this.reactionMessageID);
            this.groupBox2.Controls.Add(this.reactionChannelID);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(276, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 333);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รีเเอคชั่น";
            // 
            // reactionButton
            // 
            this.reactionButton.Location = new System.Drawing.Point(17, 193);
            this.reactionButton.Name = "reactionButton";
            this.reactionButton.Size = new System.Drawing.Size(216, 27);
            this.reactionButton.TabIndex = 6;
            this.reactionButton.Text = "ใส่รีเเอคชัน";
            this.reactionButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.reactionButton.Click += new System.EventHandler(this.reactionButton_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 125);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "อีโมจิ";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 80);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(129, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "ID ข้อความที่จะใส่อีโมจิ";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(16, 27);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "ID ช่องเเชท";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // emojiTextBox
            // 
            this.emojiTextBox.Location = new System.Drawing.Point(16, 147);
            this.emojiTextBox.Name = "emojiTextBox";
            this.emojiTextBox.Size = new System.Drawing.Size(217, 20);
            this.emojiTextBox.TabIndex = 2;
            this.emojiTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // reactionMessageID
            // 
            this.reactionMessageID.Location = new System.Drawing.Point(16, 102);
            this.reactionMessageID.Name = "reactionMessageID";
            this.reactionMessageID.PromptText = "807033702932545588";
            this.reactionMessageID.Size = new System.Drawing.Size(217, 20);
            this.reactionMessageID.TabIndex = 1;
            this.reactionMessageID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // reactionChannelID
            // 
            this.reactionChannelID.Location = new System.Drawing.Point(16, 57);
            this.reactionChannelID.Name = "reactionChannelID";
            this.reactionChannelID.PromptText = "769013685929902110";
            this.reactionChannelID.Size = new System.Drawing.Size(217, 20);
            this.reactionChannelID.TabIndex = 0;
            this.reactionChannelID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // failedTokensTextBox
            // 
            this.failedTokensTextBox.AutoSize = true;
            this.failedTokensTextBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.failedTokensTextBox.Location = new System.Drawing.Point(5, 82);
            this.failedTokensTextBox.Name = "failedTokensTextBox";
            this.failedTokensTextBox.Size = new System.Drawing.Size(96, 19);
            this.failedTokensTextBox.TabIndex = 30;
            this.failedTokensTextBox.Text = "โทเค็นที่ล้มเหลว:";
            this.failedTokensTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LilDui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 672);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.failedTokensTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(this.tokenLoaded);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LilDui";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Dui SCR";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton startSpam;
        private MetroFramework.Controls.MetroButton stopSpam;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel tokenLoaded;
        private MetroFramework.Controls.MetroTextBox tokenTextBox;
        private MetroFramework.Controls.MetroTextBox messageTextBox;
        private MetroFramework.Controls.MetroTextBox channelTextBox;
        private MetroFramework.Controls.MetroTextBox inviteTextBox;
        private MetroFramework.Controls.MetroButton quitButton;
        private MetroFramework.Controls.MetroButton leaveServer;
        private MetroFramework.Controls.MetroTextBox timeoutTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton reactionButton;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox emojiTextBox;
        private MetroFramework.Controls.MetroTextBox reactionMessageID;
        private MetroFramework.Controls.MetroTextBox reactionChannelID;
        private MetroFramework.Controls.MetroButton inviteButton;
        private MetroFramework.Controls.MetroLabel failedTokensTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

