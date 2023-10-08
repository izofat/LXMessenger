using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LXMessenger
{
    public partial class Settings : UserControl
    {
        private string username;
        private Image userprofilepicture;
        public Settings(string usernameget)
        {
            InitializeComponent();
            username = usernameget;
            object realname;
            byte[] profilebyte;
            Actions.GetEverything(username, out realname, out profilebyte);
            using (MemoryStream memory = new MemoryStream(profilebyte))
            {
                memory.Position = 0;
                Image image = Image.FromStream(memory);
                userprofilepicture = image;
                pictureBoxSettingsprofile.Image = image;
            }
            labelusername.Text += username;
            textBoxrealname.Text = (string)realname;
        }

        private void buttonSetProfile_Click(object sender, EventArgs e)
        {
            //byte[] newpicture = File.ReadAllBytes(pictureBoxSettingsprofile.ImageLocation);
            string newrealname = textBoxrealname.Text;
            if (newrealname == "")
            {
                MessageBox.Show("Enter your name");
            }

            else if (newrealname != "")
            {
                Actions.UpdateUser(username, newrealname);
                label1.Visible = true;
            }

        }


    }
}
