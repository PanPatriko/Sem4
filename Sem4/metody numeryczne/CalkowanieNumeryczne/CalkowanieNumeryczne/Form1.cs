using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalkowanieNumeryczne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxIntegralA.Text,out double x0))
            {
                label3.Text = "Błąd - całka";
            }
            else if (!double.TryParse(textBoxIntegralB.Text, out double xn))
            {
                label3.Text = "Błąd - całka";
            }
            else if (x0 >= xn) label3.Text = "Błąd - niepoprawny przedział całki";
            else if (!double.TryParse(textBoxX3.Text, out double x3))
            {
                label3.Text = "Błąd - niepoprawna wartość x^3";
            }
            else if (!double.TryParse(textBoxX2.Text, out double x2))
            {
                label3.Text = "Błąd - niepoprawna wartość x^2";
            }
            else if (!double.TryParse(textBoxX.Text, out double x1))
            {
                label3.Text = "Błąd - niepoprawna wartość x";
            }
            else if (!double.TryParse(textBoxC.Text, out double c))
            {
                label3.Text = "Błąd - niepoprawna wartość c";
            }
            else
            {
                double h = (xn - x0) / (2 * (int)numericUpDown1.Value);
                //label3.Text = h.ToString();
                double[] xarray = new double[(int)numericUpDown1.Value * 2 + 1];
                xarray[0] = x0;
                xarray[xarray.Length-1] = xn;
                for (int i =1;i<xarray.Length-1;i++)
                {
                    xarray[i] = xarray[i - 1] + h;
                }
                double[] fxarray = new double[xarray.Length];
                for (int i = 0; i < fxarray.Length; i++)
                {
                    fxarray[i] = Calculate(xarray[i],x3,x2,x1,c);
                }
                double result = fxarray[0] + fxarray[fxarray.Length - 1];
                double odd = 0, even = 0;
                for(int i = 1; i < fxarray.Length-1; i++)
                {
                    if (i % 2 == 0) even += fxarray[i];
                    else odd += fxarray[i];
                }
                result += odd * 4 + even * 2;
                result *= h / 3;
                label3.Text = result.ToString();
            }

        }
        private double Calculate(double x,double x3,double x2,double x1,double c)
        {
             return x3 * Math.Pow(x, 3) + x2 * Math.Pow(x, 2) + x1 * x + c;             
        }
        private double Calculate2(double x, double x3, double x2, double x1, double c)
        {
            return Math.Sin(x/2) + x3 * Math.Pow(x, 3) + x2 * Math.Pow(x, 2) + x1 * x + c +Math.Sqrt(x);
        }
        private void ButtonCalculate2_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(textBoxIntegralA2.Text, out double x0))
            {
                label9.Text = "Błąd - całka";
            }
            else if (!double.TryParse(textBoxIntegralB2.Text, out double xn))
            {
                label9.Text = "Błąd - całka";
            }
            else if (x0 >= xn) label9.Text = "Błąd - niepoprawny przedział całki";
            else if (!double.TryParse(textBox2X3.Text, out double x3))
            {
                label9.Text = "Błąd - niepoprawna wartość x^3";
            }
            else if (!double.TryParse(textBox2X2.Text, out double x2))
            {
                label9.Text = "Błąd - niepoprawna wartość x^2";
            }
            else if (!double.TryParse(textBox2X.Text, out double x1))
            {
                label9.Text = "Błąd - niepoprawna wartość x";
            }
            else if (!double.TryParse(textBox2C.Text, out double c))
            {
                label9.Text = "Błąd - niepoprawna wartość c";
            }
            else
            {
                double h = (xn - x0) / (2 * (int)numericUpDown2.Value);
                //label3.Text = h.ToString();
                double[] xarray = new double[(int)numericUpDown2.Value * 2 + 1];
                xarray[0] = x0;
                xarray[xarray.Length - 1] = xn;
                for (int i = 1; i < xarray.Length - 1; i++)
                {
                    xarray[i] = xarray[i - 1] + h;
                }
                double[] fxarray = new double[xarray.Length];
                for (int i = 0; i < fxarray.Length; i++)
                {
                    fxarray[i] = Calculate2(xarray[i], x3, x2, x1, c);
                }
                double result = fxarray[0] + fxarray[fxarray.Length - 1];
                double odd = 0, even = 0;
                for (int i = 1; i < fxarray.Length - 1; i++)
                {
                    if (i % 2 == 0) even += fxarray[i];
                    else odd += fxarray[i];
                }
                result += odd * 4 + even * 2;
                result *= h / 3;
                label9.Text = result.ToString();
            }
        }
    }
}
