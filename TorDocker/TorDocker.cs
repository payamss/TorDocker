using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorDocker
{
    public partial class TorDocker : MetroForm
    {
        string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp/Docker%20Desktop%20Installer.exe");
        public int processID;
        public System.Windows.Forms.Timer timer2;
        public int counter = 5;
        public string mylogKey;
        public string Status = "";
        public string myLocalIP;

        public TorDocker()
        {
            InitializeComponent();

    }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtDataLog.AppendText("\r\n");
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = true;
            psi.CreateNoWindow = true;
            psi.WorkingDirectory = @"C:\Windows\System32";

            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = "/c " + "docker run -it -p 8118:8118 -p 9050:9050 -d --name myTorProxyServer --rm payamss/torproxy";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            try
            {
                var proc = Process.Start(psi);
                mylogKey = proc.StandardOutput.ReadToEnd();
                if (mylogKey != "")
                {
                    txtDataLog.AppendText(string.Format("Start Container - {0} \r\n", mylogKey));
                }
                  timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 1000; // 1 second
            timer2.Start();
            }
            catch (Exception ex)
            {
                txtDataLog.AppendText(ex.Message);


            }

        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndParent);
        private void dockerLog(string logKey)
        {
            txtDataLog.AppendText("\r\n");       
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = true;
            psi.CreateNoWindow = true;
            //  psi.WorkingDirectory = @"C:\Windows\System32";

            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = "/c docker logs myTorProxyServer";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            try
            {
                var proc = Process.Start(psi);
                processID = proc.Id;


                string log = proc.StandardOutput.ReadToEnd();

                if (log != "")
                {
                    txtDataLog.AppendText(string.Format("Start Container - {0} \r\n", log));
                    if (txtDataLog.Text.Contains("Done"))
                    {
                        Status = "Ready to use";
                    }
                }
                else
                {
                    txtDataLog.AppendText(string.Format(" Tor Stopped- {0} \r\n", log));

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
            btnStart.Enabled = true;
            btnStop.Enabled = false;
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
                txtDataLog.AppendText(string.Format("Stop Container - {0} \r\n", log));

            }
            try
            {
                if (timer2!=null)
                {
                    timer2.Stop();

                }

            }
            catch (Exception)
            {

            }       
        } 

        private void dockerDownload_Click(object sender, EventArgs e)
        {
            browser.Visible = false;

            if (dockerDownload.Text== "Manual Download >")
            {
                webView1.Visible = true;

                chkHttp.Text = "Check http >";
                chkSocks.Text = "Check Socks 5 >";
                TorDocker.ActiveForm.Width = 1274;
                dockerDownload.Text = "Manual Download <";
                webView1.Source = new Uri("https://www.docker.com/products/docker-desktop");

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
                webView1.Visible = false;

                chkHttp.Text = "Check http >";
                dockerDownload.Text = "Manual Download >";
                TorDocker.ActiveForm.Width = 1274;
                chkSocks.Text = "Check Socks 5 <";
                browser.Url = new Uri("http://localhost:9050");
                browser.Visible = true;

            }
            else
            {

                TorDocker.ActiveForm.Width = 571;
                chkSocks.Text = "Check Socks 5 >";
                browser.Visible = false;

            }

        }

        private void TorDocker_Load(object sender, EventArgs e)
        {

        }
        public void checkProxy()
        {

            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");

            // Obtain the 'Proxy' of the  Default browser.  
            IWebProxy proxy = myWebRequest.Proxy;
            // Print the Proxy Url to the console.
            if (proxy != null)
            {
                if (proxy.GetProxy(myWebRequest.RequestUri).ToString() == "http://www.microsoft.com/")
                {
                    txtDataLog.AppendText(string.Format("No Global Proxy \r\n" ));

                }
                else
                {
                    txtDataLog.AppendText(string.Format("Global Proxy: {0} \r\n", proxy.GetProxy(myWebRequest.RequestUri)));

                }

            }
            else
            {
                txtDataLog.AppendText("Proxy is null; no proxy will be used \r\n");

            }
        }

        private void chkHttp_Click(object sender, EventArgs e)
        {

            if (chkHttp.Text == "Check http >")
            {
                webView1.Visible = false;

                TorDocker.ActiveForm.Width = 1274;
                chkHttp.Text = "Check http <";
                chkSocks.Text = "Check Socks 5 >";
                dockerDownload.Text = "Manual Download >";
                WebRequest webRequest = WebRequest.Create("https://check.torproject.org/");
                webRequest.Proxy = new WebProxy("localhost:8118", true);
                try
                {
                    WebResponse response = webRequest.GetResponse();
                    Stream receiveStream = response.GetResponseStream();
                 //   webView1.NavigateToLocalStreamUri( receiveStream);
                    browser.DocumentStream = receiveStream;
                }
                catch (Exception ex)
                {
                    txtDataLog.Text = ex.Message;

                }
                browser.Visible = true;


            }
            else
            {
                TorDocker.ActiveForm.Width = 571;
                chkHttp.Text = "Check http >";
                browser.Visible = false;

            }
        }
        internal static string GetLocalIPv4(NetworkInterfaceType _type)
        {  // Checks your IP adress from the local network connected to a gateway. This to avoid issues with double network cards
            string output = "";  // default output
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces()) // Iterate over each network interface
            {  // Find the network interface which has been provided in the arguments, break the loop if found
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {   // Fetch the properties of this adapter
                    IPInterfaceProperties adapterProperties = item.GetIPProperties();
                    // Check if the gateway adress exist, if not its most likley a virtual network or smth
                    if (adapterProperties.GatewayAddresses.FirstOrDefault() != null)
                    {   // Iterate over each available unicast adresses
                        foreach (UnicastIPAddressInformation ip in adapterProperties.UnicastAddresses)
                        {   // If the IP is a local IPv4 adress
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {   // we got a match!
                                output = ip.Address.ToString();
                                break;  // break the loop!!
                            }
                        }
                    }
                }
                // Check if we got a result if so break this method
                if (output != "") { break; }
            }
            // Return results
            return output;
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0) { 
                timer2.Stop();
                dockerLog(mylogKey);
                if (Status=="Ready to use")
                {
                    
                    txtDataLog.AppendText(string.Format("\r\n Tor Server {0} \r\n Please following this help: \r\n 1- for Telegram use \r\n host : localhost \r\n port 9050 \r\n  2- for web you can use foxyproxy extension on firefox or chrome and add  \r\n host : localhost \r\n port:8118 \r\n also " +
                        "you can use windows system proxy socks \r\n host: localhost \r\n port 9050 \r\n 3- this server also run on your local ip address then insteade of local host you can use your ip address for example "+ myLocalIP +" with port 9050 or 8118  ", Status));
                        counter = 300;
                }
                else
                {
                    counter = 2;

                }
                timer2.Start();
               // MessageBox.Show(counter.ToString());

            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
          
            if (webView1 != null && webView1.Source != null)
            {
                webView1.Navigate(new Uri (Search.Text));
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help frm = new help();
            frm.Show();
        }

        private void TorDocker_Load_1(object sender, EventArgs e)
        {
            string IPLan = GetLocalIPv4(NetworkInterfaceType.Ethernet);
            string IPWIFI= GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (IPLan.Length > 0)
            {
                ip.Text =  "HTTP   - " + IPLan + " : 8118";
                ip2.Text = "Socks5 - " + IPLan + " : 9050";
                myLocalIP = IPLan;

            }
            else
            {
                ip.Text = "HTTP   - " + IPWIFI + " : 8118";
                ip2.Text = "Socks5 - " + IPWIFI + " : 9050";
           

            }
            checkProxy();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = "/c " + "docker stats";
            try
            {
                var proc = Process.Start(psi);

            }
            catch (Exception ex)
            {
                txtDataLog.AppendText(ex.Message);


            }
        }
    }
}
