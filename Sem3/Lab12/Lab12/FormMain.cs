using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLambda1_Click(object sender, EventArgs e)
        {
            Func<int,int> lambda;
            lambda = x => x * x;
            textBox1.Text = lambda((int)numericUpDown1.Value).ToString();
        }

        private void buttonLambda2_Click(object sender, EventArgs e)
        {
            Func<int, int, int> lambda;
            lambda = (int a,int b) => (int)Math.Pow(a,b);
            textBox1.Text = lambda((int)numericUpDown1.Value, (int)numericUpDown2.Value).ToString();
        }

        private void buttonLambda3_Click(object sender, EventArgs e)
        {
            Func<int, int,int> lambda;
            lambda = (int a, int b) => {
                if (a > b) return b;
                else return a;
            };
            textBox1.Text = lambda((int)numericUpDown1.Value, (int)numericUpDown2.Value).ToString();
        }

        private void buttonLambda4_Click(object sender, EventArgs e)
        {
            Func<double,double,double,double> lambda;
            lambda = (double a, double b, double c) => {
                if ((a > b && a < c)||( a > c && a < b)) return a;
                else if ((b > a && b < c) || (b > c && b < a)) return b;
                else return c;
            };
            textBox1.Text = lambda((double)numericUpDown1.Value, (double)numericUpDown2.Value, (double)numericUpDown3.Value).ToString();
        }

        private void buttonLambda5_Click(object sender, EventArgs e)
        {

            Func<int, bool> lambda;
            lambda = x =>
            {
                if (x % 2 == 0) return true;
                else return false;
            };
            textBox1.Text = lambda((int)numericUpDown1.Value).ToString();
        }

        private void buttonLambda6_Click(object sender, EventArgs e)
        {
            Func<int, int,bool> lambda;
            lambda = (a,b) =>
            {
                if (b == 0) return false;
                if (a % b == 0) return true;
                else return false;
            };
            textBox1.Text = lambda((int)numericUpDown1.Value, (int)numericUpDown2.Value).ToString();
        }

        private void buttonLambda7_Click(object sender, EventArgs e)
        {
            if(textBox2.TextLength <= 1 )
            {
                Func<char, char> lambda;
                lambda = x => {
                    if (x > 95) return ((char)(x - (char)32));
                    else return x;
                };
                textBox3.Text = lambda(Convert.ToChar(textBox2.Text)).ToString();
            }
        }

        private void buttonLambda8_Click(object sender, EventArgs e)
        {
            Func<string, string> lambda;
            lambda = x => x.ToUpper() ;
            textBox3.Text = lambda(textBox2.Text);
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Wpisz tekst lub znak") textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "") textBox2.Text = "Wpisz tekst lub znak";
        }

        private void buttonLambda9_Click(object sender, EventArgs e)
        {
            Func<char> lambda;
            lambda = () => {
                licznik++;
                if (licznik == 123) licznik = 97;
                return (char)licznik;
            };
            textBox3.Text = lambda().ToString();
        }
        int licznik = 96;
    }
}
