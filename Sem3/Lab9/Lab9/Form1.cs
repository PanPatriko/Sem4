using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLiczba1_Click(object sender, EventArgs e)
        {
            FormLiczba liczba1 = new FormLiczba();
            liczba1.Text = "Liczba1";
            liczba1.MyEvent += new EventHandler<TextEventArgs>(buttonLiczba1_MyEvent);
            liczba1.Show();
        }

        private void buttonLiczba2_Click(object sender, EventArgs e)
        {
            FormLiczba liczba2 = new FormLiczba();
            liczba2.Text = "Liczba2";
            liczba2.MyEvent += new EventHandler<TextEventArgs>(buttonLiczba2_MyEvent);
            liczba2.Show();
        }

        private void buttonWynik_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(buttonLiczba1.Text) + Convert.ToInt32(buttonLiczba2.Text)).ToString();
        }
        private void buttonLiczba2_MyEvent(object sender, TextEventArgs e)
        {
            buttonLiczba2.Text = e.Text;
        }
        private void buttonLiczba1_MyEvent(object sender, TextEventArgs e)
        {
            buttonLiczba1.Text = e.Text;
        }
    }
}
