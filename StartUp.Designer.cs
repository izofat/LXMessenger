namespace LXMessenger
{
    partial class StartUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            pictureBoxIcon = new PictureBox();
            panel1 = new Panel();
            pictureBoxUserName = new PictureBox();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            pictureBoxPassword = new PictureBox();
            panel2 = new Panel();
            labelTitle = new Label();
            buttonchangeview = new Button();
            labelActioninfo = new Label();
            linkLabelAction = new LinkLabel();
            buttonClose = new Button();
            buttonMinimal = new Button();
            toolTipMessageUsername = new ToolTip(components);
            pictureBoxUsernameTick = new PictureBox();
            toolTipMessagePassword = new ToolTip(components);
            pictureBoxPasswordTick = new PictureBox();
            labelSuccess = new Label();
            buttonAction = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsernameTick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswordTick).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Image = Properties.Resources.dbe0d2bd40a341bcc367ecd26c7d3a80;
            pictureBoxIcon.Location = new Point(133, 73);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(52, 50);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Location = new Point(37, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 2);
            panel1.TabIndex = 1;
            // 
            // pictureBoxUserName
            // 
            pictureBoxUserName.Image = Properties.Resources.istockphoto_1473534533_170667a;
            pictureBoxUserName.Location = new Point(37, 186);
            pictureBoxUserName.Name = "pictureBoxUserName";
            pictureBoxUserName.Size = new Size(30, 28);
            pictureBoxUserName.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUserName.TabIndex = 2;
            pictureBoxUserName.TabStop = false;
            // 
            // textBoxUserName
            // 
            textBoxUserName.BorderStyle = BorderStyle.None;
            textBoxUserName.Cursor = Cursors.Hand;
            textBoxUserName.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserName.ForeColor = Color.Black;
            textBoxUserName.Location = new Point(71, 190);
            textBoxUserName.MaxLength = 20;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(193, 22);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Cursor = Cursors.Hand;
            textBoxPassword.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(71, 264);
            textBoxPassword.MaxLength = 20;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(193, 22);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.Image = Properties.Resources.images;
            pictureBoxPassword.Location = new Point(37, 259);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(30, 28);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPassword.TabIndex = 5;
            pictureBoxPassword.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Location = new Point(37, 293);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 2);
            panel2.TabIndex = 4;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(0, 117, 214);
            labelTitle.Location = new Point(80, 38);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(166, 32);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "LXMessenger";
            // 
            // buttonchangeview
            // 
            buttonchangeview.BackColor = Color.White;
            buttonchangeview.Cursor = Cursors.Hand;
            buttonchangeview.FlatAppearance.BorderColor = Color.Black;
            buttonchangeview.FlatStyle = FlatStyle.Flat;
            buttonchangeview.ForeColor = Color.White;
            buttonchangeview.Image = Properties.Resources.show;
            buttonchangeview.Location = new Point(242, 259);
            buttonchangeview.Name = "buttonchangeview";
            buttonchangeview.Size = new Size(37, 31);
            buttonchangeview.TabIndex = 8;
            buttonchangeview.UseVisualStyleBackColor = false;
            buttonchangeview.Click += buttonchangeview_Click;
            // 
            // labelActioninfo
            // 
            labelActioninfo.AutoSize = true;
            labelActioninfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelActioninfo.Location = new Point(114, 404);
            labelActioninfo.Name = "labelActioninfo";
            labelActioninfo.Size = new Size(147, 17);
            labelActioninfo.TabIndex = 12;
            labelActioninfo.Text = "Don't have an account ?";
            // 
            // linkLabelAction
            // 
            linkLabelAction.AutoSize = true;
            linkLabelAction.Cursor = Cursors.Hand;
            linkLabelAction.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelAction.Location = new Point(259, 404);
            linkLabelAction.Name = "linkLabelAction";
            linkLabelAction.Size = new Size(56, 17);
            linkLabelAction.TabIndex = 13;
            linkLabelAction.TabStop = true;
            linkLabelAction.Text = "Register";
            linkLabelAction.LinkClicked += linkLabelAction_LinkClicked;
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = Properties.Resources.close_button;
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(296, 1);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(37, 37);
            buttonClose.TabIndex = 14;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonMinimal
            // 
            buttonMinimal.BackgroundImage = (Image)resources.GetObject("buttonMinimal.BackgroundImage");
            buttonMinimal.BackgroundImageLayout = ImageLayout.Center;
            buttonMinimal.Cursor = Cursors.Hand;
            buttonMinimal.FlatAppearance.BorderSize = 0;
            buttonMinimal.FlatStyle = FlatStyle.Flat;
            buttonMinimal.Location = new Point(259, 1);
            buttonMinimal.Name = "buttonMinimal";
            buttonMinimal.Size = new Size(37, 37);
            buttonMinimal.TabIndex = 15;
            buttonMinimal.UseVisualStyleBackColor = true;
            buttonMinimal.Click += buttonMinimal_Click;
            // 
            // pictureBoxUsernameTick
            // 
            pictureBoxUsernameTick.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxUsernameTick.Image = (Image)resources.GetObject("pictureBoxUsernameTick.Image");
            pictureBoxUsernameTick.Location = new Point(277, 177);
            pictureBoxUsernameTick.Name = "pictureBoxUsernameTick";
            pictureBoxUsernameTick.Size = new Size(48, 45);
            pictureBoxUsernameTick.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsernameTick.TabIndex = 16;
            pictureBoxUsernameTick.TabStop = false;
            pictureBoxUsernameTick.Visible = false;
            // 
            // pictureBoxPasswordTick
            // 
            pictureBoxPasswordTick.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxPasswordTick.Image = (Image)resources.GetObject("pictureBoxPasswordTick.Image");
            pictureBoxPasswordTick.Location = new Point(277, 250);
            pictureBoxPasswordTick.Name = "pictureBoxPasswordTick";
            pictureBoxPasswordTick.Size = new Size(48, 45);
            pictureBoxPasswordTick.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPasswordTick.TabIndex = 17;
            pictureBoxPasswordTick.TabStop = false;
            pictureBoxPasswordTick.Visible = false;
            // 
            // labelSuccess
            // 
            labelSuccess.AutoSize = true;
            labelSuccess.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSuccess.ForeColor = Color.Black;
            labelSuccess.Location = new Point(52, 351);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(219, 20);
            labelSuccess.TabIndex = 18;
            labelSuccess.Text = "Account created successfully";
            labelSuccess.Visible = false;
            // 
            // buttonAction
            // 
            buttonAction.BackColor = Color.FromArgb(128, 128, 255);
            buttonAction.Cursor = Cursors.Hand;
            buttonAction.FlatStyle = FlatStyle.Flat;
            buttonAction.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAction.ForeColor = Color.White;
            buttonAction.Location = new Point(80, 309);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(140, 39);
            buttonAction.TabIndex = 19;
            buttonAction.Text = "Log In";
            buttonAction.UseVisualStyleBackColor = false;
            buttonAction.Click += buttonAction_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // StartUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 447);
            Controls.Add(buttonAction);
            Controls.Add(labelSuccess);
            Controls.Add(pictureBoxPasswordTick);
            Controls.Add(pictureBoxUsernameTick);
            Controls.Add(buttonMinimal);
            Controls.Add(buttonClose);
            Controls.Add(linkLabelAction);
            Controls.Add(labelActioninfo);
            Controls.Add(buttonchangeview);
            Controls.Add(labelTitle);
            Controls.Add(textBoxPassword);
            Controls.Add(pictureBoxPassword);
            Controls.Add(panel2);
            Controls.Add(textBoxUserName);
            Controls.Add(pictureBoxUserName);
            Controls.Add(panel1);
            Controls.Add(pictureBoxIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsernameTick).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswordTick).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxIcon;
        private Panel panel1;
        private PictureBox pictureBoxUserName;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private PictureBox pictureBoxPassword;
        private Panel panel2;
        private Label labelTitle;
        private Button buttonchangeview;
        private Label labelActioninfo;
        private LinkLabel linkLabelAction;
        private Button buttonClose;
        private Button buttonMinimal;
        private ToolTip toolTipMessageUsername;
        private PictureBox pictureBoxUsernameTick;
        private ToolTip toolTipMessagePassword;
        private PictureBox pictureBoxPasswordTick;
        private Label labelSuccess;
        private Button buttonAction;
        private System.Windows.Forms.Timer timer1;
    }
}