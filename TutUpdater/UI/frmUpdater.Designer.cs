namespace UpdaterGame2.UI
{
    partial class frmUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdater));
            this.lblStatus = new System.Windows.Forms.Label();
            this.lvItems = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInstall = new System.Windows.Forms.Button();
            this.BG = new System.Windows.Forms.PictureBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this._PbDownload = new UpdaterGame.UI.ProgressBarEx();
            this._PbInstall = new UpdaterGame.UI.ProgressBarEx();
            this._LogoS4L = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LogoS4L)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Trebuchet MS", 14.75F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(218, 26);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Waiting for Patching...";
            // 
            // lvItems
            // 
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmStatus,
            this.clmDesc});
            this.lvItems.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.lvItems.Location = new System.Drawing.Point(7, 278);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(448, 204);
            this.lvItems.TabIndex = 3;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.Visible = false;
            // 
            // clmName
            // 
            this.clmName.Text = "Nombre";
            this.clmName.Width = 104;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            this.clmStatus.Width = 99;
            // 
            // clmDesc
            // 
            this.clmDesc.Text = "Description";
            this.clmDesc.Width = 228;
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.Transparent;
            this.btnInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInstall.Enabled = false;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.btnInstall.ForeColor = System.Drawing.Color.White;
            this.btnInstall.Location = new System.Drawing.Point(169, 170);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(139, 36);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = " Patching...";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.BtnInstall_Click);
            // 
            // BG
            // 
            this.BG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BG.BackgroundImage")));
            this.BG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG.Location = new System.Drawing.Point(0, 0);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(460, 218);
            this.BG.TabIndex = 5;
            this.BG.TabStop = false;
            this.BG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BG_MouseDown);
            this.BG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BG_MouseMove);
            this.BG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BG_MouseUp);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentage.Font = new System.Drawing.Font("Trebuchet MS", 14.75F);
            this.lblPercentage.ForeColor = System.Drawing.Color.White;
            this.lblPercentage.Location = new System.Drawing.Point(12, 65);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(122, 26);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "Downloaded";
            // 
            // _PbDownload
            // 
            this._PbDownload.BackColor = System.Drawing.Color.Transparent;
            this._PbDownload.BackgroundColor = System.Drawing.Color.Black;
            this._PbDownload.ForeColor = System.Drawing.Color.White;
            this._PbDownload.GradiantColor = System.Drawing.Color.Yellow;
            this._PbDownload.Image = null;
            this._PbDownload.Location = new System.Drawing.Point(17, 100);
            this._PbDownload.Name = "_PbDownload";
            this._PbDownload.ProgressColor = System.Drawing.Color.Chocolate;
            this._PbDownload.Size = new System.Drawing.Size(431, 22);
            this._PbDownload.Text = "progressBarEx1";
            // 
            // _PbInstall
            // 
            this._PbInstall.BackColor = System.Drawing.Color.Transparent;
            this._PbInstall.BackgroundColor = System.Drawing.Color.Black;
            this._PbInstall.ForeColor = System.Drawing.Color.White;
            this._PbInstall.GradiantColor = System.Drawing.Color.Yellow;
            this._PbInstall.Image = null;
            this._PbInstall.Location = new System.Drawing.Point(17, 128);
            this._PbInstall.Name = "_PbInstall";
            this._PbInstall.ProgressColor = System.Drawing.Color.Chocolate;
            this._PbInstall.Size = new System.Drawing.Size(431, 22);
            this._PbInstall.Text = "progressBarEx2";
            // 
            // _LogoS4L
            // 
            this._LogoS4L.BackColor = System.Drawing.Color.Transparent;
            this._LogoS4L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._LogoS4L.Cursor = System.Windows.Forms.Cursors.Hand;
            this._LogoS4L.Image = ((System.Drawing.Image)(resources.GetObject("_LogoS4L.Image")));
            this._LogoS4L.Location = new System.Drawing.Point(369, 0);
            this._LogoS4L.Name = "_LogoS4L";
            this._LogoS4L.Size = new System.Drawing.Size(91, 77);
            this._LogoS4L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._LogoS4L.TabIndex = 9;
            this._LogoS4L.TabStop = false;
            this._LogoS4L.Visible = false;
            // 
            // frmUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 218);
            this.Controls.Add(this._LogoS4L);
            this.Controls.Add(this._PbInstall);
            this.Controls.Add(this._PbDownload);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.BG);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S4League Updating...";
            this.Load += new System.EventHandler(this.frmUpdater_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUpdater_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmUpdater_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmUpdater_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LogoS4L)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.ColumnHeader clmDesc;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.PictureBox BG;
        private System.Windows.Forms.Label lblPercentage;
        private UpdaterGame.UI.ProgressBarEx _PbDownload;
        private UpdaterGame.UI.ProgressBarEx _PbInstall;
        private System.Windows.Forms.PictureBox _LogoS4L;
    }
}