using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
namespace LXMessenger
{
    public partial class AddFriend : UserControl
    {
        public AddFriend()
        {
            InitializeComponent();
        }
        private string username;
        public string Username { get => username; set => username = value; }
        int cl = 0;
        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            cl++;
            if (cl == 1)
            {
                textBoxUsername.Clear();
            }
        }
        Button[] userbuttons;
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                panelUsers.Controls.Clear();
                groupBoxInfos.Visible = false;
            }
            if (textBoxUsername.Text != null && textBoxUsername.Text != "" && textBoxUsername.Text != "Click Here To Search")
            {
                string text = textBoxUsername.Text.ToString();
                List<string> users;
                List<string> usernames;

                Actions.SearchFriends(username, text, out users, out usernames);
                panelUsers.Controls.Clear();
                List<string> oldfriends = null;
                userbuttons = new Button[users.Count];
                if (users != null && oldfriends != usernames)
                {
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (usernames[i] != username && i < users.Count && i < usernames.Count)
                        {
                            int capturedint = i;
                            userbuttons[i] = new Button();
                            userbuttons[i].Name = "user" + i.ToString();
                            userbuttons[i].BackColor = Color.DodgerBlue;
                            userbuttons[i].Dock = DockStyle.Top;
                            userbuttons[i].FlatAppearance.BorderSize = 0;
                            userbuttons[i].FlatStyle = FlatStyle.Flat;
                            userbuttons[i].Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
                            userbuttons[i].ForeColor = Color.White;
                            userbuttons[i].Size = new Size(253, 55);
                            userbuttons[i].TextAlign = ContentAlignment.MiddleLeft;
                            userbuttons[i].Cursor = Cursors.Hand;
                            userbuttons[i].Text = users[i];
                            userbuttons[i].Click += (s, e) => UserSelected(s, e, usernames[capturedint], userbuttons[capturedint]);
                            panelUsers.Controls.Add(userbuttons[i]);
                        }

                    }
                }
                oldfriends = usernames;
            }
        }
        private void UserSelected(object sender, EventArgs e, string theirusername, Button userbutton)
        {
            if (userbuttons != null)
            {
                foreach (Button b in userbuttons)
                {
                    b.Font = new Font("Ebrima", 10F, FontStyle.Bold, GraphicsUnit.Point);
                    b.BackColor = Color.DodgerBlue;
                }
            }

            userbutton.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userbutton.BackColor = Color.DarkBlue;
            groupBoxInfos.Visible = true;
            //
            object realname;
            byte[] imagecode;
            Actions.GetEverything(theirusername, out realname, out imagecode);
            if (imagecode != null)
            {
                using (MemoryStream memory = new MemoryStream(imagecode))
                {
                    memory.Position = 0;
                    Image image = Image.FromStream(memory);
                    pictureBoxProfile.Image = image;

                }
            }
            labelusername.Text = "Username : ";
            labelrealname.Text = "Real name : ";
            labelusername.Text += theirusername;
            labelrealname.Text += realname;
            //
            string stat;
            object result;
            Actions.CheckFriendShip(username, theirusername, out stat, out result);


            if (result == null && stat == "")
            {               
                buttonaddfriend.Visible = true;
                buttoncancel.Visible = false;
                buttonaccept.Visible = false;
                labelinfofriend.Text = "You are not friends with this user";
            }
            else if (result.ToString() == "Waiting" && stat == "we sent")
            {
                
                buttonaccept.Visible = false;
                buttoncancel.Visible = false;
                buttonaddfriend.Visible = false;
                labelinfofriend.Text = "Friend request sent and waiting for action";
            }
            else if (result.ToString() == "Accepted" && stat == "we sent")
            {
                
                buttonaddfriend.Visible = false;
                buttoncancel.Visible = false;
                buttonaccept.Visible = false;
                labelinfofriend.Text = "Friend request accepted you can start chat now";
            }
            else if (result.ToString() == "Rejected" && stat == "we sent")
            {
               
                buttonaccept.Visible = false;
                buttoncancel.Visible = false;
                buttonaddfriend.Visible = false;
                labelinfofriend.Text = "This user rejected your friend request\nHim should send you friend request to be friend";
            }
            else if (result.ToString() == "Waiting" && stat == "they sent")
            {
                buttonaccept.Visible = true;
                buttoncancel.Visible = true;
                buttonaddfriend.Visible = false;
                labelinfofriend.Text = "This user sent you a friend request";
            }
            else if (result.ToString() == "Accepted" && stat == "they sent")
            {
                
                buttonaddfriend.Visible = false;
                buttoncancel.Visible = false;
                buttonaddfriend.Visible = false;
                labelinfofriend.Text = "You accepted this user's friend request you can chat";

            }
            else if (result.ToString() == "Rejected" && stat == "they sent")
            {
                
                buttonaddfriend.Visible = true;
                buttonaccept.Visible = false;
                buttoncancel.Visible = false;
                labelinfofriend.Text = "You rejected this friend request\nYou should add him first to become friends";
            }
        }
        private void buttonaccept_Click(object sender, EventArgs e)
        {
            string sentto = labelusername.Text.Substring(11, labelusername.Text.Length - 11);
            Actions.UpdateFriendRequest(username, sentto, "Accepted");
            buttonaccept.Visible = false;
            buttoncancel.Visible = false;
            labelinfofriend.Text = "Friend request accepted";
        }
        private void buttonaddfriend_Click(object sender, EventArgs e)
        {
            string sentto = labelusername.Text.Substring(11, labelusername.Text.Length - 11);
            Actions.CreateFriendRequest(username, sentto);
            buttonaddfriend.Visible = false;
            labelinfofriend.Text = "Friend request sent";
        }
        private void buttoncancel_Click(object sender, EventArgs e)
        {
            string sentto = labelusername.Text.Substring(11, labelusername.Text.Length - 11);
            buttonaccept.Visible = false;
            buttoncancel.Visible = false;
            Actions.UpdateFriendRequest(username, sentto, "Rejected");
            labelinfofriend.Text = "Friend request rejected";
        }
    }
}
