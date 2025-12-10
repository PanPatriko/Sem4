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
    public partial class FormLosuj : Form
    {
        FormMain FormMain;
        Random rand = new Random();
        string klucz;
        string los;
        int num;
        List<String> klucze = new List<String>();
        Stack<String> stos = new Stack<String>();
        public FormLosuj()
        {
            InitializeComponent();
        }
        public FormLosuj(FormMain form)
        {
            FormMain = form;
            klucze = FormMain.PobierzKlucze();
            InitializeComponent();
        }       

        private void buttonLosuj_Click_1(object sender, EventArgs e)
        {
            if(klucze.Count!=0)
            {
                buttonCofnij.Enabled = true;
                buttonSpr.Enabled = true;
                textBoxLosowanie.Enabled = true;
                num = rand.Next(0, klucze.Count);
                klucz = klucze[num];
                klucze.RemoveAt(num);
                los = FormMain.PobierzSlowo(klucz);
                labelLosowanie.Text = klucz;
                stos.Push(klucz);
            }
            else
            {
                MessageBox.Show("Wylosowano wszystkie słowa");
                Close();
            }

        }

        private void buttonSpr_Click(object sender, EventArgs e)
        {
            if (los == textBoxLosowanie.Text) MessageBox.Show("DOBRZE");
            else MessageBox.Show("ŹLE");
        }

        private void buttonCofnij_Click(object sender, EventArgs e)
        {
            klucz = stos.Pop();
            labelLosowanie.Text = klucz;
            textBoxLosowanie.Text = "";
            if(stos.Count==0) buttonCofnij.Enabled = false;
        }
    }
}
