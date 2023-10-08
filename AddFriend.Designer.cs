namespace LXMessenger
{
    partial class AddFriend
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBoxUsername = new TextBox();
            panelUsers = new Panel();
            pictureBoxProfile = new PictureBox();
            labelusername = new Label();
            labelrealname = new Label();
            groupBoxInfos = new GroupBox();
            buttonaddfriend = new Button();
            buttoncancel = new Button();
            buttonaccept = new Button();
            labelinfofriend = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            groupBoxInfos.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(274, 102);
            label1.Name = "label1";
            label1.Size = new Size(218, 24);
            label1.TabIndex = 0;
            label1.Text = "Add your friends";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(11, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(54, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 3);
            panel1.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.BlueViolet;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxUsername.ForeColor = Color.White;
            textBoxUsername.Location = new Point(60, 197);
            textBoxUsername.MaxLength = 20;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(231, 21);
            textBoxUsername.TabIndex = 3;
            textBoxUsername.Text = "Click Here To Search";
            textBoxUsername.Click += textBoxUsername_Click;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // panelUsers
            // 
            panelUsers.Location = new Point(54, 233);
            panelUsers.Name = "panelUsers";
            panelUsers.Size = new Size(253, 337);
            panelUsers.TabIndex = 4;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(63, 9);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(208, 167);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 5;
            pictureBoxProfile.TabStop = false;
            // 
            // labelusername
            // 
            labelusername.AutoSize = true;
            labelusername.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelusername.ForeColor = Color.White;
            labelusername.Location = new Point(54, 179);
            labelusername.Name = "labelusername";
            labelusername.Size = new Size(90, 19);
            labelusername.TabIndex = 6;
            labelusername.Text = "Username : ";
            // 
            // labelrealname
            // 
            labelrealname.AutoSize = true;
            labelrealname.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelrealname.ForeColor = Color.White;
            labelrealname.Location = new Point(54, 218);
            labelrealname.Name = "labelrealname";
            labelrealname.Size = new Size(83, 19);
            labelrealname.TabIndex = 7;
            labelrealname.Text = "Real name : ";
            // 
            // groupBoxInfos
            // 
            groupBoxInfos.Controls.Add(labelinfofriend);
            groupBoxInfos.Controls.Add(buttonaddfriend);
            groupBoxInfos.Controls.Add(buttoncancel);
            groupBoxInfos.Controls.Add(buttonaccept);
            groupBoxInfos.Controls.Add(pictureBoxProfile);
            groupBoxInfos.Controls.Add(labelusername);
            groupBoxInfos.Controls.Add(labelrealname);
            groupBoxInfos.FlatStyle = FlatStyle.Flat;
            groupBoxInfos.Location = new Point(390, 224);
            groupBoxInfos.Name = "groupBoxInfos";
            groupBoxInfos.Size = new Size(333, 343);
            groupBoxInfos.TabIndex = 9;
            groupBoxInfos.TabStop = false;
            groupBoxInfos.Visible = false;
            // 
            // buttonaddfriend
            // 
            buttonaddfriend.BackgroundImage = Properties.Resources.group;
            buttonaddfriend.BackgroundImageLayout = ImageLayout.Zoom;
            buttonaddfriend.FlatAppearance.BorderSize = 0;
            buttonaddfriend.FlatStyle = FlatStyle.Flat;
            buttonaddfriend.Location = new Point(153, 262);
            buttonaddfriend.Name = "buttonaddfriend";
            buttonaddfriend.Size = new Size(49, 39);
            buttonaddfriend.TabIndex = 10;
            buttonaddfriend.UseVisualStyleBackColor = true;
            buttonaddfriend.Click += buttonaddfriend_Click;
            // 
            // buttoncancel
            // 
            buttoncancel.BackgroundImage = Properties.Resources.multiply;
            buttoncancel.BackgroundImageLayout = ImageLayout.Center;
            buttoncancel.FlatAppearance.BorderSize = 0;
            buttoncancel.FlatStyle = FlatStyle.Flat;
            buttoncancel.Location = new Point(208, 262);
            buttoncancel.Name = "buttoncancel";
            buttoncancel.Size = new Size(49, 39);
            buttoncancel.TabIndex = 9;
            buttoncancel.UseVisualStyleBackColor = true;
            buttoncancel.Visible = false;
            buttoncancel.Click += buttoncancel_Click;
            // 
            // buttonaccept
            // 
            buttonaccept.BackColor = Color.BlueViolet;
            buttonaccept.BackgroundImage = Properties.Resources._checked;
            buttonaccept.BackgroundImageLayout = ImageLayout.Center;
            buttonaccept.FlatAppearance.BorderSize = 0;
            buttonaccept.FlatStyle = FlatStyle.Flat;
            buttonaccept.Location = new Point(87, 262);
            buttonaccept.Name = "buttonaccept";
            buttonaccept.Size = new Size(50, 39);
            buttonaccept.TabIndex = 8;
            buttonaccept.UseVisualStyleBackColor = false;
            buttonaccept.Visible = false;
            buttonaccept.Click += buttonaccept_Click;
            // 
            // labelinfofriend
            // 
            labelinfofriend.AutoSize = true;
            labelinfofriend.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelinfofriend.Location = new Point(6, 313);
            labelinfofriend.Name = "labelinfofriend";
            labelinfofriend.Size = new Size(0, 17);
            labelinfofriend.TabIndex = 11;
            // 
            // AddFriend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.BlueViolet;
            Controls.Add(groupBoxInfos);
            Controls.Add(panelUsers);
            Controls.Add(textBoxUsername);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "AddFriend";
            Size = new Size(775, 570);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            groupBoxInfos.ResumeLayout(false);
            groupBoxInfos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBoxUsername;
        private Panel panelUsers;
        private PictureBox pictureBoxProfile;
        private Label labelusername;
        private Label labelrealname;
        private GroupBox groupBoxInfos;
        private Button buttonaccept;
        private Button buttoncancel;
        private Button buttonaddfriend;
        private Label labelinfofriend;
    }
}
