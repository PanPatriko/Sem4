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
    public partial class FormDodaj : Form
    {
        FormMain FormMain;
        public FormDodaj(FormMain form)       //W konstruktorze Form2 umieszczamy Form1 jako parametr
        {
            FormMain = form;
            InitializeComponent();
        }
        public FormDodaj()
        {
            InitializeComponent();
        }

        private void textBoxAng_Enter(object sender, EventArgs e)
        {
            if (textBoxAng.Text == "Dodaj słowo po angielsku") textBoxAng.Text = "";
        }

        private void textBoxPl_Enter(object sender, EventArgs e)
        {
            if (textBoxPl.Text == "Dodaj słowo po polsku") textBoxPl.Text = "";
        }

        private void textBoxPl_Leave(object sender, EventArgs e)
        {
            if (textBoxPl.Text == "") textBoxPl.Text = "Dodaj słowo po polsku";
        }

        private void textBoxAng_Leave(object sender, EventArgs e)
        {
            if (textBoxAng.Text == "") textBoxAng.Text = "Dodaj słowo po angielsku";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if ((textBoxAng.Text == "Dodaj słowo po angielsku") || (textBoxPl.Text == "Dodaj słowo po polsku")) MessageBox.Show("Podaj słowa"); 
            else {
                try
                {
                    FormMain.DodajDoSlownika(textBoxAng.Text, textBoxPl.Text);
                    Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Takie słowo już jest w słowniku");
                }
            }
        }
        
    }
}
