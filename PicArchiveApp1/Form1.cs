using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace PicArchiveApp1
{
    public partial class Form1 : Form
    {
        //List<Image> new_imageList = new List<Image>();
        //new_imageList.Add(pictureBox1.Image); //Картинку добавляем так:
        //pictureBox1.Image = new_imageList[5]; //А обратиться к нужной картинке по индексу можно так:
        List<Image> imgList = new List<Image>();
        Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
        int rBorder,dBorder;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                imgList.Add(Clipboard.GetImage());
                int n = imgList.Count;
                nUDPicSelector.Minimum = 1;
                nUDPicSelector.Maximum = n;
                nUDPicSelector.Value = n;
            }
        }

        private void SaveAsJPEG()
        {
            for (int i = 0; i < imgList.Count; i++)
            {
                picSave.Image = imgList[i];
                Bitmap bmp = new Bitmap(picSave.Width, picSave.Height);
                picSave.DrawToBitmap(bmp, new Rectangle(0, 0, picSave.Width, picSave.Height));
                var fileName = Program.DataFolder + "\\" + i.ToString() +".jpg";
                bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtACT.Text.Length > 1 & TestName())
            {
                txtACT.BackColor = Color.FromName("Window");
                SaveTextToFile();
                SaveAsJPEG();
                MakeZIP();
                ///Process.Start("explorer", AppPath);
            }
            else
            {
                txtACT.BackColor = Color.Red;
            }
        }

        private bool TestName()
        {
            string Etalon = "abcdefghijklmnopqrstuvwxyz1234567890._";
            string s = txtACT.Text.ToLower();
            bool b = false;
            int i = 0, j = 0;
            for (i = 0; i < s.Length-1; i++)
            {
                b =false;
                for (j = 0; j < Etalon.Length-1; j++)
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

        private void SaveTextToFile()
        {
            String fn1 = Program.DataFolder + "\\Comments.txt";
            File.WriteAllText(fn1, txtComments.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Activate();
            label1.Text = "Назва (не менше 2 символа)";
            rBorder = this.Width - picMain.Width - picMain.Left;
            dBorder = this.Height - picMain.Height - picMain.Top;
            picSave.Width = resolution.Width;
            picSave.Height = resolution.Height;
            ClearDir();
        }

        private void ClearDir()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Program.DataFolder);
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
        }

        private void MakeZIP() // .NET 4.5 нада силку на System.IO.Compression.FileSystem
        {
            string zipPath = Program.ArchiveFolder+ "\\" + GetName() + ".zip";
            ZipFile.CreateFromDirectory(Program.DataFolder, zipPath);
        }
        private string GetName()
        {
            String s;
            s = txtACT.Text;
            s += "_" + DateTime.Now.Year.ToString("0000") + "." + DateTime.Now.Month.ToString("00") +  "." + DateTime.Now.Day.ToString("00");
            s += "_" + DateTime.Now.Hour.ToString("00") +   "." + DateTime.Now.Minute.ToString("00") + "." + DateTime.Now.Second.ToString("00"); 
            return s;
        }

        private void nUDPicSelector_ValueChanged(object sender, EventArgs e)
        {
            picMain.Image = imgList[(int)nUDPicSelector.Value-1];
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            toolTip1.Show("Допустимі символи\nabcdefghijklmnopqrstuvwxyz\nABCDEFGHIJKLMNOPQRSTUVWXYZ\n1234567890._", txtACT, 0, txtACT.Height, 3000);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            picMain.Width = this.Width-picMain.Left-rBorder;
            picMain.Height = this.Height - picMain.Top - dBorder;
        }
    }
}
