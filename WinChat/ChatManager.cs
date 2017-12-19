using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web.Helpers;

namespace WinChat
{
    public partial class ChatManager : Form
    {
        public ChatManager()
        {
            InitializeComponent();
        }
        private void ChatManager_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GlobalVars.loading = 3000;
            backgroundWorker.RunWorkerAsync();
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(GlobalVars.loading);
            WebClient updateChat = new WebClient();
            string allUserList = updateChat.DownloadString(@"http://" + GlobalVars.host + @"/WinChat/WinChat.php?p=allUsers");
            string chatHistory = updateChat.DownloadString(@"http://" + GlobalVars.host + @"/WinChat/WinChat.php?p=getChatHistory");
            dynamic userAll = Json.Decode(allUserList);
            dynamic chatAll = Json.Decode(chatHistory);
            // Users in table
            MethodInvoker remUsers = delegate { this.userList.Rows.Clear(); };
            this.Invoke(remUsers);
            foreach (var user in userAll)
            {
                MethodInvoker addUser = delegate { this.userList.Rows.Add(user.username); };
                this.Invoke(addUser);
            }
            // chat in textbox
            MethodInvoker clearLog = delegate { this.log.Text = ""; };
            this.Invoke(clearLog);
            foreach (var message in chatAll)
            {
                if (message.message.Contains("_IMAGE_"))
                {
                    string loc = message.message;
                    loc = loc.Replace("_IMAGE_","");
                    loc = loc.Replace("http://","");
                    loc = loc.Replace("https://", "");
                    Random RAND = new Random();
                    string randv = Convert.ToString(RAND.Next(1,RAND.Next(1,999999)));
                    updateChat.DownloadFile(@"http://"+loc, @"C:\WinChatImages\"+loc.Replace("/","")+randv+".jpg");
                    Image image = Image.FromFile(@"C:\WinChatImages\" + loc.Replace("/", "") + randv+".jpg");
                    MethodInvoker addImage = delegate {
                        GlobalVars.ccb = Clipboard.GetText();
                        Clipboard.SetImage(image);
                        this.log.ReadOnly = false;
                        this.log.Paste();
                        this.log.ReadOnly = true;
                        this.log.AppendText(Environment.NewLine);
                        Clipboard.SetText(GlobalVars.ccb);
                    };
                    this.Invoke(addImage);
                }
                else {
                    MethodInvoker addLog = delegate { this.log.AppendText(message.message + Environment.NewLine); };
                    this.Invoke(addLog);
                }
            }
            MethodInvoker toBottom = delegate {
                if(this.AutoScrollCheck.Checked == true)
                {
                    this.log.ScrollToCaret();
                }
            };
            this.Invoke(toBottom);
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            WebClient send = new WebClient();
            string ack = send.DownloadString(@"http://"+GlobalVars.host+@"/WinChat/WinChat.php/?p=send&message="+message.Text+@"&user="+GlobalVars.username);
            message.Text = "";
            message.Focus();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
