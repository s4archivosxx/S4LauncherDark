using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.ComponentModel;
using System.IO;
using UpdaterGame.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Windows.Forms;
using UpdaterGame2.UI;
using System.Xml.Linq;

namespace UpdaterGame2
{
    public class Updater : Component
    {
        private const String LocalUpdateFile = @".\UpdateInfo.dat";

        IniFile _ini = new IniFile("Config.hjson");

        public String UpdateUrl { get; set; }

        public String Patchs_Game = "http://localhost/Game/Patchs/";

        public void CheckForUpdates(String UpdateUrl)
        {
            try
            {
                CleanUp();

                WebClient downloadClient = new WebClient();
                downloadClient.DownloadFile(UpdateUrl, LocalUpdateFile);
                downloadClient.Dispose();

                if (!File.Exists(LocalUpdateFile))
                    throw new FileNotFoundException("El Archivo de Actualización Local no se encuentra Porfavor informar con el servidor!", LocalUpdateFile);

                UpdateSaveFile localFile = DecodeSaveFile(LocalUpdateFile);

                XDocument serverXml = XDocument.Load($"{Patchs_Game}Config.xml");

                //Version localVersion = Version.Parse(_ini.Read("Version_FilesOfTheGame", "UPDATES"));
                //Version onlineVersion = Version.Parse(localFile.VersionString);

                foreach (XElement _FilesOfTheGame in serverXml.Descendants("FilesOfTheGame"))
                {
                    string _version = _FilesOfTheGame.Element("NewVersion").Value;

                    Version localVersion = Version.Parse(_ini.Read("Version_FilesOfTheGame", "UPDATES"));

                    Version onlineVersion = Version.Parse(_version);

                    if (onlineVersion > localVersion)
                    {
                        frmUpdater updateForm = new frmUpdater(localFile, GetPath(UpdateUrl));
                        updateForm.ShowDialog();
                        Environment.Exit(0);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string GetPath(string UpdateUrl)
        {
            StringBuilder sb = new StringBuilder();
            String[] updatePieces = UpdateUrl.Split('/');
            for (int i = 0; i < updatePieces.Length -1; i++)
            {
                sb.Append(updatePieces[i] + "/");
            }
            return sb.ToString();
        }

        private UpdateSaveFile DecodeSaveFile(string LocalUpdateFile)
        {
            FileStream localFileStream = null;
                BinaryFormatter decoder = null;
                try
                {
                    localFileStream = File.Open(LocalUpdateFile, FileMode.Open, FileAccess.Read);
                    decoder = new BinaryFormatter();
                    return (UpdateSaveFile)decoder.Deserialize(localFileStream);
                }
                catch (Exception e)
                {
                    throw new InvalidDataException("El Archivo de Actualización de información local está dañado!", e);
                }
                finally
                {
                    if (localFileStream != null)
                        localFileStream.Dispose();
                }

        }

        private void CleanUp()
        {
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            foreach (FileInfo fi in di.GetFiles("*.temp", SearchOption.AllDirectories))
                {
                fi.Delete();
                }
        }
    }
}
