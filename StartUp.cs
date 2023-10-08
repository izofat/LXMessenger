using System.Drawing;
namespace LXMessenger
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();


        }
        private int i = 0;
        private void buttonchangeview_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 1)
            {
                textBoxPassword.PasswordChar = '\0';

                buttonchangeview.Image = Properties.Resources.unshow;
            }
            else if (i % 2 == 0)
            {
                textBoxPassword.PasswordChar = '*';
                buttonchangeview.Image = Properties.Resources.show;
            }
        }
        private string action = "log in";

        private void linkLabelAction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (action == "log in")
            {
                action = "register";
                buttonAction.Text = "Register";
                labelActioninfo.Text = "Already have an account ?";
                linkLabelAction.Text = "Log In";
            }
            else if (action == "register")
            {
                action = "log in";
                buttonAction.Text = "Log In";
                labelActioninfo.Text = "Don't have an account ?";
                linkLabelAction.Text = "Register";
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void buttonMinimal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool statusername = false;

        private bool active = false;


        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (action == "register")
            {
                statusername = false;
                pictureBoxUsernameTick.Visible = false;
                toolTipMessageUsername.Hide(textBoxUserName);
                toolTipMessageUsername.IsBalloon = true;
                toolTipMessageUsername.ToolTipIcon = ToolTipIcon.Warning;
                toolTipMessageUsername.ToolTipTitle = "Unusable username";
                if (textBoxUserName.TextLength < 6 && textBoxUserName.Text != "" && textBoxUserName.Text != null)
                {
                    toolTipMessageUsername.Show("Username minimum length is 6", textBoxUserName, 0, textBoxUserName.Height - 88, 1200);
                }
                else if (textBoxUserName.Text != "" && textBoxUserName.Text != null)
                {
                    if (active == true)
                    {
                        return;
                    }
                    active = true;
                    timer1.Start();
                    string username = textBoxUserName.Text;
                    if (Actions.CheckUsernameExist(username) > 0)
                    {
                        toolTipMessageUsername.Show("This username is already exist try something else", textBoxUserName, 0, textBoxUserName.Height - 100, 1200);
                    }
                    else
                    {
                        toolTipMessageUsername.Hide(textBoxUserName);
                        pictureBoxUsernameTick.Visible = true;
                        statusername = true;
                    }
                    active = false;
                }
            }

        }
        bool statpassword = false;
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (action == "register" && textBoxPassword.Text != "")
            {
                statpassword = false;
                pictureBoxPasswordTick.Visible = false;
                toolTipMessagePassword.Hide(textBoxPassword);
                toolTipMessagePassword.IsBalloon = true;
                toolTipMessagePassword.ToolTipIcon = ToolTipIcon.Warning;
                toolTipMessagePassword.ToolTipTitle = "Unusable Password";
                if (textBoxPassword.TextLength < 6)
                {
                    toolTipMessagePassword.Show("Password minimum length is 6", textBoxPassword, 0, textBoxPassword.Height - 93, 1200);
                }
                else if (!textBoxPassword.Text.Any(char.IsLetter))
                {
                    toolTipMessagePassword.Show("Password must contain at least one letter", textBoxPassword, 0, textBoxPassword.Height - 93, 1200);
                }
                else if (!textBoxPassword.Text.Any(char.IsNumber))
                {
                    toolTipMessagePassword.Show("Password must contain at least one number", textBoxPassword, 0, textBoxPassword.Height - 93, 1200);
                }
                else if (textBoxPassword.Text.Any(char.IsLetter) == true &&
                         textBoxPassword.Text.Any(char.IsNumber) == true &&
                         textBoxPassword.Text.Length >= 6)
                {
                    statpassword = true;
                    pictureBoxPasswordTick.Visible = true;
                }
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.ToString();
            string password = textBoxPassword.Text.ToString();
            if (action == "register" && statpassword == true && statusername == true)
            {

                if (Actions.RegisterAccount(username, password) == true)
                {
                    labelSuccess.Visible = true;
                    labelSuccess.Text = "Account successfully created";

                    textBoxPassword.Clear();
                    textBoxUserName.Clear();
                }
            }
            if (action == "log in" && Actions.LoginAccount(username, password) == true)
            {
                Messenger messenger = new Messenger(username);
                messenger.Username = username;
                messenger.Show();
                this.Hide();

            }
            else if (action == "log in" && Actions.LoginAccount(username, password) == false)
            {
                labelSuccess.Visible = true;
                labelSuccess.Text = "Username or password is wrong";
                labelSuccess.ForeColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}