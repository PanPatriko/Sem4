using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lab2
{
    public partial class FormLab2 : Form
    {
        public FormLab2()
        {
            InitializeComponent();
        }

        int x, y, wynik;
        int[,] tab1;
        int[][] tab2;
        private void Tab2_Click(object sender, EventArgs e)
        {
            int kolumna = 0;
            int max = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            Int32.TryParse(Interaction.InputBox("Podaj ilosc wierszy", "", "", 150, 150), out x);
            
            tab2 = new int[x][];
            for (int i = 0; i < tab2.Length; i++)
            {
                Int32.TryParse(Interaction.InputBox("Podaj dlugosc wiersza" + (i + 1), "", "", 150, 150), out x);
                tab2[i] = new int[x];
                for(int j=0;j<tab2[i].Length;j++)
                {
                     Int32.TryParse(Interaction.InputBox("Podaj wartosc dla [" + i + "] [" + j + "]", "", "", 150, 150), out tab2[i][j]);
                }
            }
            foreach(int[] wiersz in tab2)
            {
                foreach (int liczba in wiersz)
                {
                    textBox1.Text = textBox1.Text + liczba + " ";
                    wynik = wynik + liczba;
                }
                textBox3.Text = textBox3.Text + wynik + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";
                wynik = 0;
            }

            for(int i =0;i<tab2.Length;i++)
            {
                if (max < tab2[i].Length) max = tab2[i].Length;
            }

            for (kolumna=0;kolumna<max;kolumna++)
            {

                for (int i = 0; i < tab2.Length; i++)
                {
                    if (kolumna < tab2[i].Length)
                    {
                        wynik = wynik + tab2[i][kolumna];
                    }
                    
                }
                textBox2.Text = textBox2.Text + wynik + " ";
                wynik = 0;
            } 
        }
        private void Tab1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
             Int32.TryParse(Interaction.InputBox("Podaj liczbe wierszy", "", "", 150, 150), out x);
           
             Int32.TryParse(Interaction.InputBox("Podaj liczbe kolumn", "", "", 150, 150), out y);
          
            tab1 = new int[x, y];
            for(int i=0;i<x;i++)
            {
                for (int j = 0; j < y; j++)
                {
                     Int32.TryParse(Interaction.InputBox("Podaj wartosc dla [" + i +"] [" + j+"]", "", "", 150, 150), out tab1[i, j]);
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    textBox1.Text = textBox1.Text + " " + Convert.ToString(tab1[i, j]);
                    wynik = wynik + tab1[i, j];
                }
                textBox1.Text = textBox1.Text + "\r\n";
                textBox3.Text = textBox3.Text + wynik + "\r\n";
                wynik = 0;
            }
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    wynik = wynik + tab1[j, i];
                }
                textBox2.Text = textBox2.Text + wynik + " ";
                wynik = 0;
            }

        }
        
    }
}
