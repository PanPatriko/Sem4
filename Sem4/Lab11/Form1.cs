using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          /*  for(int i=0;i<9;i++)
            {
                comboBox1.Items.Add((Person.MaritalStatus)i);
            }  */
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            FillPerson(p);
            listBox1.Items.Add(p);
        }



        private void ButtonView_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem!=null)
            {
                Person p = (Person)listBox1.SelectedItem;
                label3.Text = "";
                label3.Text += "Imie: " + p.Name;
                switch(p.gender)
                {
                    case Person.Gender.Male:
                        label3.Text += "\r\n Płeć: Mężczyzna";
                        switch (p.status)
                        {
                            case Person.MaritalStatus.Single:
                                label3.Text += "\r\n Stan cywilny: Kawaler";
                                break;
                            case Person.MaritalStatus.Married:
                                label3.Text += "\r\n Stan cywilny: Żonaty";
                                break;
                            case Person.MaritalStatus.Divorcee:
                                label3.Text += "\r\n Stan cywilny: Rozwodnik";
                                break;
                            case Person.MaritalStatus.Unknown:
                                label3.Text += "\r\n Stan cywilny: Nieznany";
                                break;
                            case Person.MaritalStatus.Widowed:
                                label3.Text += "\r\n Stan cywilny: Wdowiec";
                                break;
                        }
                        break;
                    case Person.Gender.Female:
                        label3.Text += "\r\n Płeć: Kobieta";
                        switch (p.status)
                        {
                            case Person.MaritalStatus.Single:
                                label3.Text += "\r\n Stan cywilny: Panna";
                                break;
                            case Person.MaritalStatus.Married:
                                label3.Text += "\r\n Stan cywilny: Mężatka";
                                break;
                            case Person.MaritalStatus.Divorcee:
                                label3.Text += "\r\n Stan cywilny: Rozwódka";
                                break;
                            case Person.MaritalStatus.Unknown:
                                label3.Text += "\r\n Stan cywilny: Nieznany";
                                break;
                            case Person.MaritalStatus.Widowed:
                                label3.Text += "\r\n Stan cywilny: Wdowa";
                                break;
                        }
                        break;
                    case Person.Gender.Unkonwn:
                        label3.Text += "\r\n Płeć: Nieznana";
                        label3.Text += "\r\n Stan cywilny: Nieznany";
                        break;
                }
                label3.Text += "\r\n Hobby: ";
                string test = p.hobby.ToString();
                if (test.Contains("NotSpecified")) label3.Text += "Brak";
                else
                {
                    if (test.Contains("Cars")) label3.Text += "Samochody,";
                    if (test.Contains("Films")) label3.Text += "Filmy,";
                    if (test.Contains("Football")) label3.Text += "Piłka nożna,";
                    if (test.Contains("Books")) label3.Text += "Książki,";
                    if (test.Contains("Computers")) label3.Text += "Komputery";
                    if (label3.Text[label3.Text.Length - 1] == ',') label3.Text=label3.Text.Remove(label3.Text.Length - 1);
                }



            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Person p = (Person)listBox1.SelectedItem;
                FillPerson(p);
                listBox1.Items.Insert(listBox1.SelectedIndex,p);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        private void FillPerson(Person p)
        {
            p.Name = textBoxName.Text;
            if (comboBox1.Text != null)
            {
                if (comboBox1.Text == "Panna/Kawaler")
                {
                    p.status = Person.MaritalStatus.Single;
                }
                else if (comboBox1.Text == "Mężatka/Żonaty")
                {
                    p.status = Person.MaritalStatus.Married;
                }
                else if (comboBox1.Text == "Wdowa/Wdowiec")
                {
                    p.status = Person.MaritalStatus.Widowed;
                }
                else if (comboBox1.Text == "Rozwódka/Rozwodnik")
                {
                    p.status = Person.MaritalStatus.Divorcee;
                }
                else
                {
                    p.status = Person.MaritalStatus.Unknown;
                }
            }
            if (radioButtonM.Checked)
            {
                p.gender = Person.Gender.Male;
            }
            else if (radioButtonF.Checked)
            {
                p.gender = Person.Gender.Female;
            }
            else
            {
                p.gender = Person.Gender.Unkonwn;
                p.status = Person.MaritalStatus.Unknown;
            }
            if (checkBoxCars.Checked)
            {
                p.hobby = p.hobby | Person.Hobby.Cars;
            }
            if (checkBoxFB.Checked)
            {
                p.hobby = p.hobby | Person.Hobby.Football;
            }
            if (checkBoxComp.Checked)
            {
                p.hobby = p.hobby | Person.Hobby.Computers;
            }
            if (checkBoxBooks.Checked)
            {
                p.hobby = p.hobby | Person.Hobby.Books;
            }
            if (checkBoxFilms.Checked)
            {
                p.hobby = p.hobby | Person.Hobby.Films;
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
