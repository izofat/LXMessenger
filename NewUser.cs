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
    public partial class NewUser : UserControl
    {
        public NewUser()
        {
            InitializeComponent();

        }
        private string username;
        public string Username { get => username; set => username = value; }
        private void buttonPicture_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            DialogResult result = openFileDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                pictureBoxProfile.ImageLocation = openFileDialog1.FileName;

            }
        }

        int p = 0;
        private void textBoxRealName_Click(object sender, EventArgs e)
        {
            p++;
            if (p == 1)
            {
                textBoxRealName.Clear();
            }
        }

        private void buttonOKk_Click(object sender, EventArgs e)
        {


            byte[] imagedata = File.ReadAllBytes(pictureBoxProfile.ImageLocation);
            if (textBoxRealName.Text != "")
            {
                string realname = textBoxRealName.Text.ToString();

                Actions.SetNewUser(username, realname, imagedata);
            }
            else
            {
                label5.Text = "Please enter your name";
            }

        }
    }
}
