using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class FormZapiszWynik : Form
    {
        string difficult;
        int time;
        public FormZapiszWynik(string difficult,int time)
        {
            InitializeComponent();
            this.difficult = difficult;
            this.time = time;
        }
        FileStream fs;
        StreamWriter sw;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (difficult)
            {
                case "Easy":
      
                    fs = new FileStream(Path.GetFileName("..\\Easy.txt"), FileMode.Append);
                    sw = new StreamWriter(fs);
                    sw.WriteLine(time.ToString() + " " + textBox1.Text);
                    sw.Dispose();
                    fs.Dispose();
                    break;
                case "Medium":
                    fs = new FileStream(Path.GetFileName("..\\Medium.txt"), FileMode.Append);
                    sw = new StreamWriter(fs);
                    sw.WriteLine(time.ToString() + " " + textBox1.Text);
                    break;
                case "Hard":
                    fs = new FileStream(Path.GetFileName("..\\Hard.txt"), FileMode.Append);
                    sw = new StreamWriter(fs);
                    sw.WriteLine(time.ToString()+" "+ textBox1.Text);
                    break;
            }
            Dispose();
        }
    }
}
