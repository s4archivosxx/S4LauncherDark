using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UpdaterGame.Data;

namespace UpdateMaker
{
    public partial class FUpdaterM : Form
    {
        Point formPosition;
        bool mauseAction;

        public FUpdaterM()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lvItem = new ListViewItem(new String[] { txtName.Text, txtDesc.Text });
            listView1.Items.Add(lvItem);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            UpdateSaveFile file = new UpdateSaveFile(txtVersion.Text);
            foreach (ListViewItem item in listView1.Items)
            {
                file.UpdateFileCollection.Add(new UpdateFileInfo(item.SubItems[0].Text, item.SubItems[1].Text));
            }
            BinaryFormatter bf = new BinaryFormatter();
            FileStream bfStream = File.Open(@".\UpdateInfo.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(bfStream, file);
            bfStream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            //CleanUp();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mauseAction = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mauseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mauseAction = false;
        }

        private void txtVersion_TextChanged(object sender, EventArgs e)
        {
            //txtVersion.Text = Application.ProductVersion;
        }

        private void CleanUp()
        {
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            foreach (FileInfo fi in di.GetFiles("*.dat", SearchOption.AllDirectories))
            {
                fi.Delete();
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            CleanUp();
        }

        private void OpenFile()
        {
            OpenFileDialog Open = new OpenFileDialog();
            //ListViewItem lvItem = new ListViewItem(new String[] { txtName.Text, txtDesc.Text });
            //listView1.Items.Add(lvItem);
            StreamReader  myStreamReader;
            Open.Filter = "Dat [*.dat*]|*.dat|All Files [*.*]|*.*|Txt[*.txt*]|*.txt";
            Open.CheckFileExists = true;
            Open.Title = "Open File";
            Open.ShowDialog();

            try
            {
                Open.OpenFile();
                ListViewItem lvItem = new ListViewItem(new String[] { txtName.Text, txtDesc.Text });
                listView1.Items.Add(lvItem);
            }

            catch (Exception e)
            {
                //throw new InvalidDataException("El Archivo de Actualización de información local está dañado!", e);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
    }
}
