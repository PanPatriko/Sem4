using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private ErrorProvider errprov = new ErrorProvider();

        private void ButtonCalcSqrField_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxA.Text, out double a))
            {                
                errprov.SetError(this.textBoxA, "Niepoprawne dane");
            }
            else
            {
                errprov.Clear();
                label1.Text = "";
                label2.Text = "";
                try
                {
                    Calculations calc = new Calculations();
                    label1.Text = "Pole kwadratu:\r\n" + a.ToString() + "*" + a.ToString() + "=" + calc.SquareField(a).ToString();
                }
                catch (ArgumentException ex)
                {
                    label2.Text = ex.ToString();
                    MathExceptions mathE = new MathExceptions();
                    mathE.WriteToFile(ex.ToString());
                }
            }
        }

        private void ButtonMult_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxA.Text, out double a))
            {
                errprov.SetError(this.textBoxA, "Niepoprawne dane");
            }
            else if (!double.TryParse(textBoxB.Text, out double b))
            {
                errprov.SetError(this.textBoxB, "Niepoprawne dane");
            }
            else
            {
                    label1.Text = "";
                    label2.Text = "";
                    errprov.Clear();
                    Calculations calc = new Calculations();
                    label1.Text = a.ToString() + "*" + b.ToString() + "=" + calc.Multiply(a, b).ToString();
            }
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxA.Text, out double a))
            {
                errprov.SetError(this.textBoxA, "Niepoprawne dane");
            }
            else if (!double.TryParse(textBoxB.Text, out double b))
            {
                errprov.SetError(this.textBoxB, "Niepoprawne dane");
            }
            else
            {
                errprov.Clear();
                label1.Text = "";
                label2.Text = "";
                try
                {
                    Calculations calc = new Calculations();
                    label1.Text = a.ToString() + "/" + b.ToString() + "=" + calc.Division(a, b).ToString();
                }
                catch (DivideByZeroException ex)
                {
                    label2.Text = ex.ToString();
                    MathExceptions mathE = new MathExceptions();
                    mathE.WriteToFile(ex.ToString());
                }
            }
        }
        private void ButtonCalcTrgCirc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxA.Text, out double a))
            {
                errprov.SetError(this.textBoxA, "Niepoprawne dane");
            }
            else if (!double.TryParse(textBoxB.Text, out double b))
            {
                errprov.SetError(this.textBoxB, "Niepoprawne dane");
            }
            else if (!double.TryParse(textBoxC.Text, out double c))
            {
                errprov.SetError(this.textBoxC, "Niepoprawne dane");
            }
            else
            {
                errprov.Clear();
                label1.Text = "";
                label2.Text = "";
                try
                {

                    Calculations calc = new Calculations();
                    label1.Text = "Obwód trójkata:\r\n" + a.ToString() + "+" + b.ToString() + "+" + c.ToString() + "=" + calc.TriangleCircuit(a, b, c).ToString();
                }
                catch (Exception ex)
                {
                    label2.Text = ex.ToString();
                    MathExceptions mathE = new MathExceptions();
                    mathE.WriteToFile(ex.ToString());
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Errors.txt"))
                Process.Start(Directory.GetCurrentDirectory() + "\\Errors.txt");
            else label2.Text = "Plik Errors.txt nie istnieje";
        }
    }
}
