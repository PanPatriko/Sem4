using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Zespolone liczba1;
        Zespolone liczba2;
        private void buttonZapisz_Click(object sender, EventArgs e)
        {

            try
            {
                liczba1 = new Zespolone(Convert.ToDouble(textBoxR1.Text), Convert.ToDouble(textBoxU1.Text));
                liczba2 = new Zespolone(Convert.ToDouble(textBoxR2.Text), Convert.ToDouble(textBoxU2.Text));
                foreach (Control button in Controls)
                {
                    if (button is Button) button.Enabled = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Niepoprawne dane");
            }



        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Zespolone wynik = liczba1 + liczba2;
            if(wynik.Urojona<0)
            {
                labelWynik.Text = wynik.Rzeczywista+""+wynik.Urojona+"i";
            }
            else
            labelWynik.Text = wynik.Rzeczywista+"+"+wynik.Urojona+"i";
        }

        private void buttonOdejmij_Click(object sender, EventArgs e)
        {
            Zespolone wynik = liczba1 - liczba2;
            if (wynik.Urojona < 0)
            {
                labelWynik.Text = wynik.Rzeczywista + "" + wynik.Urojona + "i";
            }
            else
                labelWynik.Text = wynik.Rzeczywista + "+" + wynik.Urojona + "i";
        }

        private void buttonPomnoz_Click(object sender, EventArgs e)
        {
            Zespolone wynik = liczba1 * liczba2;
            if (wynik.Urojona < 0)
            {
                labelWynik.Text = wynik.Rzeczywista + "" + wynik.Urojona + "i";
            }
            else
                labelWynik.Text = wynik.Rzeczywista + "+" + wynik.Urojona + "i";
        }

        private void buttonPodziel_Click(object sender, EventArgs e)
        {
            Zespolone wynik = liczba1 / liczba2;
            if (wynik.Urojona < 0)
            {
                labelWynik.Text = wynik.Rzeczywista + "" + wynik.Urojona + "i";
            }
            else
                labelWynik.Text = wynik.Rzeczywista + "+" + wynik.Urojona + "i";
        }

        private void buttonRowne_Click(object sender, EventArgs e)
        {
            labelWynik.Text = Convert.ToString(liczba1 == liczba2);
        }

        private void buttonRozne_Click(object sender, EventArgs e)
        {
            labelWynik.Text = Convert.ToString(liczba1 != liczba2);
        }

        private void buttonWiekszy_Click(object sender, EventArgs e)
        {
            labelWynik.Text = Convert.ToString(liczba1 > liczba2);
        }

        private void buttonMniejszy_Click(object sender, EventArgs e)
        {
            labelWynik.Text = Convert.ToString(liczba1 < liczba2);
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            labelWynik.Text = Convert.ToString(liczba1.Equals(liczba2));
        }

        private void buttonGetHashCode_Click(object sender, EventArgs e)
        {
            labelWynik.Text = Convert.ToString(liczba1.GetHashCode());
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            labelWynik.Text = "Wynik";
            textBoxR1.Text = "";
            textBoxR2.Text = "";
            textBoxU1.Text = "";
            textBoxU2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelWynik.Text = "";
            if ((textBox1.Text=="r")|| (textBox1.Text == "u"))
            labelWynik.Text = Convert.ToString(liczba1[Convert.ToChar(textBox1.Text)]);
            else if ((textBox1.Text == "1")|| (textBox1.Text == "0"))
            labelWynik.Text = Convert.ToString(liczba1[Convert.ToInt32(textBox1.Text)]);
            else MessageBox.Show("Nieprawidłowy index");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelWynik.Text = "";
            if ((textBox1.Text == "r") || (textBox1.Text == "u"))
                labelWynik.Text = Convert.ToString(liczba2[Convert.ToChar(textBox1.Text)]);
            else if ((textBox1.Text == "1") || (textBox1.Text == "0"))
                labelWynik.Text = Convert.ToString(liczba2[Convert.ToInt32(textBox1.Text)]);
            else MessageBox.Show("Nieprawidłowy index");
        }

        private void button1Set_Click(object sender, EventArgs e)
        { 
                if ((textBox1.Text == "r") || (textBox1.Text == "u"))
                   liczba1[Convert.ToChar(textBox1.Text)]=(double)numericUpDown1.Value;
                else if ((textBox1.Text == "1") || (textBox1.Text == "0"))
                    liczba1[Convert.ToInt32(textBox1.Text)]= (double)numericUpDown1.Value;
                else MessageBox.Show("Nieprawidłowy index");        
        }

        private void button2Set_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "r") || (textBox1.Text == "u"))
                liczba2[Convert.ToChar(textBox1.Text)] = (double)numericUpDown1.Value;
            else if ((textBox1.Text == "1") || (textBox1.Text == "0"))
                liczba2[Convert.ToInt32(textBox1.Text)] = (double)numericUpDown1.Value;
            else MessageBox.Show("Nieprawidłowy index");
        }

        private void buttonConvertInt_Click(object sender, EventArgs e)
        {
            labelWynik.Text = Convert.ToString(liczba1);
        }

        private void buttonConvertDouble_Click(object sender, EventArgs e)
        {
            labelWynik.Text = Convert.ToString((double)liczba1);
        }

        private void buttonConvertInt2_Click(object sender, EventArgs e)
        {
            liczba1 = (int)numericUpDown2.Value;
            labelWynik.Text = Convert.ToString(liczba1);
        }

        private void buttonConvertDouble2_Click(object sender, EventArgs e)
        {
            liczba1 = (double)numericUpDown2.Value;
            labelWynik.Text = Convert.ToString((double)liczba1);
        }
    }
    
}
