using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBoxNum1.Text);
                double num2 = Convert.ToDouble(textBoxNum2.Text);
                double wynik = num1 + num2;
                textBoxResult.Text = wynik.ToString();
            }
            catch(FormatException)
            {
                textBoxResult.Text = "Błąd";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBoxNum1.Text);
                double num2 = Convert.ToDouble(textBoxNum2.Text);
                double wynik = num1 - num2;
                textBoxResult.Text = wynik.ToString();
            }
            catch (FormatException)
            {
                textBoxResult.Text = "Błąd";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBoxNum1.Text);
                double num2 = Convert.ToDouble(textBoxNum2.Text);
                double wynik = num1 * num2;
                textBoxResult.Text = wynik.ToString();
            }
            catch (FormatException)
            {
                textBoxResult.Text = "Błąd";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBoxNum1.Text);
                double num2 = Convert.ToDouble(textBoxNum2.Text);
                double wynik = num1 / num2;
                textBoxResult.Text = wynik.ToString();
            }
            catch (FormatException)
            {
                textBoxResult.Text = "Błąd";
            }
        }


    }
}
