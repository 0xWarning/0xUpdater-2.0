using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0xUpdater_2._0
{
    public partial class Form1 : Form
    {
        string UVer = "0.0.0.1";
        string filename = "Update.zip";

        public Form1()
        {
            InitializeComponent();
        }

        void DoStuff()
        {
            var startProgb = new Thread(Startprog);
            startProgb.Start();
            Thread.Sleep(500);
            var UpdateThr = new Thread(Update);
            UpdateThr.Start();
        }


        void Startprog()
        {
            int total = 100;
            for (int i = 0; i <= total; i++)
            {
                Thread.Sleep(100);
                animaProgressBar1.Increment(1);
            }
            MessageBox.Show("Complete");

        }

        void Update()
        {
            WebClient webClient = new WebClient();
            string url = "http://Website/check.php?version=" + UVer;
            if ( UVer != webClient.DownloadString(url))
            {
                MessageBox.Show("Updating !", "Update Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                webClient.DownloadFile("http://website/file.zip", filename);
                if (animaCheckBox1.Checked == true)
                {
                    ZipFile.ExtractToDirectory(filename, Application.StartupPath + "/New");
                }

            }

        }


        private void AnimaButton2_Click(object sender, EventArgs e)
        {
            var startProgb = new Thread(DoStuff);
            startProgb.Start();
        }

        private void AutoUBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AnimaForm2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (AutoUBox.Checked == true)
            {
                var startProgb = new Thread(DoStuff);
                startProgb.Start();
            }
        }

        private void DelPFBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AnimaGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void AnimaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
