using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class FormMain : Form
    {

        public Dictionary<String, String> Slownik = new Dictionary<String, String>();
        List<String> Historia = new List<String>();
        public void DodajDoSlownika(String slowoAng,String slowoPl)
        {
            Slownik.Add(slowoAng, slowoPl);           
        }
        public String PobierzSlowo(String klucz)
        {
            return Slownik[klucz];
        }
        public List<String> PobierzKlucze()
        {
            return new List<String>(Slownik.Keys);
        }
        public int PobierzDlugosc()
        {
            return Slownik.Count;
        }

        public FormMain()
        {
            InitializeComponent();
            Slownik.Add("Apple", "Jabłko");
            Slownik.Add("Air", "Powietrze");
            Slownik.Add("Book","Książka");
            Slownik.Add("Black",  "Czarny");
            Slownik.Add("Car",  "Samochód");
            Slownik.Add("Clock",  "Zegar");
            Slownik.Add("December",  "Grudzień");
            Slownik.Add("Door",  "Drzwi");
            Slownik.Add("Elephant",  "Słoń");
            Slownik.Add("Ear",  "Ucho");
            Slownik.Add("Fan", "Wentylator");
            Slownik.Add("Fear", "Strach");
        }


        private void FormLab3_Load(object sender, EventArgs e)
        {

        }

        private void textBoxWyszukaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWyszukaj_Click(object sender, EventArgs e)
        {
            Historia.Add(textBoxWyszukaj.Text);
            labelSlowo.Text = "...";
            labelHistoria.Text = labelHistoria.Text + "\r\n" + Historia[Historia.Count - 1];
            if (radioButtonAng.Checked == true)
            {
                try
                {
                    labelSlowo.Text = Slownik[textBoxWyszukaj.Text];
                }
                catch (Exception)
                {

                }
            }
            else
            foreach (KeyValuePair<String, String> x in Slownik)
            {
                if (textBoxWyszukaj.Text == x.Value)
                {
                    labelSlowo.Text = x.Key;
                }               
            }
        }
        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            Historia.Clear();
            labelHistoria.Text = "Historia";
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormDodaj Dodaj = new FormDodaj(this);
            Dodaj.ShowDialog();
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            FormLosuj Losuj = new FormLosuj(this);
         //   Losuj.Owner = this;
            Losuj.ShowDialog();
        }
    }
}
