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
            this.browser = new System.Windows.Forms.WebBrowser();
            this.dockerDownload = new System.Windows.Forms.Button();
            this.chkSocks = new System.Windows.Forms.Button();
            this.chkHttp = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtDataLog
            // 
            this.txtDataLog.BackColor = System.Drawing.Color.Black;
            this.txtDataLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLog.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtDataLog.Location = new System.Drawing.Point(8, 75);
            this.txtDataLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataLog.Multiline = true;
            this.txtDataLog.Name = "txtDataLog";
            this.txtDataLog.ReadOnly = true;
            this.txtDataLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDataLog.Size = new System.Drawing.Size(542, 249);
            this.txtDataLog.TabIndex = 16;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(8, 12);
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
            this.btnStop.Location = new System.Drawing.Point(159, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(145, 26);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop Tor Server";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(555, 2);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(701, 728);
            this.browser.TabIndex = 17;
            this.browser.Url = new System.Uri("https://www.docker.com/products/docker-desktop", System.UriKind.Absolute);
            // 
            // dockerDownload
            // 
            this.dockerDownload.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dockerDownload.FlatAppearance.BorderSize = 0;
            this.dockerDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dockerDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockerDownload.Location = new System.Drawing.Point(398, 44);
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
            this.chkSocks.Location = new System.Drawing.Point(8, 44);
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
            this.chkHttp.Location = new System.Drawing.Point(159, 44);
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
            this.btnInstall.Location = new System.Drawing.Point(398, 12);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(145, 26);
            this.btnInstall.TabIndex = 15;
            this.btnInstall.Text = "Install Docker";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 329);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(531, 18);
            this.progressBar1.TabIndex = 18;
            // 
            // TorDocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 351);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.txtDataLog);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.chkHttp);
            this.Controls.Add(this.chkSocks);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.dockerDownload);
            this.Controls.Add(this.btnStart);
            this.Name = "TorDocker";
            this.Text = "myTor Proxy Server";
            this.Load += new System.EventHandler(this.TorDocker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button dockerDownload;
        private System.Windows.Forms.Button chkSocks;
        private System.Windows.Forms.Button chkHttp;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

