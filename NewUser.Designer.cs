namespace LXMessenger
{
    partial class NewUser
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
            label5 = new Label();
            buttonPicture = new Button();
            labelinfoProfile = new Label();
            pictureBoxProfile = new PictureBox();
            label4 = new Label();
            textBoxRealName = new TextBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            buttonOKk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(246, 420);
            label5.Name = "label5";
            label5.Size = new Size(303, 17);
            label5.TabIndex = 36;
            label5.Text = "You can change these anytime you want in settings";
            // 
            // buttonPicture
            // 
            buttonPicture.BackColor = Color.DarkBlue;
            buttonPicture.FlatStyle = FlatStyle.Flat;
            buttonPicture.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPicture.ForeColor = Color.White;
            buttonPicture.Location = new Point(621, 286);
            buttonPicture.Name = "buttonPicture";
            buttonPicture.Size = new Size(40, 30);
            buttonPicture.TabIndex = 35;
            buttonPicture.Text = "...";
            buttonPicture.UseVisualStyleBackColor = false;
            buttonPicture.Click += buttonPicture_Click;
            // 
            // labelinfoProfile
            // 
            labelinfoProfile.AutoSize = true;
            labelinfoProfile.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelinfoProfile.ForeColor = Color.White;
            labelinfoProfile.Location = new Point(386, 319);
            labelinfoProfile.Name = "labelinfoProfile";
            labelinfoProfile.Size = new Size(294, 15);
            labelinfoProfile.TabIndex = 34;
            labelinfoProfile.Text = "This will be your default profile picture if you don't set ";
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Anchor = AnchorStyles.None;
            pictureBoxProfile.Image = Properties.Resources.istockphoto_1130884625_612x612;
            pictureBoxProfile.Location = new Point(491, 206);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(131, 110);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 33;
            pictureBoxProfile.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ebrima", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(409, 180);
            label4.Name = "label4";
            label4.Size = new Size(315, 23);
            label4.TabIndex = 32;
            label4.Text = "Set a profile picture to people know you";
            // 
            // textBoxRealName
            // 
            textBoxRealName.BackColor = Color.BlueViolet;
            textBoxRealName.BorderStyle = BorderStyle.None;
            textBoxRealName.Cursor = Cursors.Hand;
            textBoxRealName.Font = new Font("Ebrima", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRealName.ForeColor = Color.White;
            textBoxRealName.Location = new Point(83, 252);
            textBoxRealName.Name = "textBoxRealName";
            textBoxRealName.Size = new Size(250, 20);
            textBoxRealName.TabIndex = 31;
            textBoxRealName.Text = "Enter your name";
            textBoxRealName.Click += textBoxRealName_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Location = new Point(83, 279);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(250, 2);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 203);
            label3.Name = "label3";
            label3.Size = new Size(282, 17);
            label3.TabIndex = 29;
            label3.Text = "Your real name will display with your username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 180);
            label2.Name = "label2";
            label2.Size = new Size(326, 23);
            label2.TabIndex = 28;
            label2.Text = "Enter your real name to people know you";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(192, 134);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 27;
            label1.Text = "Welcome !";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOKk
            // 
            buttonOKk.BackColor = Color.DarkBlue;
            buttonOKk.FlatStyle = FlatStyle.Flat;
            buttonOKk.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOKk.ForeColor = Color.White;
            buttonOKk.Location = new Point(358, 371);
            buttonOKk.Name = "buttonOKk";
            buttonOKk.Size = new Size(80, 46);
            buttonOKk.TabIndex = 37;
            buttonOKk.Text = "OK";
            buttonOKk.UseVisualStyleBackColor = false;
            buttonOKk.Click += buttonOKk_Click;
            // 
            // NewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            Controls.Add(buttonOKk);
            Controls.Add(label5);
            Controls.Add(buttonPicture);
            Controls.Add(labelinfoProfile);
            Controls.Add(pictureBoxProfile);
            Controls.Add(label4);
            Controls.Add(textBoxRealName);
            Controls.Add(kryptonPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewUser";
            Size = new Size(775, 570);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button buttonPicture;
        private Label labelinfoProfile;
        private PictureBox pictureBoxProfile;
        private Label label4;
        private TextBox textBoxRealName;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button buttonOKk;
    }
}
