using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Person p1 = new Person();

            p1.Name = "Jan";
            p1.Surname = "Kowalski";
            p1.BirthPlace = "Warszawa";
            p1.BirtDate = Convert.ToDateTime("11.12.1970");
            p1.Dad = new Person();
            p1.Mom = new Person();

            Person p2 = new Person();

            p2.Name = "Ewa";
            p2.Surname = "Kowalska";
            p2.BirthPlace = "Warszawa";
            p2.BirtDate = Convert.ToDateTime("06.06.1975");
            p2.Dad = new Person();
            p2.Mom = new Person();
            Person p3 = new Person();

            p3.Name = "Adam";
            p3.Surname = "Kowalski";
            p3.BirthPlace = "Warszawa";
            p3.BirtDate = Convert.ToDateTime("01.02.2000");
            p3.Dad = p1;
            p3.Mom = p2;
            listP.Add(p1);
            listP.Add(p2);
            listP.Add(p3);
            foreach (var p in listP)
            {
                listBoxPerson.Items.Add(p);
            }
        }

        List<Person> listP = new List<Person>();
        Person dad = new Person();
        Person mom = new Person();
        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                Person newPerson = new Person();

                newPerson.Name = textBoxName.Text;
                newPerson.Surname = textBoxSurname.Text;
                newPerson.BirthPlace = textBoxBirthPlace.Text;
                newPerson.BirtDate = Convert.ToDateTime(maskedTextBoxBirthDate.Text);
                newPerson.Dad = dad;
                newPerson.Mom = mom;
                
                listP.Add(newPerson);
                listBoxPerson.Items.Add(newPerson);
            }
            catch(FormatException)
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            FormFilter filter = new FormFilter(listP);
            filter.ListSender += new EventHandler<ListEventArgs>(GetList);
            filter.ShowDialog();
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            Person p;
            if ((listBoxPerson.SelectedItem != null || listBoxFilter.SelectedItem != null) && listBoxChildren.SelectedItem != null)
            {
                p = (Person)listBoxChildren.SelectedItem;
                Details(p);
            }
            else if (listBoxPerson.SelectedItem != null )
            {
                p = (Person)listBoxPerson.SelectedItem;
                Details(p);
            }
            else if (listBoxFilter.SelectedItem != null)
            {
                p = (Person)listBoxFilter.SelectedItem;
                Details(p);
            }
        }

        private void buttonAddDad_Click(object sender, EventArgs e)
        {
            if (listBoxPerson.SelectedItem != null)
            {
                dad = (Person)listBoxPerson.SelectedItem;
                textBoxFather.Text = dad.ToString();
            }
        }
        private void buttonAddMom_Click(object sender, EventArgs e)
        {
            if (listBoxPerson.SelectedItem != null)
            {
                mom = (Person)listBoxPerson.SelectedItem;
                textBoxMother.Text = mom.ToString();
            }
        }
        private void buttonClearM_Click(object sender, EventArgs e)
        {
            mom = new Person();
            textBoxMother.Text = "";
        }

        private void buttonClearD_Click(object sender, EventArgs e)
        {
            dad = new Person();
            textBoxFather.Text = "";
        }

        private void buttonDelPerson_Click(object sender, EventArgs e)
        {
            if ((listBoxPerson.SelectedItem != null || listBoxFilter.SelectedItem != null) && listBoxChildren.SelectedItem != null)
            {
                listP.RemoveAll(x => x.Equals(listBoxChildren.SelectedItem));
                listBoxPerson.Items.Remove(listBoxChildren.SelectedItem);
                listBoxFilter.Items.Remove(listBoxChildren.SelectedItem);
                listBoxChildren.Items.Remove(listBoxChildren.SelectedItem);
            }
            else if (listBoxPerson.SelectedItem != null)
            {
                listP.RemoveAll(x => x.Equals(listBoxPerson.SelectedItem));
                listBoxPerson.Items.Remove(listBoxPerson.SelectedItem);
            }
            else if(listBoxFilter.SelectedItem != null)
            {
                listP.RemoveAll(x => x.Equals(listBoxFilter.SelectedItem));
                listBoxPerson.Items.Remove(listBoxFilter.SelectedItem);
                listBoxFilter.Items.Remove(listBoxFilter.SelectedItem);
            }
            
        }

        private void buttonEditPerson_Click(object sender, EventArgs e)
        {
            try
            {

            
                if ((listBoxPerson.SelectedItem != null || listBoxFilter.SelectedItem != null) && listBoxChildren.SelectedItem != null)
                {
                    Person editP = listP.Find(x => x.Equals(listBoxChildren.SelectedItem));

                    EditPerson(editP);

                    listBoxPerson.SelectedItem = editP;
                    listBoxPerson.Items[listBoxPerson.SelectedIndex] = editP;
                }

                if (listBoxPerson.SelectedItem != null)
                {
                    Person editP = listP.Find(x => x.Equals(listBoxPerson.SelectedItem));

                    EditPerson(editP);

                    listBoxPerson.Items[listBoxPerson.SelectedIndex] = editP;               
                }
                else if(listBoxFilter.SelectedItem != null)
                {
                    Person editP = listP.Find(x => x.Equals(listBoxFilter.SelectedItem));

                    EditPerson(editP);

                    listBoxFilter.Items[listBoxFilter.SelectedIndex] = editP;
                    listBoxPerson.SelectedItem = editP;
                    listBoxPerson.Items[listBoxPerson.SelectedIndex] = editP;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void listBoxPerson_Enter(object sender, EventArgs e)
        {
            listBoxFilter.SelectedItem = null;
        }

        private void listBoxFilter_Enter(object sender, EventArgs e)
        {
            listBoxPerson.SelectedItem = null;
        }

        private void listBoxChildren_Enter(object sender, EventArgs e)
        {
            //listBoxFilter.SelectedItem = null;
            //listBoxPerson.SelectedItem = null;
        }

        private void listBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filter = from person in listP
                         where person.Dad.Equals(listBoxPerson.SelectedItem)
                         select person;
            var filter2 = from person2 in listP
                         where person2.Mom.Equals(listBoxPerson.SelectedItem)
                         select person2;
            listBoxChildren.Items.Clear();
            foreach (var p in filter)
            {
                listBoxChildren.Items.Add(p);
            }
            foreach (var p in filter2)
            {
                listBoxChildren.Items.Add(p);
            }
        }

        private void listBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filter = from person in listP
                         where person.Dad.Equals(listBoxFilter.SelectedItem) //|| person.Mom.Equals(listBoxFilter.SelectedItem)
                         select person;
            var filter2 = from person2 in listP
                          where person2.Mom.Equals(listBoxFilter.SelectedItem)
                          select person2;
            listBoxChildren.Items.Clear();
            foreach (var p in filter)
            {
                listBoxChildren.Items.Add(p);
            }
            foreach (var p in filter2)
           {
                listBoxChildren.Items.Add(p);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxBirthPlace.Text = "";
            maskedTextBoxBirthDate.Text = "  .  .";
            textBoxFather.Text = "";
            textBoxMother.Text = "";
            dad = new Person();
            mom = new Person();
        }
        private void EditPerson(Person editP)
        {
            editP.Name = textBoxName.Text;
            editP.Surname = textBoxSurname.Text;
            editP.BirthPlace = textBoxBirthPlace.Text;
            editP.BirtDate = Convert.ToDateTime(maskedTextBoxBirthDate.Text);
            editP.Dad = dad;
            editP.Mom = mom;
        }
        private void Details(Person P)
        {
            textBoxName.Text=P.Name;
            textBoxSurname.Text=P.Surname;
            textBoxBirthPlace.Text= P.BirthPlace;
            maskedTextBoxBirthDate.Text = P.BirtDate.ToString();
            dad = P.Dad;
            mom = P.Mom;
            textBoxFather.Text = dad.ToString();
            textBoxMother.Text = mom.ToString();
        }

        private void GetList(object sender, ListEventArgs e)
        {
            listBoxFilter.Items.Clear();
            label10.Text = "Użyte filtry:";
            foreach(var p in e.List)
            {
                listBoxFilter.Items.Add(p);
            }
            foreach (var s in e.List2)
            {
                // listBox1.Items.Add(s);
                label10.Text += "\r\n" + s ;
            }
        }


    }
}
