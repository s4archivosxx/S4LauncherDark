namespace S4League
{
    partial class S4LeagueDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S4LeagueDF));
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.downloadLbl = new System.Windows.Forms.Label();
            this.patchNotes = new System.Windows.Forms.WebBrowser();
            this.LangFrance = new System.Windows.Forms.RadioButton();
            this.NOTICE1 = new System.Windows.Forms.WebBrowser();
            this.NOTICE2 = new System.Windows.Forms.WebBrowser();
            this.pbInstall = new System.Windows.Forms.ProgressBar();
            this.btnStart02 = new System.Windows.Forms.PictureBox();
            this.btnStart2 = new System.Windows.Forms.PictureBox();
            this.REGISTRARSE_1 = new System.Windows.Forms.PictureBox();
            this.REGISTRARSE_0 = new System.Windows.Forms.PictureBox();
            this.SPA_1 = new System.Windows.Forms.PictureBox();
            this.USA_1 = new System.Windows.Forms.PictureBox();
            this.USA_0 = new System.Windows.Forms.PictureBox();
            this.SPA_0 = new System.Windows.Forms.PictureBox();
            this.PLAYCOMPLETE = new System.Windows.Forms.PictureBox();
            this.DOWNLOADUPDATES = new System.Windows.Forms.PictureBox();
            this.WEBSITE_1 = new System.Windows.Forms.PictureBox();
            this.WEBSITE_0 = new System.Windows.Forms.PictureBox();
            this.btn_close1 = new System.Windows.Forms.PictureBox();
            this.RECARGAR_0 = new System.Windows.Forms.PictureBox();
            this.btn_close0 = new System.Windows.Forms.PictureBox();
            this.RECARGAR_1 = new System.Windows.Forms.PictureBox();
            this.btnStart1 = new System.Windows.Forms.PictureBox();
            this.btnStart0 = new System.Windows.Forms.PictureBox();
            this.S4Launcher = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REGISTRARSE_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REGISTRARSE_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPA_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USA_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USA_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPA_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYCOMPLETE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOWNLOADUPDATES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WEBSITE_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WEBSITE_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RECARGAR_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RECARGAR_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S4Launcher)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDownload
            // 
            this.pbDownload.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbDownload.ForeColor = System.Drawing.Color.SteelBlue;
            this.pbDownload.Location = new System.Drawing.Point(304, 494);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(460, 16);
            this.pbDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDownload.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // downloadLbl
            // 
            this.downloadLbl.AutoSize = true;
            this.downloadLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.downloadLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.downloadLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.downloadLbl.Location = new System.Drawing.Point(605, 402);
            this.downloadLbl.Name = "downloadLbl";
            this.downloadLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.downloadLbl.Size = new System.Drawing.Size(0, 13);
            this.downloadLbl.TabIndex = 2;
            // 
            // patchNotes
            // 
            this.patchNotes.Location = new System.Drawing.Point(12, 441);
            this.patchNotes.MinimumSize = new System.Drawing.Size(20, 20);
            this.patchNotes.Name = "patchNotes";
            this.patchNotes.ScrollBarsEnabled = false;
            this.patchNotes.Size = new System.Drawing.Size(29, 23);
            this.patchNotes.TabIndex = 5;
            this.patchNotes.Url = new System.Uri("http://127.0.0.1/Game/Patchs/", System.UriKind.Absolute);
            this.patchNotes.Visible = false;
            // 
            // LangFrance
            // 
            this.LangFrance.AutoSize = true;
            this.LangFrance.BackColor = System.Drawing.Color.Black;
            this.LangFrance.ForeColor = System.Drawing.Color.Transparent;
            this.LangFrance.Location = new System.Drawing.Point(582, 437);
            this.LangFrance.Name = "LangFrance";
            this.LangFrance.Size = new System.Drawing.Size(14, 13);
            this.LangFrance.TabIndex = 12;
            this.LangFrance.UseVisualStyleBackColor = false;
            this.LangFrance.CheckedChanged += new System.EventHandler(this.LangFrance_CheckedChanged);
            // 
            // NOTICE1
            // 
            this.NOTICE1.AllowNavigation = false;
            this.NOTICE1.AllowWebBrowserDrop = false;
            this.NOTICE1.Location = new System.Drawing.Point(306, 113);
            this.NOTICE1.MinimumSize = new System.Drawing.Size(20, 20);
            this.NOTICE1.Name = "NOTICE1";
            this.NOTICE1.ScriptErrorsSuppressed = true;
            this.NOTICE1.ScrollBarsEnabled = false;
            this.NOTICE1.Size = new System.Drawing.Size(456, 175);
            this.NOTICE1.TabIndex = 21;
            this.NOTICE1.Url = new System.Uri("http://127.0.0.1/Game/notice/index.php", System.UriKind.Absolute);
            // 
            // NOTICE2
            // 
            this.NOTICE2.AllowNavigation = false;
            this.NOTICE2.AllowWebBrowserDrop = false;
            this.NOTICE2.Location = new System.Drawing.Point(306, 294);
            this.NOTICE2.MinimumSize = new System.Drawing.Size(20, 20);
            this.NOTICE2.Name = "NOTICE2";
            this.NOTICE2.ScriptErrorsSuppressed = true;
            this.NOTICE2.ScrollBarsEnabled = false;
            this.NOTICE2.Size = new System.Drawing.Size(456, 178);
            this.NOTICE2.TabIndex = 24;
            this.NOTICE2.Url = new System.Uri("http://127.0.0.1/Game/notice/index2.php", System.UriKind.Absolute);
            // 
            // pbInstall
            // 
            this.pbInstall.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbInstall.ForeColor = System.Drawing.Color.SteelBlue;
            this.pbInstall.Location = new System.Drawing.Point(304, 514);
            this.pbInstall.Name = "pbInstall";
            this.pbInstall.Size = new System.Drawing.Size(460, 16);
            this.pbInstall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbInstall.TabIndex = 0;
            // 
            // btnStart02
            // 
            this.btnStart02.BackColor = System.Drawing.Color.Black;
            this.btnStart02.BackgroundImage = global::S4Launcher.Properties.Resources.start1;
            this.btnStart02.Location = new System.Drawing.Point(304, 533);
            this.btnStart02.Name = "btnStart02";
            this.btnStart02.Size = new System.Drawing.Size(206, 88);
            this.btnStart02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart02.TabIndex = 35;
            this.btnStart02.TabStop = false;
            this.btnStart02.Visible = false;
            this.btnStart02.MouseHover += new System.EventHandler(this.btnStart02_MouseHover);
            // 
            // btnStart2
            // 
            this.btnStart2.BackColor = System.Drawing.Color.Black;
            this.btnStart2.BackgroundImage = global::S4Launcher.Properties.Resources.start_1;
            this.btnStart2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart2.Location = new System.Drawing.Point(304, 533);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(206, 88);
            this.btnStart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart2.TabIndex = 34;
            this.btnStart2.TabStop = false;
            this.btnStart2.Visible = false;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            this.btnStart2.MouseLeave += new System.EventHandler(this.btnStart2_MouseLeave);
            // 
            // REGISTRARSE_1
            // 
            this.REGISTRARSE_1.BackColor = System.Drawing.SystemColors.ControlText;
            this.REGISTRARSE_1.BackgroundImage = global::S4Launcher.Properties.Resources.REGISTRARSE_1;
            this.REGISTRARSE_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.REGISTRARSE_1.Location = new System.Drawing.Point(596, 14);
            this.REGISTRARSE_1.Name = "REGISTRARSE_1";
            this.REGISTRARSE_1.Size = new System.Drawing.Size(155, 60);
            this.REGISTRARSE_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.REGISTRARSE_1.TabIndex = 32;
            this.REGISTRARSE_1.TabStop = false;
            this.REGISTRARSE_1.Visible = false;
            this.REGISTRARSE_1.Click += new System.EventHandler(this.REGISTRARSE_1_Click);
            this.REGISTRARSE_1.MouseLeave += new System.EventHandler(this.REGISTRARSE_1_MouseLeave);
            // 
            // REGISTRARSE_0
            // 
            this.REGISTRARSE_0.BackColor = System.Drawing.SystemColors.ControlText;
            this.REGISTRARSE_0.BackgroundImage = global::S4Launcher.Properties.Resources.REGISTRARSE;
            this.REGISTRARSE_0.Location = new System.Drawing.Point(596, 14);
            this.REGISTRARSE_0.Name = "REGISTRARSE_0";
            this.REGISTRARSE_0.Size = new System.Drawing.Size(155, 60);
            this.REGISTRARSE_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.REGISTRARSE_0.TabIndex = 31;
            this.REGISTRARSE_0.TabStop = false;
            this.REGISTRARSE_0.MouseHover += new System.EventHandler(this.REGISTRARSE_0_MouseHover);
            // 
            // SPA_1
            // 
            this.SPA_1.BackColor = System.Drawing.Color.Black;
            this.SPA_1.BackgroundImage = global::S4Launcher.Properties.Resources.SPA_1;
            this.SPA_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SPA_1.Location = new System.Drawing.Point(63, 580);
            this.SPA_1.Name = "SPA_1";
            this.SPA_1.Size = new System.Drawing.Size(43, 38);
            this.SPA_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SPA_1.TabIndex = 30;
            this.SPA_1.TabStop = false;
            this.SPA_1.Visible = false;
            this.SPA_1.Click += new System.EventHandler(this.SPA_1_Click);
            this.SPA_1.MouseLeave += new System.EventHandler(this.SPA_1_MouseLeave);
            // 
            // USA_1
            // 
            this.USA_1.BackColor = System.Drawing.Color.Black;
            this.USA_1.BackgroundImage = global::S4Launcher.Properties.Resources.USA_1;
            this.USA_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.USA_1.Location = new System.Drawing.Point(115, 580);
            this.USA_1.Name = "USA_1";
            this.USA_1.Size = new System.Drawing.Size(43, 38);
            this.USA_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.USA_1.TabIndex = 29;
            this.USA_1.TabStop = false;
            this.USA_1.Visible = false;
            this.USA_1.Click += new System.EventHandler(this.USA_1_Click);
            this.USA_1.MouseLeave += new System.EventHandler(this.USA_1_MouseLeave);
            // 
            // USA_0
            // 
            this.USA_0.BackColor = System.Drawing.Color.Black;
            this.USA_0.BackgroundImage = global::S4Launcher.Properties.Resources.USA;
            this.USA_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.USA_0.Location = new System.Drawing.Point(115, 580);
            this.USA_0.Name = "USA_0";
            this.USA_0.Size = new System.Drawing.Size(43, 38);
            this.USA_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.USA_0.TabIndex = 28;
            this.USA_0.TabStop = false;
            this.USA_0.MouseHover += new System.EventHandler(this.USA_0_MouseHover);
            // 
            // SPA_0
            // 
            this.SPA_0.BackColor = System.Drawing.Color.Black;
            this.SPA_0.BackgroundImage = global::S4Launcher.Properties.Resources.SPA;
            this.SPA_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SPA_0.Location = new System.Drawing.Point(63, 580);
            this.SPA_0.Name = "SPA_0";
            this.SPA_0.Size = new System.Drawing.Size(43, 38);
            this.SPA_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SPA_0.TabIndex = 27;
            this.SPA_0.TabStop = false;
            this.SPA_0.MouseHover += new System.EventHandler(this.SPA_0_MouseHover);
            // 
            // PLAYCOMPLETE
            // 
            this.PLAYCOMPLETE.BackColor = System.Drawing.Color.Black;
            this.PLAYCOMPLETE.Cursor = System.Windows.Forms.Cursors.Default;
            this.PLAYCOMPLETE.Image = global::S4Launcher.Properties.Resources.PLAY_GAME;
            this.PLAYCOMPLETE.Location = new System.Drawing.Point(303, 476);
            this.PLAYCOMPLETE.Name = "PLAYCOMPLETE";
            this.PLAYCOMPLETE.Size = new System.Drawing.Size(92, 15);
            this.PLAYCOMPLETE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PLAYCOMPLETE.TabIndex = 26;
            this.PLAYCOMPLETE.TabStop = false;
            this.PLAYCOMPLETE.Visible = false;
            // 
            // DOWNLOADUPDATES
            // 
            this.DOWNLOADUPDATES.BackColor = System.Drawing.Color.Black;
            this.DOWNLOADUPDATES.Cursor = System.Windows.Forms.Cursors.Default;
            this.DOWNLOADUPDATES.Image = global::S4Launcher.Properties.Resources.DOWNLOAD_UPDATES;
            this.DOWNLOADUPDATES.Location = new System.Drawing.Point(453, 476);
            this.DOWNLOADUPDATES.Name = "DOWNLOADUPDATES";
            this.DOWNLOADUPDATES.Size = new System.Drawing.Size(206, 15);
            this.DOWNLOADUPDATES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DOWNLOADUPDATES.TabIndex = 25;
            this.DOWNLOADUPDATES.TabStop = false;
            this.DOWNLOADUPDATES.Visible = false;
            // 
            // WEBSITE_1
            // 
            this.WEBSITE_1.BackColor = System.Drawing.SystemColors.ControlText;
            this.WEBSITE_1.BackgroundImage = global::S4Launcher.Properties.Resources.WEB_SITE_1;
            this.WEBSITE_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WEBSITE_1.Location = new System.Drawing.Point(455, 15);
            this.WEBSITE_1.Name = "WEBSITE_1";
            this.WEBSITE_1.Size = new System.Drawing.Size(141, 61);
            this.WEBSITE_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WEBSITE_1.TabIndex = 23;
            this.WEBSITE_1.TabStop = false;
            this.WEBSITE_1.Visible = false;
            this.WEBSITE_1.Click += new System.EventHandler(this.WEBSITE_1_Click);
            this.WEBSITE_1.MouseLeave += new System.EventHandler(this.WEBSITE_1_MouseLeave);
            // 
            // WEBSITE_0
            // 
            this.WEBSITE_0.BackColor = System.Drawing.SystemColors.ControlText;
            this.WEBSITE_0.BackgroundImage = global::S4Launcher.Properties.Resources.WEB_SITE;
            this.WEBSITE_0.Cursor = System.Windows.Forms.Cursors.Default;
            this.WEBSITE_0.Location = new System.Drawing.Point(453, 15);
            this.WEBSITE_0.Name = "WEBSITE_0";
            this.WEBSITE_0.Size = new System.Drawing.Size(141, 61);
            this.WEBSITE_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WEBSITE_0.TabIndex = 22;
            this.WEBSITE_0.TabStop = false;
            this.WEBSITE_0.Click += new System.EventHandler(this.btn_website1_Click);
            this.WEBSITE_0.MouseHover += new System.EventHandler(this.WEBSITE_0_MouseHover);
            // 
            // btn_close1
            // 
            this.btn_close1.BackColor = System.Drawing.Color.Black;
            this.btn_close1.BackgroundImage = global::S4Launcher.Properties.Resources.close_1;
            this.btn_close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close1.Location = new System.Drawing.Point(558, 533);
            this.btn_close1.Name = "btn_close1";
            this.btn_close1.Size = new System.Drawing.Size(206, 88);
            this.btn_close1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_close1.TabIndex = 20;
            this.btn_close1.TabStop = false;
            this.btn_close1.Visible = false;
            this.btn_close1.Click += new System.EventHandler(this.btn_close1_Click);
            this.btn_close1.MouseLeave += new System.EventHandler(this.btn_close1_MouseLeave);
            // 
            // RECARGAR_0
            // 
            this.RECARGAR_0.BackColor = System.Drawing.SystemColors.ControlText;
            this.RECARGAR_0.BackgroundImage = global::S4Launcher.Properties.Resources.RECARGAR_AP;
            this.RECARGAR_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RECARGAR_0.Location = new System.Drawing.Point(302, 14);
            this.RECARGAR_0.Name = "RECARGAR_0";
            this.RECARGAR_0.Size = new System.Drawing.Size(155, 61);
            this.RECARGAR_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RECARGAR_0.TabIndex = 19;
            this.RECARGAR_0.TabStop = false;
            this.RECARGAR_0.MouseHover += new System.EventHandler(this.btn_register0_MouseHover);
            // 
            // btn_close0
            // 
            this.btn_close0.BackColor = System.Drawing.Color.Black;
            this.btn_close0.BackgroundImage = global::S4Launcher.Properties.Resources.close3;
            this.btn_close0.Location = new System.Drawing.Point(558, 533);
            this.btn_close0.Name = "btn_close0";
            this.btn_close0.Size = new System.Drawing.Size(206, 88);
            this.btn_close0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_close0.TabIndex = 18;
            this.btn_close0.TabStop = false;
            this.btn_close0.MouseHover += new System.EventHandler(this.btn_close0_MouseHover);
            // 
            // RECARGAR_1
            // 
            this.RECARGAR_1.BackColor = System.Drawing.SystemColors.ControlText;
            this.RECARGAR_1.BackgroundImage = global::S4Launcher.Properties.Resources.RECARGAR_AP_1;
            this.RECARGAR_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RECARGAR_1.Location = new System.Drawing.Point(302, 15);
            this.RECARGAR_1.Name = "RECARGAR_1";
            this.RECARGAR_1.Size = new System.Drawing.Size(155, 61);
            this.RECARGAR_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RECARGAR_1.TabIndex = 17;
            this.RECARGAR_1.TabStop = false;
            this.RECARGAR_1.Visible = false;
            this.RECARGAR_1.Click += new System.EventHandler(this.btn_register1_Click);
            this.RECARGAR_1.MouseLeave += new System.EventHandler(this.btn_register1_MouseLeave);
            // 
            // btnStart1
            // 
            this.btnStart1.BackColor = System.Drawing.Color.Black;
            this.btnStart1.BackgroundImage = global::S4Launcher.Properties.Resources.start_1;
            this.btnStart1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart1.Location = new System.Drawing.Point(304, 533);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(206, 88);
            this.btnStart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart1.TabIndex = 16;
            this.btnStart1.TabStop = false;
            this.btnStart1.Visible = false;
            this.btnStart1.Click += new System.EventHandler(this.bntStart1_Click);
            this.btnStart1.MouseLeave += new System.EventHandler(this.bntStart1_MouseLeave);
            // 
            // btnStart0
            // 
            this.btnStart0.BackColor = System.Drawing.Color.Black;
            this.btnStart0.BackgroundImage = global::S4Launcher.Properties.Resources.start1;
            this.btnStart0.Location = new System.Drawing.Point(304, 533);
            this.btnStart0.Name = "btnStart0";
            this.btnStart0.Size = new System.Drawing.Size(206, 88);
            this.btnStart0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart0.TabIndex = 15;
            this.btnStart0.TabStop = false;
            this.btnStart0.MouseHover += new System.EventHandler(this.bntStart0_MouseHover);
            // 
            // S4Launcher
            // 
            this.S4Launcher.BackColor = System.Drawing.Color.Black;
            this.S4Launcher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S4Launcher.Image = ((System.Drawing.Image)(resources.GetObject("S4Launcher.Image")));
            this.S4Launcher.Location = new System.Drawing.Point(0, 0);
            this.S4Launcher.Name = "S4Launcher";
            this.S4Launcher.Size = new System.Drawing.Size(770, 630);
            this.S4Launcher.TabIndex = 8;
            this.S4Launcher.TabStop = false;
            this.S4Launcher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.S4Launcher_MouseDown);
            this.S4Launcher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.S4Launcher_MouseMove);
            this.S4Launcher.MouseUp += new System.Windows.Forms.MouseEventHandler(this.S4Launcher_MouseUp);
            // 
            // S4LeagueDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(770, 630);
            this.Controls.Add(this.btnStart02);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.pbInstall);
            this.Controls.Add(this.REGISTRARSE_1);
            this.Controls.Add(this.REGISTRARSE_0);
            this.Controls.Add(this.SPA_1);
            this.Controls.Add(this.USA_1);
            this.Controls.Add(this.USA_0);
            this.Controls.Add(this.SPA_0);
            this.Controls.Add(this.PLAYCOMPLETE);
            this.Controls.Add(this.DOWNLOADUPDATES);
            this.Controls.Add(this.NOTICE2);
            this.Controls.Add(this.WEBSITE_1);
            this.Controls.Add(this.WEBSITE_0);
            this.Controls.Add(this.NOTICE1);
            this.Controls.Add(this.btn_close1);
            this.Controls.Add(this.RECARGAR_0);
            this.Controls.Add(this.btn_close0);
            this.Controls.Add(this.RECARGAR_1);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.btnStart0);
            this.Controls.Add(this.LangFrance);
            this.Controls.Add(this.downloadLbl);
            this.Controls.Add(this.pbDownload);
            this.Controls.Add(this.patchNotes);
            this.Controls.Add(this.S4Launcher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "S4LeagueDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S4League";
            this.Load += new System.EventHandler(this.S4LeagueDF_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnStart02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REGISTRARSE_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REGISTRARSE_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPA_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USA_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USA_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPA_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYCOMPLETE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOWNLOADUPDATES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WEBSITE_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WEBSITE_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RECARGAR_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RECARGAR_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S4Launcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbDownload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label downloadLbl;
        private System.Windows.Forms.WebBrowser patchNotes;
        private System.Windows.Forms.PictureBox S4Launcher;
        private System.Windows.Forms.RadioButton LangFrance;
        private System.Windows.Forms.PictureBox btnStart0;
        private System.Windows.Forms.PictureBox btnStart1;
        private System.Windows.Forms.PictureBox RECARGAR_1;
        private System.Windows.Forms.PictureBox btn_close0;
        private System.Windows.Forms.PictureBox RECARGAR_0;
        private System.Windows.Forms.PictureBox btn_close1;
        private System.Windows.Forms.PictureBox WEBSITE_0;
        private System.Windows.Forms.PictureBox WEBSITE_1;
        private System.Windows.Forms.WebBrowser NOTICE1;
        //private UpdaterGame.Updater updater;
        private System.Windows.Forms.WebBrowser NOTICE2;
        private System.Windows.Forms.PictureBox DOWNLOADUPDATES;
        private System.Windows.Forms.PictureBox PLAYCOMPLETE;
        private System.Windows.Forms.PictureBox SPA_0;
        private System.Windows.Forms.PictureBox USA_0;
        private System.Windows.Forms.PictureBox USA_1;
        private System.Windows.Forms.PictureBox SPA_1;
        private System.Windows.Forms.PictureBox REGISTRARSE_0;
        private System.Windows.Forms.PictureBox REGISTRARSE_1;
        private System.Windows.Forms.ProgressBar pbInstall;
        private System.Windows.Forms.PictureBox btnStart2;
        private System.Windows.Forms.PictureBox btnStart02;
    }
}

