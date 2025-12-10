using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodaStycznych
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
                textBoxWynik.Text = Styczne().ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Błąd - Niepełne dane");
            }
        }

        private double Styczne()
        {
            double x1, x2;
            if (!double.TryParse(textBoxA.Text, out double a))
            {
                MessageBox.Show("Błąd - Niepoprawna wartość A");
                return 0;
            }
            if (!double.TryParse(textBoxB.Text, out double b))
            {
                MessageBox.Show("Błąd - Niepoprawna wartość B");
                return 0;
            }
            if (!double.TryParse(textBoxE.Text, out double e))
            {
                MessageBox.Show("Błąd - Niepoprawna wartość Epsilon");
                return 0;
            }
            else if (e <= 0)
            {
                MessageBox.Show("Epsilon musi byc wiekszy niz 0");
                return 0;
            }
            if (Oblicz(a) < 0 && Oblicz(b) > 0 && ObliczPochodna2(b) > 0)
            {
                x1 = b;
            }
            else if(Oblicz(a) > 0 && Oblicz(b) < 0 && ObliczPochodna2(a) > 0)
            {
                x1 = a;
            }
            else if (Oblicz(a) > 0 && Oblicz(b) < 0 && ObliczPochodna2(b) < 0)
            {
                x1 = b;
            }
            else if (Oblicz(a) < 0 && Oblicz(b) > 0 && ObliczPochodna2(a) < 0)
            {
                x1 = a;
            }
            else
            {
                MessageBox.Show("Niepoprawny przedział");
                return 0;
            }
            x2 = x1 - Oblicz(x1) / ObliczPochodna(x1);
            while (Math.Abs(x2-x1) > e)
            {
                x1 = x2;
                x2 = x2 - Oblicz(x2) / ObliczPochodna(x2);
            }
            return x2;
        }
        private double Oblicz(double x)
        {
            double x6 = Convert.ToDouble(textBoxX6.Text);
            double x5 = Convert.ToDouble(textBoxX5.Text);
            double x4 = Convert.ToDouble(textBoxX4.Text);
            double x3 = Convert.ToDouble(textBoxX3.Text);
            double x2 = Convert.ToDouble(textBoxX2.Text);
            double x1 = Convert.ToDouble(textBoxX.Text);
            double c = Convert.ToDouble(textBoxC.Text);
            return x6 * Math.Pow(x, 6) + x5 * Math.Pow(x, 5) + x4 * Math.Pow(x, 4) + x3 * Math.Pow(x, 3) + x2 * Math.Pow(x, 2) + x1 * x + c;
        }
        private double ObliczPochodna(double x)
        {
            double x6 = Convert.ToDouble(textBoxX6.Text);
            double x5 = Convert.ToDouble(textBoxX5.Text);
            double x4 = Convert.ToDouble(textBoxX4.Text);
            double x3 = Convert.ToDouble(textBoxX3.Text);
            double x2 = Convert.ToDouble(textBoxX2.Text);
            double x1 = Convert.ToDouble(textBoxX.Text);
            return x6 * 6 * Math.Pow(x, 5) + x5 * 5 * Math.Pow(x, 4) + x4 * 4 * Math.Pow(x, 3) + x3 * 3 * Math.Pow(x, 2) + x2 * 2 * x + x1;
        }
        private double ObliczPochodna2(double x)
        {
            double x6 = Convert.ToDouble(textBoxX6.Text);
            double x5 = Convert.ToDouble(textBoxX5.Text);
            double x4 = Convert.ToDouble(textBoxX4.Text);
            double x3 = Convert.ToDouble(textBoxX3.Text);
            double x2 = Convert.ToDouble(textBoxX2.Text);
            double x1 = Convert.ToDouble(textBoxX.Text);
            return x6 * 6 * 5 * Math.Pow(x, 4) + x5 * 5 * 4 * Math.Pow(x, 3) + x4 * 4 * 3 * Math.Pow(x, 2) + x3 * 3 * 2 * x + x2 * 2 * x;
        }
    }
}
