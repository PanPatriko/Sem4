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


namespace Interpolacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wezly = 5;
            int y = 81;
            x = new TextBox[wezly];
            fx = new TextBox[wezly];
            for (int i = 0; i < wezly; i++)
            {
                x[i] = CreateTextBox(12, y, "x" + i.ToString());
                fx[i] = CreateTextBox(75, y, "fx" + i.ToString());
                y += 26;               
            }
            x[0].Text = "0,2";
            x[1].Text = "0,3";
            x[2].Text = "0,4";
            x[3].Text = "0,5";
            x[4].Text = "0,6";
            fx[0].Text = "1,7527";
            fx[1].Text = "1,37246";
            fx[2].Text = "1,11453";
            fx[3].Text = "0,92442";
            fx[4].Text = "0,77752";
        }
        int wezly;
        TextBox[] x;
        TextBox[] fx;
        List<double[]> wielInterpolacyjne = new List<double[]>();
        private void button1_Click(object sender, EventArgs e)
        {
            if(x!=null)
            {
                for (int i = 0; i < wezly; i++)
                {
                    Controls.Remove(x[i]);
                    Controls.Remove(fx[i]);
                }
            }
            if(!int.TryParse(Interaction.InputBox("Podaj ilosc węzłów", "", ""),out wezly))
            {
                MessageBox.Show("Niepoprawna wartosc");
            }
            else
            {
                x = new TextBox[wezly];
                fx = new TextBox[wezly];

                int y = 81;
                for (int i = 0; i < wezly; i++)
                {
                    x[i] = CreateTextBox(12, y, "x" + i.ToString());
                    fx[i] = CreateTextBox(75, y, "fx" + i.ToString());
                    y += 26;
                }
            }
        }
        private TextBox  CreateTextBox(int x,int y,string name)
        {
            TextBox box = new TextBox();
            box.Location = new System.Drawing.Point(x, y);
            box.Name = name;
            box.Size = new System.Drawing.Size(50, 20);
            Controls.AddRange(new Control[] { box, });
            return box;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                wielInterpolacyjne.Clear();
                for (int i = wezly - 1; i >= 1; i--)
                {
                    wielInterpolacyjne.Add(new double[i]);
                }
                for (int i = 0; i < wezly - 1; i++)
                {
                    wielInterpolacyjne[0][i] = (Convert.ToDouble(fx[i + 1].Text) - Convert.ToDouble(fx[i].Text)) / (Convert.ToDouble(x[i + 1].Text) - Convert.ToDouble(x[i].Text));
                    ///  textBox1.Text += wielomiany[0][i].ToString() + " ";
                }
                int z = 2;
                for (int i = 0; i < wezly - 2; i++)
                {
                    for (int j = 0; j < wezly - z; j++)
                    {
                        wielInterpolacyjne[i + 1][j] = (wielInterpolacyjne[i][j + 1] - wielInterpolacyjne[i][j]) / (Convert.ToDouble(x[j + z].Text) - Convert.ToDouble(x[j].Text));
                        //  textBox1.Text += wielomiany[i+1][j].ToString() + " ";
                    }
                    z++;
                }
                double xn = Convert.ToDouble(textBox1.Text); ;


                double wynik = Convert.ToDouble(fx[0].Text);
                double buf;
                int licznik = 0;
                foreach (double[] d in wielInterpolacyjne)
                {
                    buf = xn - Convert.ToDouble(x[0].Text);
                    for (int i = 0; i < licznik; i++)
                    {
                        buf *= xn - Convert.ToDouble(x[i + 1].Text);
                    }
                    licznik++;
                    wynik += d[0] * buf;
                }
                label4.Text = "Szukany f(x): " + wynik.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Błąd");
            }
            /*
            for (int i = 0; i < wezly - 2; i++)
            {
                wielomiany[1][i] = (wielomiany[0][i+1]- wielomiany[0][i]) / (Convert.ToDouble(x[i + 2].Text) - Convert.ToDouble(x[i].Text));
                textBox1.Text += wielomiany[1][i].ToString()+" ";
            }
            for (int i = 0; i < wezly - 3; i++)
            {
                wielomiany[2][i] = (wielomiany[1][i + 1] - wielomiany[1][i]) / (Convert.ToDouble(x[i + 3].Text) - Convert.ToDouble(x[i].Text));
                   textBox1.Text += wielomiany[2][i].ToString()+" ";
            }
            for (int i = 0; i < wezly - 4; i++)
            {
                wielomiany[3][i] = (wielomiany[2][i + 1] - wielomiany[2][i]) / (Convert.ToDouble(x[i + 4].Text) - Convert.ToDouble(x[i].Text));
                textBox1.Text += wielomiany[3][i].ToString() + " ";
            }
            */
        }
    }
}
