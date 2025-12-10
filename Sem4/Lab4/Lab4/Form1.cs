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

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<int> list = new List<int>();
        static List<int> list2 = new List<int>();
        int odd,even,counter,nsort;
        static readonly object _locker = new object();
        static int repeat,min,max;
        static Random rand = new Random();

        static void AddNumberLock()
        {
            try
            {
                    int n, counter, lenght;             
                    for (int i = 0; i < repeat; i++)
                    {
                    n = rand.Next(min, max);
                    list2.Add(n);
                    counter = 0;
                    lenght = list.Count;

                    if (list.Exists(x => x > n) == true)
                    {
                        lock (_locker)
                        {
                            do
                            {

                                if (n < list[counter] && list != null)
                                {
                                    list.Insert(counter, n);
                                }
                                else
                                {
                                    counter++;
                                }

                            } while (lenght == list.Count);
                        }
                    }
                    else
                    {
                        lock(_locker)
                        {
                            list.Add(n);
                        }                                            
                    }
                }                   
            }   
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Dodawanie - ArgumentOutOfRangeException");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Dodawanie - IndexOutOfRangeException");
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Dodawanie - ArgumentException");
            }
        }
        static void AddNumber()
        {
            try
            {

                int n,counter,lenght;
                for (int i = 0; i < repeat; i++)
                {
                    n = rand.Next(min, max);
                    list2.Add(n);
                    counter = 0;
                    lenght = list.Count;
                      if (list.Exists(x => x > n) == true)
                      {
                          do
                          {

                              if (n<list[counter] && list!=null)
                              {
                                  list.Insert(counter, n);
                              }
                              else
                              {
                                  counter++;
                              }
                          } while(lenght==list.Count);
                      } 
                 //   if (list.Exists(x => x > n) == true) list.Insert(list.FindIndex(x => x > n), n);
                    else list.Add(n);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Dodawanie - ArgumentOutOfRangeException");
            }
            catch(System.ArgumentException)
            {
                MessageBox.Show("Dodawanie - ArgumentException");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Dodawanie - IndexOutOfRangeException");
            }

        }
        static void DelOddNumberLock()
        {
            try
            {
                  for (int i = 0; i < repeat; i++)
                  {
                      lock (_locker)
                      {
                          list.RemoveAll(x => x % 2 == 0); 
                      }
                  }               
                 /*   for (int i = 0; i < max; i++)
                    {

                    lock (_locker)
                    {

                        for (int j = 0; j < list.Count; j++)
                        {
                            if (list[j] % 2 == 0)
                            {
                                list.RemoveAt(j);
                            }
                        }
                    }
                    }*/               
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Usuwanie - ArgumentOutOfRangeException");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Usuwanie - IndexOutOfRangeException");
            }
        }
        static void DelOddNumber()
        {
            try
            {
                for (int i = 0; i < repeat; i++)
                {                  
                      list.RemoveAll(x => x % 2 == 0);                   
                }
              /*  for (int i = 0; i <max; i++)
                {       
                    for(int j =0;j<list.Count;j++)
                    {
                        if(list[j] % 2 == 0)
                        {
                            list.RemoveAt(j);
                        }
                    }
                }*/
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Usuwanie - ArgumentOutOfRangeException");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Usuwanie - IndexOutOfRangeException");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            try
            {
                repeat = Convert.ToInt32(textBox1.Text);
            }
            catch(Exception)
            {
                textBox1.Text = "100";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                repeat = Convert.ToInt32(textBox1.Text);
                min = Convert.ToInt32(textBox2.Text);
                max = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Niepoprawny format danych");
            }
            Thread tSav1 ;
            Thread tSav2 ;
            Thread tDel1 ;
            Thread tDel2 ;

            richTextBox1.Text = "";
            richTextBox2.Text = "";
            list.Clear();
            list2.Clear();

            if (checkBox1.Checked)
            {
                 tSav1 = new Thread(AddNumberLock);
                 tSav2 = new Thread(AddNumberLock);
                 tDel1 = new Thread(DelOddNumberLock);
                 tDel2 = new Thread(DelOddNumberLock);
            }
            else
            {
                 tSav1 = new Thread(AddNumber);
                 tSav2 = new Thread(AddNumber);
                 tDel1 = new Thread(DelOddNumber);
                 tDel2 = new Thread(DelOddNumber);
            }

            tSav1.Start();
            tSav2.Start();
            tDel1.Start();
            tDel2.Start();
    
            while ((tSav1.IsAlive || tSav2.IsAlive || tDel1.IsAlive || tDel2.IsAlive ))
            { }

            even = 0;
            odd = 0;
            counter = 0;
            nsort = 0;
            foreach (int n in list)
            {
                if (n % 2 == 0)
                {
                    if(counter>0 && counter < list.Count)
                    {
                        if (list[counter] < list[counter - 1])
                        {
                            richTextBox1.SelectionColor = Color.Blue;
                            richTextBox1.SelectedText = n.ToString() + "\n";
                            nsort++;
                        }
                        else
                        {
                            richTextBox1.SelectionColor = Color.Red;
                            richTextBox1.SelectedText = n.ToString() + "\n";
                        }
                    }
                    else
                    {
                        richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.SelectedText = n.ToString() + "\n";
                    }
                    even++;
                }                
                else
                {
                    if (counter > 0 && counter < list.Count)
                    {
                        if (list[counter] < list[counter - 1])
                        {
                            richTextBox1.SelectionColor = Color.Blue;
                            richTextBox1.SelectedText = n.ToString() + "\n";
                            nsort++;
                        }
                        else
                        {
                            richTextBox1.SelectionColor = Color.Green;
                            richTextBox1.SelectedText += n.ToString() + "\n";
                        }
                    }
                    else
                    {
                        richTextBox1.SelectionColor = Color.Green;
                        richTextBox1.SelectedText += n.ToString() + "\n";
                    }
                    odd++;
                }
                counter++;
            }

            label1All.Text = (richTextBox1.Lines.Length - 1).ToString();
            label1Even.Text = even.ToString();
            label1Odd.Text = odd.ToString();
            label6.Text = nsort.ToString();
            even = 0;
            odd = 0;
            list2.Sort();
            foreach (int n in list2)
            {
                if (n % 2 == 0)
                {
                        richTextBox2.SelectionColor = Color.Red;
                        richTextBox2.SelectedText = n.ToString() + "\n";
                        even++;
                }
                else
                {
                    richTextBox2.SelectionColor = Color.Green;
                    richTextBox2.SelectedText += n.ToString() + "\n";
                    odd++;
                }
            }
            label2All.Text = (richTextBox2.Lines.Length - 1).ToString();
            label2Even.Text = even.ToString();
            label2Odd.Text = odd.ToString();
        }

    }
}
