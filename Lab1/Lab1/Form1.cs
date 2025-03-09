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

namespace Lab1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.RunWorkerCompleted +=  new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }

        Bitmap image;
        int value = 0;

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            image = new Bitmap(fs);
            pictureBox1.Image = image;
            fs.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
                pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                fs.Close();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            value = trackBar1.Value;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressBar1.Value = 0;
            }
            else
            {
                pictureBox1.Image = (Bitmap)e.Result;
            }
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            pictureBox1.Image = (Bitmap)e.UserState;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result=brightnessChange(new Bitmap((Bitmap)e.Argument),value,worker,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {        
            backgroundWorker1.CancelAsync();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image!=null && backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync(image);
            }
        }

        private Bitmap brightnessChange(Bitmap image,int value,BackgroundWorker worker, DoWorkEventArgs e)
        {
            int maxPercent = image.Width * image.Height;
            int percentComplete = 0;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color c = image.GetPixel(i, j);
                    byte R = c.R;
                    byte G = c.G;
                    byte B = c.B;

                    float x = R + value * 2.55f;
                    if (x > 255) R = 255;
                    else if (x < 0) R = 0;
                    else R = Convert.ToByte(x);
                    x = G + value * 2.55f;
                    if (x > 255) G = 255;
                    else if (x < 0) G = 0;
                    else G = Convert.ToByte(x);
                    x = B + value * 2.55f;
                    if (x > 255) B = 255;
                    else if (x < 0) B = 0;
                    else B = Convert.ToByte(x);

                    Color c2 = Color.FromArgb(R, G, B);

                    image.SetPixel(i, j, c2);
                  //  pictureBox1.Image = image;
                }
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return image = null ;
                }
                else
                {
                    percentComplete = (int)((float)((i + 1) * image.Height+1) / maxPercent * 100);
                    worker.ReportProgress(percentComplete,new Bitmap(image));
                    System.GC.Collect();                   
                }
            }            
            return image;
        }



    }
}
