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
    }
    
}
