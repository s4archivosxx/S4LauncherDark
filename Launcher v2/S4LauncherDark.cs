using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Ionic.Zip;

namespace S4League
{
    public partial class S4LeagueDF : Form
    {
        string Server = "http://127.0.0.1/Game/Patchs/";

        //Defines application root
        string Root = AppDomain.CurrentDomain.BaseDirectory;
        private const String LocalUpdateFile = @".\version.ini";
        public String UpdateUrl = "http://127.0.0.1/Game/release/S4DF/version.ini";
        WebClient wc = new WebClient();
        Point formPosition;
        bool mauseAction;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public S4LeagueDF()
        {
            InitializeComponent();
            //Download progress
            backgroundWorker1.RunWorkerAsync();

        }

        //Makes the form dragable
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //Delete File
        static bool deleteFile(string f)
        {
            try
            {
                File.Delete(f);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }
        //192.99.27.178
        #region Update1
        //background Worker: Handles downloading the updates
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Defines the server's update directory
            //string Server = "http://127.0.0.1/Game/Patchs/";

            ////Defines application root
            //string Root = AppDomain.CurrentDomain.BaseDirectory;

            //Make sure version file exists
            FileStream fs = null;
            if (!File.Exists("launcher.ini"))
            {
                using (fs = File.Create("launcher.ini"))
                {

                }

                using (StreamWriter sw = new StreamWriter("launcher.ini"))
                {
                    sw.Write("1.0");
                }
            }
            //checks client version
            string lclVersion;
            using (StreamReader reader = new StreamReader("launcher.ini"))
            {
                lclVersion = reader.ReadLine();
            }
            decimal localVersion = decimal.Parse(lclVersion);

            //server's list of updates
            XDocument serverXml = XDocument.Load(@Server + "Updates.xml");

            //The Update Process
            foreach (XElement update in serverXml.Descendants("update"))
            {
                string version = update.Element("version").Value;
                string file = update.Element("file").Value;

                //string file2 = update.Element("file2").Value;

                decimal serverVersion = decimal.Parse(version);


                string sUrlToReadFileFrom = Server + file;

                string sFilePathToWriteFileTo = Root + file;

                if (serverVersion > localVersion)
                {
                    Uri url = new Uri(sUrlToReadFileFrom);
                    System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                    System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
                    response.Close();

                    Int64 iSize = response.ContentLength;

                    Int64 iRunningByteTotal = 0;

                    using (System.Net.WebClient client = new System.Net.WebClient())
                    {
                        using (System.IO.Stream streamRemote = client.OpenRead(new Uri(sUrlToReadFileFrom)))
                        {
                            using (Stream streamLocal = new FileStream(sFilePathToWriteFileTo, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                int iByteSize = 0;
                                byte[] byteBuffer = new byte[iSize];
                                while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                                {
                                    streamLocal.Write(byteBuffer, 0, iByteSize);
                                    iRunningByteTotal += iByteSize;

                                    double dIndex = (double)(iRunningByteTotal);
                                    double dTotal = (double)byteBuffer.Length;
                                    double pbInstall = (dIndex / dTotal);
                                    int iProgressPercentage = (int)(pbInstall * 100);

                                    backgroundWorker1.ReportProgress(iProgressPercentage);
                                }

                                streamLocal.Close();
                            }

                            streamRemote.Close();
                        }
                    }

                    //unzip
                    using (ZipFile zip = ZipFile.Read(file))
                    {
                        foreach (ZipEntry zipFiles in zip)
                        {
                            zipFiles.Extract(Root, true);
                        }
                    }


                    //Delete Zip File
                    deleteFile(file);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btnStart1.Enabled = false;
            btnStart0.Enabled = false;
            RECARGAR_0.Enabled = false;
            RECARGAR_1.Enabled = false;
            WEBSITE_1.Enabled = false;
            WEBSITE_0.Enabled = false;
            //pbDownload.Value = 0;
            pbDownload.Value = e.ProgressPercentage;
            PLAYCOMPLETE.Visible = false;
            DOWNLOADUPDATES.Visible = true;
            //LangFrance.Enabled = false;
            //LangGerm.Enabled = false;
            //LangITa.Enabled = false;
            //LangSpa.Enabled = false;
            //LangUSA.Enabled = false;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbInstall.Increment(100);
            pbDownload.Value = 100;
            btnStart1.Enabled = true;
            btnStart0.Enabled = true;
            DOWNLOADUPDATES.Visible = false;
            PLAYCOMPLETE.Visible = true;
            //LangFrance.Enabled = true;
            //LangGerm.Enabled = true;
            //LangITa.Enabled = true;
            //LangSpa.Enabled = true;
            //LangUSA.Enabled = true;
            RECARGAR_0.Enabled = true;
            RECARGAR_1.Enabled = true;
            WEBSITE_1.Enabled = true;
            WEBSITE_0.Enabled = true;
            //download new version file
            WebClient webClient = new WebClient();
            webClient.DownloadFile(Server + "update.ini", @Root + "launcher.ini");

        }

        #endregion

        #region Launcher

        private void S4Launcher_MouseMove(object sender, MouseEventArgs e)
        {
            if (mauseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }

        private void S4Launcher_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mauseAction = true;
        }

        private void S4Launcher_MouseUp(object sender, MouseEventArgs e)
        {
            mauseAction = false;
        }

        private void bntStart0_MouseHover(object sender, EventArgs e)
        {
            btnStart0.Visible = false;
            btnStart1.Visible = true;
            
        }

        private void bntStart1_MouseLeave(object sender, EventArgs e)
        {
            btnStart1.Visible = false;
            btnStart0.Visible = true;

        }

        private void btn_close0_MouseHover(object sender, EventArgs e)
        {
            btn_close1.Visible = true;
            btn_close0.Visible = false;
        }

        private void btn_close1_MouseLeave(object sender, EventArgs e)
        {
            btn_close0.Visible = true;
            btn_close1.Visible = false;
        }

        private void btn_register0_MouseHover(object sender, EventArgs e)
        {
            RECARGAR_1.Visible = true;
            RECARGAR_0.Visible = false;
        }

        private void btn_register1_MouseLeave(object sender, EventArgs e)
        {
            RECARGAR_0.Visible = true;
            RECARGAR_1.Visible = false;
        }

        private void btn_website1_Click(object sender, EventArgs e)
        {
            Process.Start("http://127.0.0.1/");
        }

        private void btn_register1_Click(object sender, EventArgs e)
        {
            Process.Start("http://127.0.0.1/V&D/");
        }

        private void bntStart1_Click(object sender, EventArgs e)
        {
            Process.Start("S4Client.exe", "-" + "rc:eu" + "  -" + "lac:spa" + "  -auth_server_ip:127.0.0.1");
            Close();
        }

        private void btn_close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void REGISTRARSE_0_MouseHover(object sender, EventArgs e)
        {
            REGISTRARSE_0.Visible = false;
            REGISTRARSE_1.Visible = true;
        }

        private void REGISTRARSE_1_MouseLeave(object sender, EventArgs e)
        {
            REGISTRARSE_0.Visible = true;
            REGISTRARSE_1.Visible = false;
        }

        private void SPA_0_MouseHover(object sender, EventArgs e)
        {
            SPA_0.Visible = false;
            SPA_1.Visible = true;
        }

        private void SPA_1_MouseLeave(object sender, EventArgs e)
        {
            SPA_0.Visible = true;
            SPA_1.Visible = false;

        }

        private void USA_0_MouseHover(object sender, EventArgs e)
        {
            USA_0.Visible = false;
            USA_1.Visible = true;
        }

        private void USA_1_MouseLeave(object sender, EventArgs e)
        {
            USA_0.Visible = true;
            USA_1.Visible = false;

        }

        private void SPA_1_Click(object sender, EventArgs e)
        {
            //Uri URLspa = new Uri("http://127.0.0.1/Game/Lang/es/StartGameLauncher.bat");
            //wc.DownloadFileAsync(URLspa, "StartGameLauncher.bat");
            btnStart02.Visible = false;
            btnStart1.Visible = true;
            btnStart0.Visible = true;
            USA_1.Visible = false;
            SPA_1.Visible = true;

        }

        private void USA_1_Click(object sender, EventArgs e)
        {

            //Uri URLUSA = new Uri("http://127.0.0.1/Game/Lang/en/StartGameLauncher.bat");
            //wc.DownloadFileAsync(URLUSA, "StartGameLauncher.bat");
            //btnStart02.Visible = true;
            btnStart2.Visible = true;
            btnStart0.Visible = false;
            USA_1.Visible = true;
            SPA_1.Visible = false;
        }

        private void WEBSITE_0_MouseHover(object sender, EventArgs e)
        {
            WEBSITE_0.Visible = false;
            WEBSITE_1.Visible = true;
        }

        private void WEBSITE_1_MouseLeave(object sender, EventArgs e)
        {
            WEBSITE_0.Visible = true;
            WEBSITE_1.Visible = false;
        }

        private void WEBSITE_1_Click(object sender, EventArgs e)
        {
            Process.Start("http://127.0.0.1/");
        }

        private void REGISTRARSE_1_Click(object sender, EventArgs e)
        {
            Process.Start("http://127.0.0.1/");
        }

        #endregion

        #region OLDSTART
        private void LangSpa_CheckedChanged(object sender, EventArgs e)
        {
            Uri URLspa = new Uri("http://s4df.ml/Game/Lang/es/StartGameLauncher.bat");
            wc.DownloadFileAsync(URLspa, "StartGameLauncher.bat");
        }

        private void LangITa_CheckedChanged(object sender, EventArgs e)
        {
            Uri URLita = new Uri("http://s4df.ml/Game/Lang/Italy/StartGameLauncher.bat");
            wc.DownloadFileAsync(URLita, "StartGameLauncher.bat");
        }

        private void LangFrance_CheckedChanged(object sender, EventArgs e)
        {
            Uri URLfra = new Uri("http://s4df.ml/Game/Lang/France/StartGameLauncher.bat");
            wc.DownloadFileAsync(URLfra, "StartGameLauncher.bat");
        }

        private void LangUSA_CheckedChanged(object sender, EventArgs e)
        {
            Uri URLUSA = new Uri("http://s4df.ml/Game/Lang/en/StartGameLauncher.bat");
            wc.DownloadFileAsync(URLUSA, "StartGameLauncher.bat");
        }

        private void LangGerm_CheckedChanged(object sender, EventArgs e)
        {
            Uri URLger = new Uri("http://s4df.ml/Game/Lang/Germany/StartGameLauncher.bat");
            wc.DownloadFileAsync(URLger, "StartGameLauncher.bat");
        }

        #endregion

        private void S4LeagueDF_Load(object sender, EventArgs e)
        {
           //updater.CheckForUpdates();
           VersionClient();
            CleanUp();

            if (btnStart2.Visible == true)
            {
                btnStart0.Visible = false;
                btnStart1.Visible = false;
                btnStart02.Visible = true;
                btnStart2.Visible = true;
            }
            else
            {
                btnStart1.Visible = false;
                btnStart0.Visible = true;
                //btnStart2.Visible = false;
            }
        }

        public void VersionClient()
        {
            try
            {
                WebClient downloadClient = new WebClient();
                //Uri VersionGame = new Uri("http://127.0.0.1/Game/release/S4DF/version.ini");
                //wc.DownloadFileAsync(VersionGame, "version.ini");
                downloadClient.DownloadFile(UpdateUrl, LocalUpdateFile);
                downloadClient.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("¡Error Message: " + e.Message + "\nFailed to download version.ini" + "!\n¡Comunicate con el servidor! " + " Communicate with the erver!", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            Process.Start("S4Client.exe", "-" + "rc:eu" + "  -" + "lac:eng" + "  -auth_server_ip:127.0.0.1");
            Close();
        }

        private void btnStart02_MouseHover(object sender, EventArgs e)
        {
            btnStart02.Visible = false;
            btnStart2.Visible = true;
        }

        private void btnStart2_MouseLeave(object sender, EventArgs e)
        {
            btnStart02.Visible = true;
            btnStart2.Visible = false;
        }

        private void CleanUp()
        {
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            foreach (FileInfo fi in di.GetFiles(@".\shop\*.s4", SearchOption.AllDirectories))
            {
                fi.Delete();
            }
        }
    }
}
