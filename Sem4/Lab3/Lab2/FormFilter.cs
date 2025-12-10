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
    public partial class FormFilter : Form
    {
        public FormFilter()
        {
            InitializeComponent();
        }
        public FormFilter(List<Person> list)
        {
            InitializeComponent();
            listP = list;
            foreach (var p in listP)
            {
                listBoxPerson.Items.Add(p);
            }
        }

        List<String> ListF = new List<string>();
        List<Person> listP;
        Person dad = new Person();
        Person mom = new Person();

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            ListF.Clear();
            IEnumerable<Person> filter = listP;
            if (textBoxName.Text != "")
            {
                filter = filter.Where(x => x.Name == textBoxName.Text);
                ListF.Add("Imie");
            }
            if (textBoxSurname.Text != "")
            {
                filter = filter.Where(x => x.Surname == textBoxSurname.Text);
                ListF.Add("Nazwisko");
            }
            if (textBoxBirthPlace.Text != "")
            {
                filter = filter.Where(x => x.BirthPlace == textBoxBirthPlace.Text);
                ListF.Add("Miejsce urodzenia");
            }
            if (maskedTextBoxDateFrom.Text != "  .  ." && maskedTextBoxDateTo.Text != "  .  .")
            {
                filter = filter.Where(x => x.BirtDate >= Convert.ToDateTime(maskedTextBoxDateFrom.Text) && x.BirtDate <= Convert.ToDateTime(maskedTextBoxDateTo.Text));
                ListF.Add("Data urodzenia między "+ maskedTextBoxDateFrom.Text+"--"+ maskedTextBoxDateTo.Text);
            }
            if (textBoxFather.Text != "")
            {
                filter = filter.Where(x => x.Dad.Equals(dad));
                ListF.Add("Ojciec");
            }
            if (textBoxMother.Text != "")
            {
                filter = filter.Where(x => x.Mom.Equals(mom));
                ListF.Add("Matka");
            }
            if (checkBoxNameLenght.Checked)
            {
                filter = filter.Where(x => x.Name.Length > numericUpDownName.Value);
                ListF.Add("Długosc imienia > "+ numericUpDownName.Value.ToString());
            }
            if (checkBoxAge.Checked)
            {
                filter = filter.Where(x => DateTime.Today.Year - x.BirtDate.Year>=18 );
                ListF.Add("Pełnoletniość");
            }
            if (checkBoxEvenDay.Checked)
            {
                filter = filter.Where(x => x.BirtDate.Day % 2 == 0);
                ListF.Add("Parzysty dzień urodzenia");
            }
            if (checkBoxParBirthPlace.Checked)
            {
                filter = from person in filter
                         where person.Dad.Equals(person.Dad)
                         where person.Mom.Equals(person.Mom)
                         where person.Dad.BirthPlace == person.Mom.BirthPlace
                         select person;
                ListF.Add("Rodzice urodzeni w tym samym miejscu");
            }
            if (checkBoxSib.Checked)
            {
                 filter = from person in filter
                              from person2 in listP
                              where person.Dad.Equals(person2.Dad)
                              where person.Mom.Equals(person2.Mom)
                              where person.Equals(person2) == false
                              select person;
                ListF.Add("Rodzeństwo");
            }
            listBoxFilter.Items.Clear();
            foreach (var p in filter)
            {
                listBoxFilter.Items.Add(p);
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxBirthPlace.Text = "";
            maskedTextBoxDateFrom.Text = "  .  .";
            maskedTextBoxDateTo.Text = "  .  .";
            textBoxFather.Text = "";
            textBoxMother.Text = "";
            dad = new Person();
            mom = new Person();
          //  listP.Clear();
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            if(listBoxPerson.SelectedItem!=null)
            {
                Person p = (Person)listBoxPerson.SelectedItem;
                FormDetails details = new FormDetails(p);
                details.Show();
            }

        }

        public event EventHandler<ListEventArgs> ListSender;

        protected virtual void OnListSender(ListEventArgs e)
        {
            // Create a copy of the event to work with
            EventHandler<ListEventArgs> handler = ListSender;
            /* If there are no subscribers, eh will be null so we need to check
             * to avoid a NullReferenceException. */
            if (handler != null)
                handler(this, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Person> filteredList = new List<Person>();
            foreach(Person p in listBoxFilter.Items)
            {
                filteredList.Add(p);
            }
            OnListSender(new ListEventArgs(filteredList,ListF));
        }

    }
}
