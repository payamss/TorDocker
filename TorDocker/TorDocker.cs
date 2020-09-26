using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorDocker
{
    public partial class TorDocker : Form
    {
        string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp/Docker%20Desktop%20Installer.exe");

        public TorDocker()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           txtDataLog.AppendText("\r \n");

            var psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = true;
            psi.CreateNoWindow = true;
            psi.WorkingDirectory = @"C:\Windows\System32";

            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = "/c " + "docker run -it -p 8118:8118 -p 9050:9050 -d --name myTorProxyServer --rm dperson/torproxy";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            try
            {
                var proc = Process.Start(psi);
                string log = proc.StandardOutput.ReadToEnd();
                if (log != "")
                {
                    txtDataLog.AppendText(string.Format("Start Container - {0} /r /n", log));

                } 

            }
            catch (Exception ex)
            {
                txtDataLog.AppendText(ex.Message);


            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            txtDataLog.AppendText("\r \n");

            var psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = true;
             psi.CreateNoWindow = true;
            psi.WorkingDirectory = @"C:\Windows\System32";

            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = "/c " + "docker stop myTorProxyServer";
             psi.WindowStyle = ProcessWindowStyle.Hidden;
            
            var proc = Process.Start(psi);
            string log = proc.StandardOutput.ReadToEnd();
            if (log != "")
            {
                txtDataLog.AppendText(string.Format("Stop Container - {0} /r /n", log));

            }
        }

        private void dockerDownload_Click(object sender, EventArgs e)
        {
            if (dockerDownload.Text== "Manual Download >")
            {
                TorDocker.ActiveForm.Width = 1274;
                dockerDownload.Text = "Manual Download <";
                browser.Url = new Uri("https://www.docker.com/products/docker-desktop");

            }
            else
            {
                TorDocker.ActiveForm.Width = 571;
                dockerDownload.Text = "Manual Download >";
            }
        }

        private void chkSocks_Click(object sender, EventArgs e)
        {
            if (chkSocks.Text == "Check Socks 5 >")
            {
                TorDocker.ActiveForm.Width = 1274;
                chkSocks.Text = "Check Socks 5 <";
                //WebRequest webRequest = WebRequest.Create("http://localhost:9050");
                //webRequest.Proxy = new WebProxy("localhost:8118", false);
                //WebResponse response = webRequest.GetResponse();
                //Stream receiveStream = response.GetResponseStream();
                //browser.DocumentStream = receiveStream;
                browser.Url = new Uri("http://localhost:9050");


            }
            else
            {
                TorDocker.ActiveForm.Width = 571;
                chkSocks.Text = "Check Socks 5 >";
            }
            
        }

        private void TorDocker_Load(object sender, EventArgs e)
        {
            checkProxy();
        }
        public void checkProxy()
        {

            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");

            // Obtain the 'Proxy' of the  Default browser.  
            IWebProxy proxy = myWebRequest.Proxy;
            // Print the Proxy Url to the console.
            if (proxy != null)
            {
                txtDataLog.AppendText(string.Format("Proxy: {0}", proxy.GetProxy(myWebRequest.RequestUri)));
            }
            else
            {
                txtDataLog.AppendText("Proxy is null; no proxy will be used");
            }
        }

        private void chkHttp_Click(object sender, EventArgs e)
        {
            if (chkHttp.Text == "Check http >")
            {
                TorDocker.ActiveForm.Width = 1274;
                chkHttp.Text = "Check http <";
                WebRequest webRequest = WebRequest.Create("https://check.torproject.org/");
                webRequest.Proxy = new WebProxy("localhost:8118", true);
                try
                {
                    WebResponse response = webRequest.GetResponse();
                    Stream receiveStream = response.GetResponseStream();
                    browser.DocumentStream = receiveStream;
                }
                catch (Exception ex)
                {
                    txtDataLog.Text = ex.Message;
                }                


            }
            else
            {
                TorDocker.ActiveForm.Width = 571;
                chkHttp.Text = "Check http >";
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://download.docker.com/win/stable/Docker%20Desktop%20Installer.exe");

            try
            {
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }

                WebClient wc = new WebClient();
                wc.DownloadFileAsync(uri, filename);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
            }
        }
        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Process.Start(filename);
                Close();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Unable to download exe, please check your connection", "Download failed!");
            }
        }
    }
}
