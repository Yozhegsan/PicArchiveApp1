using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicArchiveApp1
{
    public partial class Form2 : Form
    {
        String AppPath = Application.StartupPath.ToString();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            this.WindowState = FormWindowState.Minimized;
            DialogResult dr = newForm1.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnFinf_Click(object sender, EventArgs e)
        {
            frmFind newForm2 = new frmFind();
            this.WindowState = FormWindowState.Minimized;
            DialogResult dr = newForm2.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Program.DataFolder = AppPath + "\\Data";
            if (!Directory.Exists(Program.DataFolder))
            {
                Directory.CreateDirectory(Program.DataFolder);
            }
            Program.ArchiveFolder= Application.StartupPath.ToString() + "\\Archive";
            if (!Directory.Exists(Program.ArchiveFolder))
            {
                Directory.CreateDirectory(Program.ArchiveFolder);
            }
        }
    }
}
