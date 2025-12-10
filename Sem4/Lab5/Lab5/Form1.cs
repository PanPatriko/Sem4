using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Task t;
        CancellationTokenSource source;

        private ErrorProvider errprov = new ErrorProvider();
        int a, b;



        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            int x;
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                this.errprov.SetError(this.textBox2, "To pole nie moze byc puste");
            }
            else if (!int.TryParse(textBox2.Text, out x))
            {
                e.Cancel = true;
                this.errprov.SetError(this.textBox2, "To pole moze zawierac tylko liczby całkowite z zakresu int32");
            }
            else
            {
                e.Cancel = false;
                errprov.Clear();
            }
        }

        private void TextBox3_Validating(object sender, CancelEventArgs e)
        {
            int x;
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                this.errprov.SetError(this.textBox3, "To pole nie moze byc puste");
            }
            else if (!int.TryParse(textBox3.Text, out x))
            {
                e.Cancel = true;
                this.errprov.SetError(this.textBox3, "To pole moze zawierac tylko liczby całkowite z zakresu int32");
            }
            else
            {
                e.Cancel = false;
                errprov.Clear();
            }
        }

        
        
        private void ButtonFind_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            b = int.Parse(textBox3.Text);
        /*    if (a < 2)
            {
                this.errprov.SetError(this.textBox2, "Wartosc musi byc wieksza od 1");
            }
            else if (b < 2)
            {
                this.errprov.SetError(this.textBox3, "Wartosc musi byc wieksza od 1");
            }
            else if (a > b)
            {
                
                this.errprov.SetError(this.textBox3, "Niepoprawny zakres");
            }*/
            if(true)
            {
                errprov.Clear();
                source = new CancellationTokenSource();
                CancellationToken token = source.Token;
                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = (int)Math.Sqrt(b);
                listBox1.Items.Clear();
                label4.Text = "";
                buttonFind.Enabled = false;
                t = Task.Factory.StartNew(() =>
                {
                    if (a < 2) {
                       // buttonFind.Enabled = true;
                        MessageBox.Show("Bład - kliknij przycisk\"Wyjatki\" w celu zobaczenia szczegółów");
                        throw new Exception("Value A must be greater than 2");
                    }
                    else if (b < 2)
                    {
                     //   buttonFind.Enabled = true;
                        MessageBox.Show("Bład - kliknij przycisk\"Wyjatki\" w celu zobaczenia szczegółów");
                        throw new Exception("Value B must be greater than 2"); }
                    else if (a > b)
                    {
                     //   buttonFind.Enabled = true;
                        MessageBox.Show("Bład - kliknij przycisk\"Wyjatki\" w celu zobaczenia szczegółów");
                        throw new Exception("Incorrect range: A can't be greater than B");
                    }

                    List<int> primesList = new List<int>();
                    bool[] nums = new bool[b];
                    int j, k;
                    for (j = 0; j < b; j++) nums[j] = true;

                    for (j = 2; j <= (int)Math.Sqrt(b); j++)
                    {

                        if (nums[j - 1])
                        {

                            k = j + j;
                            while (k <= b)
                            {
                                nums[k - 1] = false;
                                k = k + j;
                                token.ThrowIfCancellationRequested();

                            }
                        }
                        Thread.Sleep(100);
                        progressBar1.Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Value = j;
                        });
                        token.ThrowIfCancellationRequested();
                    }
                    for (j = 2; j <= b; j++)
                    {
                            if (nums[j - 1] && j >= a)
                            {
                                primesList.Add(j);
                            }
                    }

                    listBox1.Invoke((MethodInvoker)delegate
                    {
                            buttonFind.Enabled = true;
                            foreach (int n in primesList)
                            {
                                listBox1.Items.Add(n);
                            }
                    });
                }, token);              
            }
        }

        private void ButtonExept_Click(object sender, EventArgs e)
        {
            try
            {
                t.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var c in ae.Flatten().InnerExceptions)
                {
                    label4.Text += c.ToString()+"\r\n";
                }
            }
        }

        private void ButtonCanc_Click(object sender, EventArgs e)
        {
            buttonFind.Enabled = true;
            source.Cancel();
        }

        /*  private static List<int> FindPrimes()
          {
              int[] nums = new int[b];
              int j, k;
              for (j = 0; j < b; j++) nums[j] = j + 1;

              for (j = 2; j <= (int)Math.Sqrt(b); j++)
              {
                  if (nums[j - 1] != 0)
                  {
                      k = j + j;
                      while (k <= b)
                      {
                          nums[k - 1] = 0;
                          k = k + j;
                      }
                  }
              }
              List<int> primesList = new List<int>();
              for (j = 2; j <= b; j++)
              {
                  if (nums[j - 1] != 0 && nums[j - 1]>=a)
                  {
                      primesList.Add(nums[j - 1]);
                  }
              }
              return primesList;
          }*/

    }
}
