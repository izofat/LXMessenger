using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LXMessenger
{

    public partial class ChatControl : UserControl
    {

        #region startup
        private string usernameget;
        public string Usernameget
        {
            get => usernameget;
            set => usernameget = value;
        }
        private string theirusernameget;
        public string Theirusernameget
        {
            get => theirusernameget;
            set => theirusernameget = value;
        }
        private int xlocus;

        private int xloclabelus = 683;
        private int xlocdateus = 592;
        private int xlocdatethem;
        private int ylocmessage;
        private int ylocdate;
        int yloc = 0;
        private int xsizeofimage = 0;
        private int ysizeofimage = 0;
        int count;
        public ChatControl(string username, string theirusername)
        {
            InitializeComponent();

            Theirusernameget = theirusername;
            Usernameget = username;
            ShowMessages();
            timerchatcontrol.Start();
        }
        #endregion        
        List<ChatMessage> oldmessages = new List<ChatMessage>();
        private void ShowMessages()
        {
            int chatroomid = Actions.GetChatRoomId(Usernameget, Theirusernameget);
            var messages = Actions.ShowMessages(Usernameget, Theirusernameget, chatroomid);
            bool stat = CheckListEqual(messages, oldmessages);

            if (!stat)
            {
                List<ChatMessage> newmessages = FindNewMessages(messages, oldmessages);
                foreach (var message in newmessages)
                {

                    xlocus = 575;
                    xloclabelus = 700;
                    xlocdateus = 620;
                    xsizeofimage = 150;
                    xlocdatethem = 6;
                    int line = 1;
                    string textmesage = "";
                    PictureBox pictureboxmesage = new PictureBox();
                    pictureboxmesage.SizeMode = PictureBoxSizeMode.StretchImage;
                    System.Windows.Forms.Label textmessagelabel = new System.Windows.Forms.Label();
                    System.Windows.Forms.Label textdatelabel = new System.Windows.Forms.Label();
                    if (message.SentBy == Theirusernameget)
                    {
                        pictureboxmesage.Image = Properties.Resources.sol;
                        pictureboxmesage.Location = new Point(0, yloc);

                        int numofchars = 0;
                        foreach (char c in message.Message)
                        {
                            textmesage += c.ToString();
                            numofchars++;
                            if (numofchars <= 55)
                            {
                                xsizeofimage += 6;
                                xlocdatethem += 5;
                            }
                            if (numofchars == 55 && message.Message[message.Message.Length - 1] != c)
                            {
                                if (c.ToString() != " ")
                                {
                                    textmesage += "-";
                                }
                                textmesage += "\n";
                                line++;
                            }
                        }
                        switch (line)
                        {
                            case 1:
                                ysizeofimage = 74;
                                ylocmessage = yloc + 25;
                                ylocdate = ylocmessage + 15;
                                yloc += ysizeofimage - 20;
                                break;
                            case 2:
                                ysizeofimage = 114;
                                ylocmessage = yloc + 34;
                                ylocdate = ylocmessage + 35;
                                yloc += ysizeofimage - 24;
                                break;
                            case 3:
                                ysizeofimage = 160;
                                ylocmessage = yloc + 47;
                                ylocdate = ylocmessage + 52;
                                yloc += ysizeofimage - 28;
                                break;
                            case 4:
                                ysizeofimage = 195;
                                ylocmessage = yloc + 57;
                                ylocdate = ylocmessage + 69;
                                ylocmessage += ysizeofimage - 32;
                                break;
                        }
                        pictureboxmesage.Size = new Size(xsizeofimage, ysizeofimage);
                        pictureboxmesage.Name = "pictureboxmessage" + count.ToString();
                        panelChatlog.Controls.Add(pictureboxmesage);
                        pictureboxmesage.BringToFront();
                        //
                        textmessagelabel.AutoSize = true;
                        textmessagelabel.Font = new Font("Corbel", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        textmessagelabel.BackColor = Color.FromArgb(41, 41, 42);
                        textmessagelabel.ForeColor = Color.White;
                        textmessagelabel.Name = "mesagelabel" + count.ToString();
                        textmessagelabel.Text = textmesage;
                        textmessagelabel.Location = new Point(22, ylocmessage);
                        panelChatlog.Controls.Add(textmessagelabel);
                        textmessagelabel.BringToFront();
                        //
                        textdatelabel.AutoSize = true;
                        textdatelabel.BackColor = Color.FromArgb(41, 41, 42);
                        textdatelabel.Font = new Font("Segoe UI", 7.6F, FontStyle.Regular, GraphicsUnit.Point);
                        textdatelabel.ForeColor = Color.FromArgb(224, 224, 224);
                        textdatelabel.Name = "datelabel" + count.ToString();
                        textdatelabel.Text = message.Date.ToString();
                        textdatelabel.Location = new Point(xlocdatethem, ylocdate);
                        panelChatlog.Controls.Add(textdatelabel);
                        textdatelabel.BringToFront();
                    }
                    else if (message.SentBy == Usernameget)
                    {
                        pictureboxmesage.Image = Properties.Resources.sag;

                        int numofchars = 0;
                        foreach (char c in message.Message)
                        {
                            textmesage += c.ToString();
                            numofchars++;
                            if (numofchars <= 55)
                            {
                                xsizeofimage += 4;
                                xlocus -= 4;
                                xloclabelus -= 6;
                                xlocdateus -= 5;
                            }
                            if (numofchars == 55 && message.Message[message.Message.Length - 1] != c)
                            {
                                if (c.ToString() != " ")
                                {
                                    textmesage += "-";
                                }
                                textmesage += "\n";
                                line++;
                            }
                        }
                        pictureboxmesage.Location = new Point(xlocus, yloc);


                        switch (line)
                        {
                            case 1:
                                ysizeofimage = 74;
                                ylocmessage = yloc + 25;
                                ylocdate = ylocmessage + 15;
                                yloc += ysizeofimage - 20;
                                break;
                            case 2:
                                ysizeofimage = 114;
                                ylocmessage = yloc + 34;
                                ylocdate = ylocmessage + 35;
                                yloc += ysizeofimage - 24;
                                break;
                            case 3:
                                ysizeofimage = 160;
                                ylocmessage = yloc + 47;
                                ylocdate = ylocmessage + 52;
                                yloc += ysizeofimage - 28;
                                break;
                            case 4:
                                ysizeofimage = 195;
                                ylocmessage = yloc + 57;
                                ylocdate = ylocmessage + 69;
                                ylocmessage += ysizeofimage - 32;
                                break;
                        }
                        pictureboxmesage.Size = new Size(xsizeofimage, ysizeofimage);
                        pictureboxmesage.Name = "pictureboxmessage" + count.ToString();
                        panelChatlog.Controls.Add(pictureboxmesage);
                        pictureboxmesage.BringToFront();
                        //
                        textmessagelabel.AutoSize = true;
                        textmessagelabel.Font = new Font("Corbel", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        textmessagelabel.BackColor = Color.FromArgb(0, 80, 70);
                        textmessagelabel.ForeColor = Color.White;
                        textmessagelabel.Location = new Point(xloclabelus, ylocmessage);
                        textmessagelabel.Name = "mesagelabel" + count.ToString();
                        textmessagelabel.Text = textmesage;
                        panelChatlog.Controls.Add(textmessagelabel);
                        textmessagelabel.BringToFront();

                        //
                        textdatelabel.AutoSize = true;
                        textdatelabel.BackColor = Color.FromArgb(0, 80, 70);
                        textdatelabel.Font = new Font("Segoe UI", 7.6F, FontStyle.Regular, GraphicsUnit.Point);
                        textdatelabel.ForeColor = Color.FromArgb(224, 224, 224);
                        textdatelabel.Location = new Point(xlocdateus, ylocdate);
                        textdatelabel.Name = "datelabel" + count.ToString();
                        string date = "";
                        date += message.Date.Day;
                        date += "/" + message.Date.Month;
                        date += "/" + message.Date.Year;
                        date += " " + message.Date.Hour;
                        date += "." + message.Date.Minute;

                        textdatelabel.Text = date;
                        panelChatlog.Controls.Add(textdatelabel);
                        textdatelabel.BringToFront();

                    }
                    count++;
                }
            }
            oldmessages = messages;
        }
        private bool CheckListEqual(List<ChatMessage> newmessages, List<ChatMessage> oldmessages)
        {

            if (oldmessages == null || newmessages == null || newmessages.Count != oldmessages.Count)
            {
                return false;
            }
            for (int i = 0; i < newmessages.Count; i++)
            {
                ChatMessage messagenew = newmessages[i];
                ChatMessage messageold = oldmessages[i];
                if (messagenew.Message != messageold.Message ||
                    messagenew.Date != messageold.Date ||
                    messagenew.SentBy != messageold.SentBy)
                {
                    return false;
                }
            }
            return true;
        }
        private List<ChatMessage> FindNewMessages(List<ChatMessage> nownewmessages, List<ChatMessage> newoldmessages)
        {
            List<ChatMessage> differentrows = new List<ChatMessage>();
            int index;
            if (newoldmessages.Count == 0)
            {
                index = 0;
            }
            else
            {
                index = newoldmessages.Count;
            }
             
            for (; index < nownewmessages.Count; index++)
            {
                differentrows.Add(nownewmessages[index]);
            }
            return differentrows;
        }
        private void timerchatcontrol_Tick(object sender, EventArgs e)
        {
            ShowMessages();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string message = textBoxmessagetosent.Text;
            if (message != "")
            {
                DateTime timenow = DateTime.Now;
                int roomid = Actions.GetChatRoomId(usernameget, theirusernameget);
                Actions.SendMessages(usernameget, theirusernameget, message, timenow, roomid);
                textBoxmessagetosent.Clear();
            }                      
        }
    }
    public class Oldmessageslist
    {
        public string Message { get; set; }
        public string SentBy { get; set; }
        public DateTime Date { get; set; }
    }
}
