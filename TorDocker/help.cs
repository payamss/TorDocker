using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorDocker
{
    public partial class help : MetroForm
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            txt.Text = "please follow this Steps: \r\n" +
                "Step 1- Go to Docker Site and download and install Docker Desktop " +
                "or use install button to download from docker website \r\n" +
                "Step 2- Start Server For First Time get image from internet and after that Create Container from local image \r\n" +
                "Step 3- check Log that shows bootstrap 100% or Done, \r\n" +
                "Step 4- check Tor socks server is running by clicking on check socks 5 button \r\n" +
                "step 5- check Privoxy http Server is running by clicking on check http button \r\n" +
                "Step 6- Set Proxy on Your browser or socks5 application \r\n" +
                "Step 7- [Optional] install FoxyProxy extension For Firefox or Chrome \r\n" +
                "This server can run both on localhost and your computer ip address \r\n" +
                "For example if your ip is 192.168.1.50 you can use tor through your other device for" +
                " example cellphone or another pc or tablet and adding socks or http proxy of 192.168.1.50:9050 (socks) or 192.168.1.50:8118 (http) \r\n" +
                "This server is running till you stop it if you close this program this server is not Stopped";

        }
    }
}
