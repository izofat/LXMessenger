namespace LXMessenger
{
    partial class Settings
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
            pictureBoxSettingsprofile = new PictureBox();
            labelusername = new Label();
            labelRealname = new Label();
            textBoxrealname = new TextBox();
            buttonSetProfile = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettingsprofile).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxSettingsprofile
            // 
            pictureBoxSettingsprofile.Location = new Point(286, 59);
            pictureBoxSettingsprofile.Name = "pictureBoxSettingsprofile";
            pictureBoxSettingsprofile.Size = new Size(244, 204);
            pictureBoxSettingsprofile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSettingsprofile.TabIndex = 0;
            pictureBoxSettingsprofile.TabStop = false;
            // 
            // labelusername
            // 
            labelusername.AutoSize = true;
            labelusername.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelusername.ForeColor = Color.WhiteSmoke;
            labelusername.Location = new Point(222, 308);
            labelusername.Name = "labelusername";
            labelusername.Size = new Size(85, 20);
            labelusername.TabIndex = 1;
            labelusername.Text = "Username : ";
            // 
            // labelRealname
            // 
            labelRealname.AutoSize = true;
            labelRealname.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRealname.ForeColor = Color.WhiteSmoke;
            labelRealname.Location = new Point(222, 369);
            labelRealname.Name = "labelRealname";
            labelRealname.Size = new Size(87, 20);
            labelRealname.TabIndex = 2;
            labelRealname.Text = "Real Name : ";
            // 
            // textBoxrealname
            // 
            textBoxrealname.BackColor = Color.RosyBrown;
            textBoxrealname.BorderStyle = BorderStyle.None;
            textBoxrealname.Cursor = Cursors.Hand;
            textBoxrealname.Font = new Font("Impact", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxrealname.ForeColor = Color.Black;
            textBoxrealname.Location = new Point(306, 369);
            textBoxrealname.MaxLength = 30;
            textBoxrealname.Name = "textBoxrealname";
            textBoxrealname.Size = new Size(236, 21);
            textBoxrealname.TabIndex = 3;
            // 
            // buttonSetProfile
            // 
            buttonSetProfile.BackColor = Color.PeachPuff;
            buttonSetProfile.FlatAppearance.BorderColor = Color.Black;
            buttonSetProfile.FlatStyle = FlatStyle.Flat;
            buttonSetProfile.Font = new Font("Impact", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSetProfile.ForeColor = Color.Black;
            buttonSetProfile.Location = new Point(359, 424);
            buttonSetProfile.Name = "buttonSetProfile";
            buttonSetProfile.Size = new Size(91, 43);
            buttonSetProfile.TabIndex = 4;
            buttonSetProfile.Text = "SET";
            buttonSetProfile.UseVisualStyleBackColor = false;
            buttonSetProfile.Click += buttonSetProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(320, 485);
            label1.Name = "label1";
            label1.Size = new Size(191, 19);
            label1.TabIndex = 6;
            label1.Text = "User updated successfully.";
            label1.Visible = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            Controls.Add(label1);
            Controls.Add(buttonSetProfile);
            Controls.Add(textBoxrealname);
            Controls.Add(labelRealname);
            Controls.Add(labelusername);
            Controls.Add(pictureBoxSettingsprofile);
            Name = "Settings";
            Size = new Size(767, 550);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettingsprofile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxSettingsprofile;
        private Label labelusername;
        private Label labelRealname;
        private TextBox textBoxrealname;
        private Button buttonSetProfile;
        private Label label1;
    }
}
