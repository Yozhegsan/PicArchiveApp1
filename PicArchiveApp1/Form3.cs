using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicArchiveApp1
{
    public partial class frmFind : Form
    {
        int rBorder, dBorder;
        List<Image> imgList = new List<Image>();
        string ShowPic;
        public frmFind()
        {
            InitializeComponent();
        }

        private void frmFind_Load(object sender, EventArgs e)
        {
            this.Activate();
            rBorder = this.Width - picMain.Width - picMain.Left;
            dBorder = this.Height - picMain.Height - picMain.Top;
        }

        private void frmFind_Resize(object sender, EventArgs e)
        {
            picMain.Width = this.Width - picMain.Left - rBorder;
            picMain.Height = this.Height - picMain.Top - dBorder;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(txtFind.Text.Length==0 || txtFind.Text.Equals("*"))
            {
                txtFind.Text = "*.*";
            }
            lstFiles.Items.Clear();
            if (txtFind.Text.Length > 1 & TestFindName())
            {
                txtFind.BackColor = Color.FromName("Window");
                string[] allFoundFiles = Directory.GetFiles(Program.ArchiveFolder, "*" + txtFind.Text + "*.zip", SearchOption.TopDirectoryOnly);
                foreach (string file in allFoundFiles)
                {
                    lstFiles.Items.Add(CutName(file));
                }
                if(lstFiles.Items.Count != 0)
                {
                    lstFiles.SetSelected(0, true);
                }
            }
            else
            {
                txtFind.BackColor = Color.Red;
            }
        }

        private bool TestFindName()
        {
            string Etalon = "abcdefghijklmnopqrstuvwxyz1234567890.*_";
            string s = txtFind.Text.ToLower();
            bool b = false;
            int i = 0, j = 0;
            for (i = 0; i < s.Length - 1; i++)
            {
                b = false;
                for (j = 0; j < Etalon.Length - 1; j++)
                {
                    if (s[i].Equals(Etalon[j]))
                    {
                        b = true;
                        break;
                    }
                }
                if (b == false)
                {
                    break;
                }
            }
            return b;
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lstFiles.Enabled = false;
            picMain.Image = null;
            ReadData(lstFiles.Items[lstFiles.SelectedIndex].ToString());
            lstPic.Items.Clear();
            string[] allFoundFiles = Directory.GetFiles(Program.DataFolder, "*.jpg", SearchOption.TopDirectoryOnly);
            foreach (string file in allFoundFiles)
            {
                lstPic.Items.Add(CutName(file));
            }
            txtComments.Text = File.ReadAllText(Program.DataFolder + "\\Comments.txt");
            //lstFiles.Enabled = true;
        }

        private String CutName(string LongPath)
        {
            int n = LongPath.LastIndexOf('\\')+1;
            return LongPath.Substring(n);
        }

        private void ClearDir()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Program.DataFolder);
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
        }

        private void UnPackZIP(string zipFile) // .NET 4.5 нада силку на System.IO.Compression.FileSystem
        {
            ZipFile.ExtractToDirectory(zipFile, Program.DataFolder);
        }

        private void lstPic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPic = Program.DataFolder + "\\" + lstPic.Items[lstPic.SelectedIndex];
            picMain.ImageLocation = ShowPic;
        }

        private void picMain_DoubleClick(object sender, EventArgs e)
        {
            if(picMain.Image!=null)
            {
                Process.Start(ShowPic);
            }
        }

        private void ReadData(String fn)
        {
            ClearDir();
            UnPackZIP(Program.ArchiveFolder + "\\" + fn);
        }
    }
}
