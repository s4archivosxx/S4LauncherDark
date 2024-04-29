using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UpdaterGame.Data;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace UpdaterGame2.UI
{
    public partial class frmUpdater : Form
    {
        IniFile _ini = new IniFile("Config.hjson");

        string Server2 = "http://localhost/Game/Patchs/";

        Point formPosition;
        bool mauseAction;
        int index = 0;
        private UpdateSaveFile localInfoFile;
        private String baseUrl;
        //private string file;

        #region Waiting..
        public frmUpdater(UpdateSaveFile file, String baseUrl)
        {
            localInfoFile = file;
            this.baseUrl = baseUrl;
            InitializeComponent();

            _PbInstall.Maximum = (file.UpdateFileCollection.Count) * 100;

            foreach (UpdateFileInfo fileInfo in file.UpdateFileCollection)
            {
                ListViewItem lvItem = new ListViewItem(new String[] { fileInfo.Name, "Waiting...", fileInfo.Description });
                lvItems.Items.Add(lvItem);
            }
        }

        #endregion

        private void WriteVersionLauncher()
        {
            try
            {
                ////server's list of updates
                XDocument serverXml = XDocument.Load(Server2 + "Config.xml");
                //The Update Process
                foreach (XElement _FilesOfTheGame in serverXml.Descendants("FilesOfTheGame"))
                {
                    string _version = _FilesOfTheGame.Element("NewVersion").Value;

                    _ini.Write("Version_FilesOfTheGame", _version, "UPDATES");
                    Environment.Exit(-1);
                }
            }
            catch
            {
                
            }
            
        }

        #region Complete
        private void BtnInstall_Click(object sender, EventArgs e)
        {
            WriteVersionLauncher();
        }
        #endregion

        #region SetStatus
        private void SetStatus(String p)
        {
            
        }
        #endregion

        #region DownloadFile
        private void DownloadFile()
        {
            WebClient downloadClient = new WebClient();

            downloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadClient_DownloadProgressChanged);
            downloadClient.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadClient_DownloadFileCompleted);

            ListViewItem currItem = lvItems.Items[index];

            String name = currItem.SubItems[0].Text;

            lblStatus.Text = ("Patching " + name + "...");
            currItem.SubItems[1].Text = "Patching...";

            String local = String.Format(@".\{0}", name);
            String online = String.Format("{0}{1}", baseUrl, name);

            if (File.Exists(local))
            {
                if (File.Exists(local + ".temp"))
                    File.Delete(local + ".temp");

                File.Move(local, local + ".temp");
            }


            downloadClient.DownloadFileAsync(new Uri(online), local);
        }
        #endregion

        #region Finish
        void downloadClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {


            ListViewItem currItem = lvItems.Items[index];
            currItem.SubItems[1].Text = "Finish";

            _PbInstall.Value = 100;
            _PbDownload.Value = 100;

            index += 1;

            if (lvItems.Items.Count - 1 >= index)
            {

                DownloadFile();
            }
            else
            {

                lblStatus.Text = "Patch Completed.";
                btnInstall.Text = "Complete";
                btnInstall.Enabled = true;
            }


        }
        #endregion

        #region Progress
        void downloadClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //pbDownload.Value = e.ProgressPercentage;
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            lblPercentage.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
            _PbDownload.Value = int.Parse(Math.Truncate(percentage).ToString());
            
        }
        #endregion

        #region Download
        private void frmUpdater_Load(object sender, EventArgs e)
        {
            DownloadFile();
        }
        #endregion

        #region Movimiento del Form 1
        private void frmUpdater_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mauseAction = true;
        }

        private void frmUpdater_MouseMove(object sender, MouseEventArgs e)
        {
            if (mauseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }
        private void frmUpdater_MouseUp(object sender, MouseEventArgs e)
        {
            mauseAction = false;
        }
        #endregion

        #region Movimiento del Form 2
        private void BG_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mauseAction = true;
        }

        private void BG_MouseMove(object sender, MouseEventArgs e)
        {
            if(mauseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }

        }

        private void BG_MouseUp(object sender, MouseEventArgs e)
        {
            mauseAction = false;
        }

        #endregion
    }
}
