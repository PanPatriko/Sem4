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

namespace Saper
{
    public partial class FormWyniki : Form
    {
        public FormWyniki()
        {
            InitializeComponent();
        }
        
        private void FormWyniki_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(Path.GetFileName("..\\Easy.txt"), FileMode.Open);
                StreamReader sw = new StreamReader(fs);

                    do
                    {
                        listBox1.Items.Add(sw.ReadLine());
                    } while (sw.EndOfStream != true);
                
                sw.Dispose();
                fs.Dispose();
                fs = new FileStream(Path.GetFileName("..\\Medium.txt"), FileMode.Open);
                sw = new StreamReader(fs);

                    do
                    {
                        listBox2.Items.Add(sw.ReadLine());
                    } while (sw.EndOfStream != true);
                
                sw.Dispose();
                fs.Dispose();
                fs = new FileStream(Path.GetFileName("..\\Hard.txt"), FileMode.Open);
                sw = new StreamReader(fs);
          
                    do
                    {
                        listBox3.Items.Add(sw.ReadLine());
                    } while (sw.EndOfStream != true);
                
                sw.Dispose();
                fs.Dispose();
            }
             catch(Exception)
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            File.Delete(Path.GetFileName("..\\Easy.txt"));
            File.Delete(Path.GetFileName("..\\Medium.txt"));
            File.Delete(Path.GetFileName("..\\Hard.txt"));
        }
    }
}
