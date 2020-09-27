namespace TorDocker
{
    partial class TorDocker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDataLog = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.dockerDownload = new System.Windows.Forms.Button();
            this.chkSocks = new System.Windows.Forms.Button();
            this.chkHttp = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.webView1 = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            this.btnGo = new MetroFramework.Controls.MetroButton();
            this.Search = new MetroFramework.Controls.MetroTextBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.ip = new MetroFramework.Controls.MetroLabel();
            this.ip2 = new MetroFramework.Controls.MetroLabel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataLog
            // 
            this.txtDataLog.BackColor = System.Drawing.Color.Black;
            this.txtDataLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLog.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtDataLog.Location = new System.Drawing.Point(11, 131);
            this.txtDataLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataLog.Multiline = true;
            this.txtDataLog.Name = "txtDataLog";
            this.txtDataLog.ReadOnly = true;
            this.txtDataLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDataLog.Size = new System.Drawing.Size(542, 427);
            this.txtDataLog.TabIndex = 16;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(11, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 26);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start Tor Server";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(162, 66);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(145, 26);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop Tor Server";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // dockerDownload
            // 
            this.dockerDownload.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dockerDownload.FlatAppearance.BorderSize = 0;
            this.dockerDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dockerDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockerDownload.Location = new System.Drawing.Point(401, 98);
            this.dockerDownload.Name = "dockerDownload";
            this.dockerDownload.Size = new System.Drawing.Size(145, 26);
            this.dockerDownload.TabIndex = 15;
            this.dockerDownload.Text = "Manual Download >";
            this.dockerDownload.UseVisualStyleBackColor = false;
            this.dockerDownload.Click += new System.EventHandler(this.dockerDownload_Click);
            // 
            // chkSocks
            // 
            this.chkSocks.BackColor = System.Drawing.Color.Yellow;
            this.chkSocks.FlatAppearance.BorderSize = 0;
            this.chkSocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSocks.Location = new System.Drawing.Point(11, 98);
            this.chkSocks.Name = "chkSocks";
            this.chkSocks.Size = new System.Drawing.Size(145, 26);
            this.chkSocks.TabIndex = 15;
            this.chkSocks.Text = "Check Socks 5 >";
            this.chkSocks.UseVisualStyleBackColor = false;
            this.chkSocks.Click += new System.EventHandler(this.chkSocks_Click);
            // 
            // chkHttp
            // 
            this.chkHttp.BackColor = System.Drawing.Color.Yellow;
            this.chkHttp.FlatAppearance.BorderSize = 0;
            this.chkHttp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHttp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHttp.Location = new System.Drawing.Point(162, 98);
            this.chkHttp.Name = "chkHttp";
            this.chkHttp.Size = new System.Drawing.Size(145, 26);
            this.chkHttp.TabIndex = 15;
            this.chkHttp.Text = "Check http >";
            this.chkHttp.UseVisualStyleBackColor = false;
            this.chkHttp.Click += new System.EventHandler(this.chkHttp_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInstall.FlatAppearance.BorderSize = 0;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.Location = new System.Drawing.Point(441, 63);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(105, 26);
            this.btnInstall.TabIndex = 15;
            this.btnInstall.Text = "Install Docker";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 563);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(531, 18);
            this.progressBar1.TabIndex = 18;
            // 
            // webView1
            // 
            this.webView1.Location = new System.Drawing.Point(571, 66);
            this.webView1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(697, 515);
            this.webView1.Source = new System.Uri("https://www.docker.com/products/docker-desktop", System.UriKind.Absolute);
            this.webView1.TabIndex = 20;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(1193, 42);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 22);
            this.btnGo.TabIndex = 21;
            this.btnGo.Text = "Go";
            this.btnGo.Visible = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Search.Location = new System.Drawing.Point(571, 42);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(622, 22);
            this.Search.TabIndex = 22;
            this.Search.Text = "http://ip2nation.com";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search.Visible = false;
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(571, 66);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(696, 514);
            this.browser.TabIndex = 23;
            this.browser.Visible = false;
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.Location = new System.Drawing.Point(287, 9);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(20, 19);
            this.ip.TabIndex = 24;
            this.ip.Text = "IP";
            // 
            // ip2
            // 
            this.ip2.AutoSize = true;
            this.ip2.Location = new System.Drawing.Point(287, 28);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(20, 19);
            this.ip2.TabIndex = 24;
            this.ip2.Text = "IP";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Crimson;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(495, 28);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(51, 26);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.LightSalmon;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(344, 100);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(51, 26);
            this.btnStats.TabIndex = 15;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // TorDocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 591);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.webView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtDataLog);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.chkHttp);
            this.Controls.Add(this.chkSocks);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.dockerDownload);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "TorDocker";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "myTor Proxy Server";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.TorDocker_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button dockerDownload;
        private System.Windows.Forms.Button chkSocks;
        private System.Windows.Forms.Button chkHttp;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView webView1;
        private MetroFramework.Controls.MetroButton btnGo;
        private MetroFramework.Controls.MetroTextBox Search;
        private System.Windows.Forms.WebBrowser browser;
        private MetroFramework.Controls.MetroLabel ip;
        private MetroFramework.Controls.MetroLabel ip2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnStats;
    }
}

