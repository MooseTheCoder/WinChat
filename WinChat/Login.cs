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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            WebClient authClient = new WebClient();
            string down = authClient.DownloadString(@"http://"+hostAddr.Text + @"/WinChat/WinChat.php?p=auth&username=" + username.Text + @"&password=" + password.Text);
            dynamic bounce = Json.Decode(down);
            if (bounce.Ack == "false") {
                MessageBox.Show(bounce.err,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (bounce.Ack == "true") {
                GlobalVars.username = username.Text;
                GlobalVars.host = hostAddr.Text;
                GlobalVars.id = Convert.ToInt16(bounce.id);
                var chatWindow = new ChatManager();
                chatWindow.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = new serverList();
            list.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"C:\WinChatImages");

            foreach (System.IO.FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }
    }
}
