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

namespace Lab11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        string pathMP3;
        string pathTXT;
        StreamReader sr;

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pathMP3 = openFileDialog1.FileName;
            pathTXT = Path.ChangeExtension(pathMP3, "txt");
            player.URL = pathMP3;
            player.controls.play();
            sr = new StreamReader(pathTXT);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sr.EndOfStream==true)
            {
                timer1.Stop();
                sr.Dispose();
                textBox1.Text = "";
                player.controls.stop();
                timer1.Interval = 100;
            }
            else
            {
                timer1.Interval = Convert.ToInt32(sr.ReadLine());
                textBox1.Text = sr.ReadLine();
            }

        }
    }
}
