using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }
        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if ((textBoxImie.Text == "Wpisz imie") || (textBoxNazwisko.Text == "Wpisz nazwisko") || (textBoxRok.Text == "Wpisz rok urodzenia")) MessageBox.Show("Nie podano wszystkich danych");
            else
            {
                int xd;
                if (int.TryParse(textBoxRok.Text, out xd))
                {

                    Osoba osoba = new Osoba(textBoxImie.Text, textBoxNazwisko.Text, int.Parse(textBoxRok.Text));
                    listBox1.Items.Add(osoba);
                }
                else MessageBox.Show("Wpisz poprawny rok");
                
            }
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Osoba edytuj = (Osoba)listBox1.SelectedItem;
                edytuj.Imie = textBoxImie.Text;
                edytuj.nazwisko = textBoxNazwisko.Text;
            }
            // tab[ilosc].Rok_ur = textBoxRok.Text;
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            textBoxImie.Text = "Wpisz imie";
            textBoxNazwisko.Text = "Wpisz nazwisko";
            textBoxRok.Text = "Wpisz rok urodzenia";
            textBoxImieNazwisko.Text = "";
            textBoxWiek.Text = "";
        }

        private void textBoxImie_Leave(object sender, EventArgs e)
        {
            if (textBoxImie.Text == "") textBoxImie.Text = "Wpisz imie";
        }

        private void textBoxImie_Enter(object sender, EventArgs e)
        {
            if (textBoxImie.Text == "Wpisz imie") textBoxImie.Text = "";
        }

        private void textBoxNazwisko_Enter(object sender, EventArgs e)
        {
            if (textBoxNazwisko.Text == "Wpisz nazwisko") textBoxNazwisko.Text = "";
        }

        private void textBoxNazwisko_Leave(object sender, EventArgs e)
        {
            if (textBoxNazwisko.Text == "") textBoxNazwisko.Text = "Wpisz nazwisko";
        }

        private void textBoxRok_Enter(object sender, EventArgs e)
        {
            if (textBoxRok.Text == "Wpisz rok urodzenia") textBoxRok.Text = "";
        }

        private void textBoxRok_Leave(object sender, EventArgs e)
        {
            if (textBoxRok.Text == "") textBoxRok.Text = "Wpisz rok urodzenia";
        }

        private void buttonWczytaj_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Osoba wczytaj = (Osoba)listBox1.SelectedItem;
                textBoxImie.Text = wczytaj.Imie;
                textBoxNazwisko.Text = wczytaj.nazwisko;
                textBoxRok.Text = Convert.ToString(wczytaj.Rok_ur);
                textBoxImieNazwisko.Text = wczytaj.Imie_Nazwisko;
                textBoxWiek.Text = Convert.ToString(wczytaj.Wiek);
            }

        }

        private void Lab1_Load(object sender, EventArgs e)
        {

        }
    }
}
