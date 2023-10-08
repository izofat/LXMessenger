namespace LXMessenger
{
    partial class ChatControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatControl));
            textBoxmessagetosent = new TextBox();
            panel1 = new Panel();
            buttonSend = new Button();
            panelChatlog = new Panel();
            timerchatcontrol = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBoxmessagetosent
            // 
            textBoxmessagetosent.BackColor = Color.Purple;
            textBoxmessagetosent.BorderStyle = BorderStyle.None;
            textBoxmessagetosent.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxmessagetosent.ForeColor = SystemColors.Info;
            textBoxmessagetosent.Location = new Point(64, 470);
            textBoxmessagetosent.MaxLength = 114;
            textBoxmessagetosent.Multiline = true;
            textBoxmessagetosent.Name = "textBoxmessagetosent";
            textBoxmessagetosent.Size = new Size(581, 52);
            textBoxmessagetosent.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(64, 518);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 4);
            panel1.TabIndex = 1;
            // 
            // buttonSend
            // 
            buttonSend.BackgroundImage = (Image)resources.GetObject("buttonSend.BackgroundImage");
            buttonSend.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSend.Cursor = Cursors.Hand;
            buttonSend.FlatAppearance.BorderSize = 0;
            buttonSend.FlatStyle = FlatStyle.Flat;
            buttonSend.Location = new Point(665, 470);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(41, 39);
            buttonSend.TabIndex = 2;
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // panelChatlog
            // 
            panelChatlog.Location = new Point(19, 19);
            panelChatlog.Name = "panelChatlog";
            panelChatlog.Size = new Size(745, 440);
            panelChatlog.TabIndex = 3;
            // 
            // timerchatcontrol
            // 
            timerchatcontrol.Interval = 4000;
            timerchatcontrol.Tick += timerchatcontrol_Tick;
            // 
            // ChatControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            Controls.Add(panelChatlog);
            Controls.Add(buttonSend);
            Controls.Add(panel1);
            Controls.Add(textBoxmessagetosent);
            DoubleBuffered = true;
            Name = "ChatControl";
            Size = new Size(767, 550);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxmessagetosent;
        private Panel panel1;
        private Button buttonSend;
        private Panel panelChatlog;
        private System.Windows.Forms.Timer timerchatcontrol;
    }
}
