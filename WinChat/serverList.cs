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
    public partial class serverList : Form
    {
        public serverList()
        {
            InitializeComponent();
        }

        private void serverList_Load(object sender, EventArgs e)
        {
            WebClient gls = new WebClient();
            string webDL = gls.DownloadString(@"http://localhost/WinChat/WinChatGlobal.php?p=getServerList");
            dynamic res = Json.Decode(webDL);
            foreach (dynamic serverDetail in res) {
                serverListGrid.Rows.Add(serverDetail.name,serverDetail.addr,serverDetail.motd,serverDetail.owner);
            }
        }
    }
}
