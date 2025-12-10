using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodaBisekcji
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
                textBoxWynik.Text = Bisekcja().ToString();
            }

            catch(FormatException)
            {
                MessageBox.Show("Błąd - Niepoprawne dane");
            }
        }

        private double Bisekcja()
        {
            if (!double.TryParse(textBoxA.Text, out double a))
            {
                MessageBox.Show("Błąd - Niepoprawna wartość A");
            }
            else if (!double.TryParse(textBoxB.Text, out double b))
            {
                MessageBox.Show("Błąd - Niepoprawna wartość B");
            }
            else if (!double.TryParse(textBoxE.Text, out double e))
            {
                MessageBox.Show("Błąd - Niepoprawna wartość Epsilon");
            }
            else if (Oblicz(a) * Oblicz(b) > 0)
            {
                MessageBox.Show("Funkcja nie spelnia wymogu");
            }
            else if (e <= 0)
            {
                MessageBox.Show("Epsilon musi byc wiekszy niz 0");
            }
            else
            {
                while (b - a > e)
                {
                    double srodek = (a + b) / 2;
                    if (Oblicz(a) == 0.0) return a;
                    if (Oblicz(b) == 0.0) return b;
                    if (Oblicz(srodek) == 0.0) return srodek;
                    if (Oblicz(a) * Oblicz(srodek) < 0)
                    {
                        b = srodek;
                    }
                    else a = srodek;
                }
                return (a + b) / 2;
            }
            return 0;

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

    }
}
