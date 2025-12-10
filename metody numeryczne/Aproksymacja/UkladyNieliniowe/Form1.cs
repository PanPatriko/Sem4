using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace UkladyNieliniowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int p;
        int nCount;
        double fx;
        double[] n;
        double[,] array;
        TextBox[,] textboxarray;
        double[] x;
        double[] y;
        TextBox[] xText;
        TextBox[] yText;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Interaction.InputBox("Podaj ilosc niewiadomych", "", ""), out nCount))
            {
                if(nCount>0)
                {
                    CreateTextBoxArea(nCount);
                }               
            }
        }

        private TextBox CreateTextBox(int x, int y, string name)
        {
            TextBox box = new TextBox();
            box.Location = new System.Drawing.Point(x, y);
            box.Name = name;
            box.Size = new System.Drawing.Size(50, 20);
            Controls.AddRange(new Control[] { box, });
            return box;
        }
       
        private void CreateTextBoxArea(int n)
        {
            if (textboxarray != null)
            {
                for (int i = 0; i < textboxarray.GetLength(0); i++)
                {
                    for (int j = 0; j < textboxarray.GetLength(1); j++)
                    {
                        Controls.Remove(textboxarray[i, j]);
                    }
                }
            }

            array = new double[n, n + 1];
            textboxarray = new TextBox[n, n + 1];
            int x = 12;
            int y = 91;
            for (int i = 0; i < n; i++)
            {
                x = 138;
                for (int j = 0; j < n + 1; j++)
                {
                    textboxarray[i, j] = CreateTextBox(x, y, i.ToString() + " " + j.ToString());
                    x += 63;
                }
                y += 26;
            }
            label1.Location = new System.Drawing.Point(x, 81);
            label1.Text = "Szukane niewiadome";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FindUnknowns();
            }
            catch(ArgumentException)
            {

            }
        }
        private void Aproksymacja()
        {
            if (xText != null && double.TryParse(textBox1.Text, out fx))
            {
                CreateTextBoxArea(4);
                for (int i = 0; i < xText.Length; i++)
                {

                    if (double.TryParse(xText[i].Text, out double n)) x[i] = n;
                    else
                    {
                        MessageBox.Show("Nieprawidłowe dane w x [" + i.ToString() + "]");
                        throw new ArgumentException();

                    }
                    if (double.TryParse(yText[i].Text, out n)) y[i] = n;
                    else
                    {
                        MessageBox.Show("Nieprawidłowe dane w y [" + i.ToString() + "]");
                        throw new ArgumentException();
                    }
                }
                double[] sum = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (double n in x)
                {
                    sum[0] = sum[0] + n;
                    sum[1] = sum[1] + Math.Pow(n, 2);
                    sum[2] = sum[2] + Math.Pow(n, 3);
                    sum[3] = sum[3] + Math.Pow(n, 4);
                    sum[4] = sum[4] + Math.Pow(n, 5);
                    sum[5] = sum[5] + Math.Pow(n, 6);
                }
                for (int i = 0; i < y.Length; i++)
                {
                    sum[6] = sum[6] + y[i];
                    sum[7] = sum[7] + y[i] * x[i];
                    sum[8] = sum[8] + y[i] * Math.Pow(x[i], 2);
                    sum[9] = sum[9] + y[i] * Math.Pow(x[i], 3);
                }
                textboxarray[0, 0].Text = p.ToString();
                textboxarray[0, 1].Text = sum[0].ToString();
                textboxarray[0, 2].Text = sum[1].ToString();
                textboxarray[0, 3].Text = sum[2].ToString();
                textboxarray[0, 4].Text = sum[6].ToString();
                textboxarray[1, 0].Text = sum[0].ToString();
                textboxarray[1, 1].Text = sum[1].ToString();
                textboxarray[1, 2].Text = sum[2].ToString();
                textboxarray[1, 3].Text = sum[3].ToString();
                textboxarray[1, 4].Text = sum[7].ToString();
                textboxarray[2, 0].Text = sum[1].ToString();
                textboxarray[2, 1].Text = sum[2].ToString();
                textboxarray[2, 2].Text = sum[3].ToString();
                textboxarray[2, 3].Text = sum[4].ToString();
                textboxarray[2, 4].Text = sum[8].ToString();
                textboxarray[2, 0].Text = sum[1].ToString();
                textboxarray[2, 1].Text = sum[2].ToString();
                textboxarray[2, 2].Text = sum[3].ToString();
                textboxarray[2, 3].Text = sum[4].ToString();
                textboxarray[2, 4].Text = sum[8].ToString();
                textboxarray[3, 0].Text = sum[2].ToString();
                textboxarray[3, 1].Text = sum[3].ToString();
                textboxarray[3, 2].Text = sum[4].ToString();
                textboxarray[3, 3].Text = sum[5].ToString();
                textboxarray[3, 4].Text = sum[9].ToString();
                nCount = 4;
                FindUnknowns();
                fx = Convert.ToDouble(textBox1.Text);
                double result = n[3] * Math.Pow(fx, 3) + n[2] * Math.Pow(fx, 2) + n[1] * fx + n[0];
                label1.Text += "\r\n" + "y = " + result.ToString();

            }
            else
            {
                MessageBox.Show("Nieprawidlowa wartosc szukana x");
            }
        }
        private void FindUnknowns()
        {
            if (textboxarray != null && nCount > 0)
            {
                double[] ratio = new double[nCount - 1];

                for (int i = 0; i < nCount; i++)
                {
                    for (int j = 0; j < nCount + 1; j++)
                    {
                        if (double.TryParse(textboxarray[i, j].Text,out double n))
                        {
                            array[i, j] = n;
                        }
                        else
                        {
                            MessageBox.Show("Nieprawidłowe dane w [" + i.ToString() + "][" + j.ToString() + "]");
                            throw new ArgumentException();
                        }
                    }
                }
                //eliminacja

                for (int k = 0; k < nCount; k++)
                {
                    for (int i = k; i < nCount - 1; i++)
                    {
                        ratio[i] = array[i + 1, k] / array[k, k];
                    }
                    for (int i = k + 1; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            array[i, j] = array[i, j] - ratio[i - 1] * array[k, j];
                            //   textboxarray[i, j].Text = array[i, j].ToString();
                        }
                    }

                    /*  for (int i = 1; i < unknownsCount - 1; i++)
                      {
                          ratio[i] = array[i + 1, 1] / array[1, 1];
                      }
                      for (int i = 2; i < array.GetLength(0); i++)
                      {
                          for (int j = 0; j < array.GetLength(1); j++)
                          {
                              array[i, j] = array[i, j] - ratio[i - 1] * array[1, j];
                              textboxarray[i, j].Text = array[i, j].ToString();
                          }
                      }*/
                }
                n = new double[nCount];
                //niewiadome
                //  unknowns[0] = array[unknownsCount-1, unknownsCount] / array[unknownsCount - 1, unknownsCount - 1];
                for (int i = nCount - 1; i >= 0; i--)
                {
                    double s = array[i, nCount];
                    for (int j = nCount - 1; j >= i + 1; j--)
                        s -= array[i, j] * n[j];
                    n[i] = s / array[i, i];
                }
                //   unknowns[1]= (array[1, 3] - array[1, 2]*unknowns[0])/array[1, 1];
                //   unknowns[2] = (array[0, 3] - array[0, 2] * unknowns[0] - array[0, 1] * unknowns[1]) / array[0, 0];
                label1.Text = "Szukane niewiadome";
                foreach (double d in n)
                {
                    label1.Text += "\r\n" + d.ToString();
                }
            }
        }
        private void buttonT1_Click(object sender, EventArgs e)
        {
            nCount = 3;
            CreateTextBoxArea(nCount);
            textboxarray[0, 0].Text = "2";
            textboxarray[1, 0].Text = "1";
            textboxarray[2, 0].Text = "-4";
            textboxarray[0, 1].Text = "3";
            textboxarray[1, 1].Text = "-2";
            textboxarray[2, 1].Text = "1";
            textboxarray[0, 2].Text = "-1";
            textboxarray[1, 2].Text = "4";
            textboxarray[2, 2].Text = "3";
            textboxarray[0, 3].Text = "1";
            textboxarray[1, 3].Text = "-1";
            textboxarray[2, 3].Text = "0";
        }

        private void buttonT2_Click(object sender, EventArgs e)
        {
            nCount = 4;
            CreateTextBoxArea(nCount);

            textboxarray[0, 0].Text = "6";
            textboxarray[1, 0].Text = "12";
            textboxarray[2, 0].Text = "3";
            textboxarray[3, 0].Text = "-6";
            textboxarray[0, 1].Text = "-2";
            textboxarray[1, 1].Text = "-8";
            textboxarray[2, 1].Text = "-13";
            textboxarray[3, 1].Text = "4";
            textboxarray[0, 2].Text = "2";
            textboxarray[1, 2].Text = "6";
            textboxarray[2, 2].Text = "9";
            textboxarray[3, 2].Text = "1";
            textboxarray[0, 3].Text = "4";
            textboxarray[1, 3].Text = "10";
            textboxarray[2, 3].Text = "3";
            textboxarray[3, 3].Text = "-18";
            textboxarray[0, 4].Text = "12";
            textboxarray[1, 4].Text = "34";
            textboxarray[2, 4].Text = "27";
            textboxarray[3, 4].Text = "-38";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (xText != null)
            {
                for (int i = 0; i < p; i++)
                {
                    Controls.Remove(xText[i]);
                    Controls.Remove(yText[i]);
                }
            }
            if (int.TryParse(Interaction.InputBox("Podaj ilosc punktów", "", ""), out p))
            {
                if(p>0)
                {
                    xText = new TextBox[p];
                    yText = new TextBox[p];
                    x = new double[p];
                    this.y = new double[p];
                    int y = 85;
                    for (int i = 0; i < p; i++)
                    {
                        xText[i] = CreateTextBox(12, y, "x" + i.ToString());
                        yText[i] = CreateTextBox(75, y, "fx" + i.ToString());
                        y += 26;
                    }
                }
            }

        }



        private void button3_Click(object sender, EventArgs e) //aproksymacja
        {
            try
            {
                Aproksymacja();
            }
            catch(ArgumentException)
            {

            }           
        }

        private void buttonT3_Click(object sender, EventArgs e)
        {
            if (xText != null)
            {
                for (int i = 0; i < p; i++)
                {
                    Controls.Remove(xText[i]);
                    Controls.Remove(yText[i]);
                }
            }
            p = 10;
            xText = new TextBox[p];
            yText = new TextBox[p];
            x = new double[p];
            this.y = new double[p];
            int y = 85;
            for (int i = 0; i < p; i++)
            {
                xText[i] = CreateTextBox(12, y, "x" + i.ToString());
                yText[i] = CreateTextBox(75, y, "y" + i.ToString());
                y += 26;
            }
            xText[0].Text = "0,3";
            xText[1].Text = "0,4";
            xText[2].Text = "0,5";
            xText[3].Text = "0,6";
            xText[4].Text = "0,7";
            xText[5].Text = "0,8";
            xText[6].Text = "0,9";
            xText[7].Text = "1";
            xText[8].Text = "1,1";
            xText[9].Text = "1,2";
            yText[0].Text = "0,43";
            yText[1].Text = "0,36";
            yText[2].Text = "0,35";
            yText[3].Text = "0,38";
            yText[4].Text = "0,37";
            yText[5].Text = "0,373";
            yText[6].Text = "0,39";
            yText[7].Text = "0,51";
            yText[8].Text = "0,6";
            yText[9].Text = "0,65";
        }
    }
}
