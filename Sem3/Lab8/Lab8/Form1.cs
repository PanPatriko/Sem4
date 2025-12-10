using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public List<int> Przetworz(List<int> list,Dzialanie del)
        {
            List<int> newlist = new List<int>();
            int wynik;
            wynik = list[0] ;
            for(int i=1;i<list.Count;i++)
            {
                wynik = del(wynik, list[i]);
                newlist.Add(wynik);
            }
            return newlist;
            
        }
        public  int Dodaj(int x, int y)
        {
            return x + y;
        }

        public int Odejmij(int x, int y)
        {
            return x - y;
        }

        public int Pomnoz(int x, int y)
        {
            return x * y;
        }

        public int Podziel(int x, int y)
        {
            return x / y;
        }
        public int Pow2(int x)
        {
            return x * x;
        }
        public int Pow3(int x)
        {
            return x * x * x;
        }
        public int Pow4(int x)
        {
            return x * x * x * x;
        }
        public List<int> list = new List<int>();
        
        public delegate int Dzialanie(int x, int y);
        public delegate int Potega(int x);
        Potega delgat2;
        Dzialanie delegat;
        public Potega ZwrocPow(int pow)
        {
            if (pow == 2) return Pow2;
            if (pow == 3) return Pow3;
            if (pow == 4) return Pow4;
            throw new Exception("Power can be only 2,3 or 4");
        }
        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            buttonOblicz.Enabled = true;

            if (radioButtonPlus.Checked == true)
            {
                delegat = Dodaj;
            }
            else if (radioButtonMinus.Checked == true)
            {
                delegat = Odejmij;
            }
            else if (radioButtonGwiazdka.Checked == true)
            {
                delegat = Pomnoz;
            }
            else if (radioButtonUkosnik.Checked == true)
            {
                delegat = Podziel;
            }           

        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text = delegat(Convert.ToInt32(textBoxLiczba1.Text), Convert.ToInt32(textBoxLiczba2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) delgat2 = ZwrocPow(2);
            else if (radioButton2.Checked == true) delgat2 = ZwrocPow(3);

            else if (radioButton3.Checked == true) delgat2 = ZwrocPow(4);

            textBox1.Text = delgat2(Convert.ToInt32(textBoxLiczba1.Text)).ToString();

        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            list.Add(Convert.ToInt32(textBoxLiczba1.Text));
            textBox3.Text = textBox3.Text  + textBoxLiczba1.Text + "\r\n";
        }

        private void buttonPrzetworz_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            List<int> prztwlist = Przetworz(list, delegat);
            foreach(int i in prztwlist)
            {
                textBox2.Text = textBox2.Text  + i.ToString() + "\r\n";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
