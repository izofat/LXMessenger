using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using LXMessenger.Properties;
using System.Drawing.Imaging;

namespace LXMessenger
{
    public partial class Messenger : Form
    {
        private string username = "";
        public string Username { get => username; set => username = value; }
        public Messenger(string usernamed)
        {
            InitializeComponent();
            if (Actions.CheckNewUser(usernamed) == DBNull.Value)
            {
                NewUser newuser = new NewUser();
                newuser.Username = usernamed;
                panelMain.Controls.Add(newuser);
                panelMain.BringToFront();
                timer1.Start();
            }
            else
            {
                LogInStartedUs(usernamed);
            }
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Form formstartup = Application.OpenForms["StartUp"];
            if (formstartup != null)
            {
                formstartup.Close();
                this.Close();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Actions.CheckNewUser(username) != DBNull.Value)
            {
                panelMain.Controls.Clear();
                timer1.Stop();
                LogInStartedUs(username);
            }
        }

        private void LogInStartedUs(string user)
        {
            panelProfile.Visible = true;
            object realname;
            byte[] profilepicture;
            Actions.GetEverything(user, out realname, out profilepicture);
            if (profilepicture != null)
            {
                using (MemoryStream memory = new MemoryStream(profilepicture))
                {
                    try
                    {
                        memory.Position = 0;
                        Image image = Image.FromStream(memory);
                        pictureBoxProfile.Image = image;
                    }
                    catch (Exception ea)
                    {
                        MessageBox.Show(ea.Message);
                    }
                }
            }

            labelRealname.Text = "Welcome ";
            labelUsername.Text = "@";
            labelRealname.Text += realname.ToString();
            labelUsername.Text += user;

            List<string> allfriends = Actions.GetFriends(user);
            if (allfriends.Any() == false)
            {

                buttonAddFriend.PerformClick();
                panelChat.Visible = true;
            }
            else
            {
                ShowFriends(user);
            }
        }

        List<string> oldfriends = null;
        Button[] chatbuttonfriend;

        private void ShowFriends(string user)
        {
            List<string> allfriends = Actions.GetFriends(user);
            if (chatbuttonfriend != null && allfriends != oldfriends)
            {
                panelFriends.Controls.Clear();
            }
            Button buttonrefresh = new Button();
            buttonrefresh.BackColor = Color.DeepSkyBlue;
            buttonrefresh.BackgroundImage = Properties.Resources.refresh;
            buttonrefresh.BackgroundImageLayout = ImageLayout.Zoom;
            buttonrefresh.FlatAppearance.BorderSize = 0;
            buttonrefresh.FlatStyle = FlatStyle.Flat;
            buttonrefresh.Location = new Point(250, 3);
            buttonrefresh.Name = "buttonrefresh";
            buttonrefresh.Size = new Size(42, 34);
            buttonrefresh.TabIndex = 1;
            buttonrefresh.UseVisualStyleBackColor = false;
            buttonrefresh.Click += (s, e) => buttonrefresh_Click(s, e);
            panelFriends.Controls.Add(buttonrefresh);


            chatbuttonfriend = new Button[allfriends.Count];

            int i = 0;
            panelChat.Visible = true;
            panelChat.BringToFront();
            panelFriends.Visible = true;
            panelFriends.BringToFront();

            foreach (string friend in allfriends)
            {
                object realnamefriend;
                byte[] imagefriend;
                Actions.GetEverything(friend, out realnamefriend, out imagefriend);
                chatbuttonfriend[i] = new Button();
                using (MemoryStream memory = new MemoryStream(imagefriend))
                {
                    memory.Position = 0;
                    Image image = Image.FromStream(memory);
                    Image resizedimage = new Bitmap(image, new Size(60, 60));
                    chatbuttonfriend[i].Image = resizedimage;
                }
                chatbuttonfriend[i].Dock = DockStyle.Top;
                chatbuttonfriend[i].FlatStyle = FlatStyle.Flat;
                chatbuttonfriend[i].FlatAppearance.BorderSize = 0;
                chatbuttonfriend[i].Font = new Font("Consolas", 14, FontStyle.Bold, GraphicsUnit.Point);
                chatbuttonfriend[i].BackColor = Color.DeepSkyBlue;
                chatbuttonfriend[i].ForeColor = Color.White;
                chatbuttonfriend[i].ImageAlign = ContentAlignment.MiddleLeft;
                chatbuttonfriend[i].Name = "buttonchatfriend" + i.ToString();
                chatbuttonfriend[i].Size = new Size(319, 60);
                chatbuttonfriend[i].Location = new Point(0, 0);
                chatbuttonfriend[i].Text = $"  {friend}";
                chatbuttonfriend[i].TextAlign = ContentAlignment.MiddleLeft;
                chatbuttonfriend[i].TextImageRelation = TextImageRelation.ImageBeforeText;
                chatbuttonfriend[i].Click += (s, ev) => ChatWithFriend(s, ev, friend);
                panelFriends.Controls.Add(chatbuttonfriend[i]);
                i++;
            }
            oldfriends = allfriends;
            buttonrefresh.BringToFront();
        }
        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            ShowFriends(username);
        }

        private void ChatWithFriend(object sender, EventArgs e, string friend)
        {


            panelMain.Controls.Clear();
            object chatrealname;
            byte[] chatprofilepicture;
            Actions.GetEverything(friend, out chatrealname, out chatprofilepicture);
            pictureBoxFriend.Visible = true;
            labelnamefriend.Visible = true;
            labelChatUsername.Visible = true;
            using (MemoryStream memory = new MemoryStream(chatprofilepicture))
            {
                memory.Position = 0;
                Image chatimage = Image.FromStream(memory);
                pictureBoxFriend.Image = chatimage;
            }
            labelnamefriend.Text = $"You are chatting with {chatrealname}";
            labelChatUsername.Text = $"@{friend}";

            ChatControl chat = new ChatControl(username, friend);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(chat);
        }
        private void buttonAddFriend_Click(object sender, EventArgs e)
        {
            AddFriend addfriend = new AddFriend();
            addfriend.Username = username;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(addfriend);
            panelMain.BringToFront();
            labelChatUsername.Visible = false;
            labelnamefriend.Visible = false;
            pictureBoxFriend.Visible = false;
        }
        int cpq = 0;
        List<string> oldfriends2;
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            cpq++;
            if (cpq == 1)
            {
                textBoxUsername.Clear();
            }
            List<string> friends;
            string text = textBoxUsername.Text;
            Actions.GetFriendWithSearch(username, text, out friends);
            if (textBoxUsername.Text == "")
            {
                oldfriends2.Clear();

            }

            if (friends != oldfriends2 && textBoxUsername.Text != "Click Here To Search")
            {
                Button buttonrefresh = new Button();
                buttonrefresh.BackColor = Color.DeepSkyBlue;
                buttonrefresh.BackgroundImage = Properties.Resources.refresh;
                buttonrefresh.BackgroundImageLayout = ImageLayout.Zoom;
                buttonrefresh.FlatAppearance.BorderSize = 0;
                buttonrefresh.FlatStyle = FlatStyle.Flat;
                buttonrefresh.Location = new Point(220, 3);
                buttonrefresh.Name = "buttonrefresh";
                buttonrefresh.Size = new Size(42, 34);
                buttonrefresh.TabIndex = 1;
                buttonrefresh.UseVisualStyleBackColor = false;
                buttonrefresh.Click += (s, e) => buttonrefresh_Click(s, e);
                panelFriends.Controls.Add(buttonrefresh);
                panelFriends.Controls.Clear();
                int i = 0;
                panelChat.Visible = true;
                foreach (string friend in friends)
                {

                    object realnamefriend;
                    byte[] imagefriend;
                    Actions.GetEverything(friend, out realnamefriend, out imagefriend);
                    chatbuttonfriend[i] = new Button();
                    using (MemoryStream memory = new MemoryStream(imagefriend))
                    {
                        memory.Position = 0;
                        Image image = Image.FromStream(memory);
                        Image resizedimage = new Bitmap(image, new Size(60, 60));
                        chatbuttonfriend[i].Image = resizedimage;
                    }
                    chatbuttonfriend[i].Dock = DockStyle.Top;
                    chatbuttonfriend[i].FlatStyle = FlatStyle.Flat;
                    chatbuttonfriend[i].FlatAppearance.BorderSize = 0;
                    chatbuttonfriend[i].Font = new Font("Consolas", 14, FontStyle.Bold, GraphicsUnit.Point);
                    chatbuttonfriend[i].BackColor = Color.DeepSkyBlue;
                    chatbuttonfriend[i].ForeColor = Color.White;
                    chatbuttonfriend[i].ImageAlign = ContentAlignment.MiddleLeft;
                    chatbuttonfriend[i].Name = "buttonchatfriend" + i.ToString();
                    chatbuttonfriend[i].Size = new Size(325, 60);
                    chatbuttonfriend[i].Text = $"  {friend}";
                    chatbuttonfriend[i].TextAlign = ContentAlignment.MiddleLeft;
                    chatbuttonfriend[i].TextImageRelation = TextImageRelation.ImageBeforeText;
                    chatbuttonfriend[i].Click += (s, ev) => ChatWithFriend(s, ev, friend);
                    panelFriends.Controls.Add(chatbuttonfriend[i]);
                }
                buttonrefresh.BringToFront();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            labelnamefriend.Visible = false;
            labelChatUsername.Visible = false;
            pictureBoxFriend.Visible = false;
            panelMain.Controls.Clear();
            Settings settings = new Settings(username);
            panelMain.Controls.Add(settings);
        }
    }
}
