namespace LXMessenger
{
    partial class Messenger
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messenger));
            panelProfile = new Krypton.Toolkit.KryptonPanel();
            buttonSettings = new Button();
            labelRealname = new Label();
            labelUsername = new Label();
            pictureBoxProfile = new PictureBox();
            panelChat = new Krypton.Toolkit.KryptonPanel();
            pictureBoxApplication = new PictureBox();
            textBoxUsername = new TextBox();
            panel1 = new Panel();
            pictureBoxSearch = new PictureBox();
            label1 = new Label();
            panelChatInfo = new Krypton.Toolkit.KryptonPanel();
            labelnamefriend = new Label();
            labelChatUsername = new Label();
            pictureBoxFriend = new PictureBox();
            buttonAddFriend = new Button();
            buttonMinimize = new Button();
            buttonClose = new Button();
            panelMain = new Krypton.Toolkit.KryptonPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelFriends = new Panel();
            ((System.ComponentModel.ISupportInitialize)panelProfile).BeginInit();
            panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelChat).BeginInit();
            panelChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxApplication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelChatInfo).BeginInit();
            panelChatInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFriend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelMain).BeginInit();
            SuspendLayout();
            // 
            // panelProfile
            // 
            panelProfile.Controls.Add(buttonSettings);
            panelProfile.Controls.Add(labelRealname);
            panelProfile.Controls.Add(labelUsername);
            panelProfile.Controls.Add(pictureBoxProfile);
            panelProfile.Location = new Point(0, 0);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(325, 80);
            panelProfile.StateCommon.Color1 = Color.BlueViolet;
            panelProfile.TabIndex = 0;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.Transparent;
            buttonSettings.BackgroundImage = (Image)resources.GetObject("buttonSettings.BackgroundImage");
            buttonSettings.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Location = new Point(287, 3);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(38, 32);
            buttonSettings.TabIndex = 3;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // labelRealname
            // 
            labelRealname.AutoSize = true;
            labelRealname.BackColor = Color.BlueViolet;
            labelRealname.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelRealname.ForeColor = Color.White;
            labelRealname.Location = new Point(90, 57);
            labelRealname.Name = "labelRealname";
            labelRealname.Size = new Size(66, 17);
            labelRealname.TabIndex = 2;
            labelRealname.Text = "Welcome ";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.BlueViolet;
            labelUsername.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(90, 28);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(25, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "@";
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(14, 12);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(74, 62);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            // 
            // panelChat
            // 
            panelChat.Controls.Add(pictureBoxApplication);
            panelChat.Controls.Add(textBoxUsername);
            panelChat.Controls.Add(panel1);
            panelChat.Controls.Add(pictureBoxSearch);
            panelChat.Controls.Add(label1);
            panelChat.Location = new Point(0, 80);
            panelChat.Name = "panelChat";
            panelChat.Size = new Size(319, 190);
            panelChat.StateCommon.Color1 = Color.BlueViolet;
            panelChat.TabIndex = 1;
            panelChat.Visible = false;
            // 
            // pictureBoxApplication
            // 
            pictureBoxApplication.ErrorImage = null;
            pictureBoxApplication.Image = Properties.Resources.chat;
            pictureBoxApplication.InitialImage = null;
            pictureBoxApplication.Location = new Point(112, 0);
            pictureBoxApplication.Name = "pictureBoxApplication";
            pictureBoxApplication.Size = new Size(122, 131);
            pictureBoxApplication.TabIndex = 4;
            pictureBoxApplication.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.BlueViolet;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Yu Gothic UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.ForeColor = Color.White;
            textBoxUsername.Location = new Point(65, 153);
            textBoxUsername.MaxLength = 20;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(230, 21);
            textBoxUsername.TabIndex = 3;
            textBoxUsername.Text = "Click Here To Search";
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(65, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 3);
            panel1.TabIndex = 2;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.ErrorImage = null;
            pictureBoxSearch.Image = Properties.Resources.search;
            pictureBoxSearch.InitialImage = null;
            pictureBoxSearch.Location = new Point(12, 153);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(47, 31);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 1;
            pictureBoxSearch.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 131);
            label1.Name = "label1";
            label1.Size = new Size(297, 20);
            label1.TabIndex = 0;
            label1.Text = "Click one of your friends to start chatting";
            // 
            // panelChatInfo
            // 
            panelChatInfo.Controls.Add(labelnamefriend);
            panelChatInfo.Controls.Add(labelChatUsername);
            panelChatInfo.Controls.Add(pictureBoxFriend);
            panelChatInfo.Controls.Add(buttonAddFriend);
            panelChatInfo.Controls.Add(buttonMinimize);
            panelChatInfo.Controls.Add(buttonClose);
            panelChatInfo.Location = new Point(325, 0);
            panelChatInfo.Name = "panelChatInfo";
            panelChatInfo.Size = new Size(775, 80);
            panelChatInfo.StateCommon.Color1 = Color.BlueViolet;
            panelChatInfo.TabIndex = 2;
            // 
            // labelnamefriend
            // 
            labelnamefriend.AutoSize = true;
            labelnamefriend.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelnamefriend.ForeColor = Color.White;
            labelnamefriend.Location = new Point(161, 9);
            labelnamefriend.Name = "labelnamefriend";
            labelnamefriend.Size = new Size(152, 20);
            labelnamefriend.TabIndex = 22;
            labelnamefriend.Text = "You are chatting with ";
            labelnamefriend.Visible = false;
            // 
            // labelChatUsername
            // 
            labelChatUsername.AutoSize = true;
            labelChatUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelChatUsername.ForeColor = Color.White;
            labelChatUsername.Location = new Point(161, 40);
            labelChatUsername.Name = "labelChatUsername";
            labelChatUsername.Size = new Size(23, 20);
            labelChatUsername.TabIndex = 21;
            labelChatUsername.Text = "@";
            labelChatUsername.Visible = false;
            // 
            // pictureBoxFriend
            // 
            pictureBoxFriend.Location = new Point(38, 0);
            pictureBoxFriend.Name = "pictureBoxFriend";
            pictureBoxFriend.Size = new Size(106, 80);
            pictureBoxFriend.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFriend.TabIndex = 19;
            pictureBoxFriend.TabStop = false;
            pictureBoxFriend.Visible = false;
            // 
            // buttonAddFriend
            // 
            buttonAddFriend.BackgroundImage = Properties.Resources._new;
            buttonAddFriend.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddFriend.Cursor = Cursors.Hand;
            buttonAddFriend.FlatAppearance.BorderSize = 0;
            buttonAddFriend.FlatStyle = FlatStyle.Flat;
            buttonAddFriend.Location = new Point(620, 9);
            buttonAddFriend.Name = "buttonAddFriend";
            buttonAddFriend.Size = new Size(70, 62);
            buttonAddFriend.TabIndex = 18;
            buttonAddFriend.UseVisualStyleBackColor = true;
            buttonAddFriend.Click += buttonAddFriend_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.BackgroundImage = Properties.Resources.Capture;
            buttonMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Location = new Point(696, -2);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(42, 37);
            buttonMinimize.TabIndex = 17;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.BackgroundImage = Properties.Resources.close_button;
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(738, -2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(37, 37);
            buttonClose.TabIndex = 16;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(333, 99);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(767, 550);
            panelMain.StateCommon.Color1 = Color.BlueViolet;
            panelMain.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // panelFriends
            // 
            panelFriends.Location = new Point(3, 270);
            panelFriends.Name = "panelFriends";
            panelFriends.Size = new Size(306, 368);
            panelFriends.TabIndex = 4;
            // 
            // Messenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(1100, 650);
            Controls.Add(panelFriends);
            Controls.Add(panelMain);
            Controls.Add(panelChatInfo);
            Controls.Add(panelChat);
            Controls.Add(panelProfile);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Messenger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messenger";
            ((System.ComponentModel.ISupportInitialize)panelProfile).EndInit();
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelChat).EndInit();
            panelChat.ResumeLayout(false);
            panelChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxApplication).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelChatInfo).EndInit();
            panelChatInfo.ResumeLayout(false);
            panelChatInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFriend).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelProfile;
        private Krypton.Toolkit.KryptonPanel panelChat;
        private Krypton.Toolkit.KryptonPanel panelChatInfo;
        private Krypton.Toolkit.KryptonPanel panelMain;
        private System.Windows.Forms.Timer timer1;
        private Button buttonMinimize;
        private Button buttonClose;
        private PictureBox pictureBoxProfile;
        private Label labelRealname;
        private Label labelUsername;
        private Button buttonSettings;
        private Button buttonAddFriend;
        private Label label1;
        private TextBox textBoxUsername;
        private Panel panel1;
        private PictureBox pictureBoxSearch;
        private PictureBox pictureBoxApplication;
        private Button button2;
        private Label label2;
        private PictureBox pictureBoxFriend;
        private Label labelChatUsername;
        private Label labelnamefriend;
        private Panel panelFriends;
    }
}