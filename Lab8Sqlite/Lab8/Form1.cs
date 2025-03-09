using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SqLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;

namespace SqLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLiteConnection myconnection;
        string db = "MyDatabase.sqlite";
        private void Form1_Load(object sender, EventArgs e)
        {
            myconnection = new SQLiteConnection(db);
            myconnection.CreateTable<Film>();
            var table = myconnection.Table<Film>();
            foreach (var s in table)
            {
                dataGridView1.Rows.Add(s.Id, s.Title, s.Type, s.Direction, s.Release_date.ToShortDateString());
            }
            myconnection.CreateTable<Person>();
            var table2 = myconnection.Table<Person>();
            foreach (var s in table2)
            {
                dataGridView2.Rows.Add(s.Id, s.Name, s.Surname,s.BirthDate.ToShortDateString());
            }
            myconnection.CreateTable<Reservation>();
            var table3 = myconnection.Table<Reservation>();
            foreach (var s in table3)
            {
                dataGridView3.Rows.Add(s.Id, s.PersonId, s.FilmId);
            }
            myconnection.Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "") label5.Text = "Pusta wartość pola Tytuł";
            else if (textBoxType.Text == "") label5.Text = "Pusta wartość pola Gatunek";
            else if (textBoxDirectory.Text == "") label5.Text = "Pusta wartość pola Reżyseria";
            else if (!DateTime.TryParse(maskedTextBoxReleaseDate.Text, out DateTime date)) label5.Text = "Niepoprawna data";
            else
            {
                myconnection = new SQLiteConnection(db);
                label5.Text = "";
                var newFilm = new Film();
                newFilm.Title = textBoxTitle.Text;
                newFilm.Type = textBoxType.Text;
                newFilm.Direction = textBoxDirectory.Text;
                newFilm.Release_date = date;
                myconnection.Insert(newFilm);
                dataGridView1.Rows.Add(newFilm.Id, newFilm.Title, newFilm.Type, newFilm.Direction, newFilm.Release_date.ToShortDateString());
                myconnection.Close();
            }
                // only insert the data if it doesn't already exist

        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 &&
                dataGridView1.SelectedRows[0].Index !=
                dataGridView1.Rows.Count - 1)
            {
                myconnection = new SQLiteConnection(db);
                myconnection.Delete<Film>(dataGridView1.CurrentRow.Cells[0].Value); // Id is the primary key
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                myconnection.Close();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow.Cells[0].Value!=null)
            {
                myconnection = new SQLiteConnection(db);
                Film f = myconnection.Get<Film>(dataGridView1.CurrentRow.Cells[0].Value);
                textBoxTitle.Text = f.Title;//dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxType.Text = f.Type;//dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxDirectory.Text = f.Direction;//dataGridView1.CurrentRow.Cells[3].Value.ToString();
                maskedTextBoxReleaseDate.Text = f.Release_date.ToShortDateString();//dataGridView1.CurrentRow.Cells[4].Value.ToString();
                myconnection.Close();
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                if (textBoxTitle.Text == "") label5.Text = "Pusta wartość pola Tytuł";                                
                else if (textBoxType.Text == "") label5.Text = "Pusta wartość pola Gatunek";
                else if (textBoxDirectory.Text == "") label5.Text = "Pusta wartość pola Reżyseria";
                else if (!DateTime.TryParse(maskedTextBoxReleaseDate.Text, out DateTime date)) label5.Text = "Niepoprawna data";
                else
                {
                    myconnection = new SQLiteConnection(db);
                    Film f = myconnection.Get<Film>(dataGridView1.CurrentRow.Cells[0].Value);
                    f.Title = textBoxTitle.Text;
                    f.Type = textBoxType.Text;
                    f.Direction = textBoxDirectory.Text;
                    f.Release_date = date;
                    myconnection.Update(f);
                    dataGridView1.CurrentRow.Cells[1].Value = f.Title;
                    dataGridView1.CurrentRow.Cells[2].Value = f.Type;
                    dataGridView1.CurrentRow.Cells[3].Value = f.Direction;
                    dataGridView1.CurrentRow.Cells[4].Value = f.Release_date.ToShortDateString();
                    myconnection.Close();
                }

            }
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            myconnection = new SQLiteConnection(db);
            IEnumerable<Film> filter = myconnection.Table<Film>().ToList();                                                
            if (textBoxTitleF.Text != "")
            {
                filter = filter.Where(x => x.Title.Contains(textBoxTitleF.Text));
            }
            if (textBoxTypeF.Text != "")
            {
                filter = filter.Where(x => x.Type.Contains(textBoxTypeF.Text));
            }
            if (textBoxDirectionF.Text != "")
            {
                filter = filter.Where(x => x.Direction.Contains(textBoxDirectionF.Text));
            }
            if (maskedTextBoxRDFrom.Text != "  .  ." && maskedTextBoxRDTo.Text != "  .  .")
            {
                filter = filter.Where(x => x.Release_date >= Convert.ToDateTime(maskedTextBoxRDFrom.Text) &&
                x.Release_date <= Convert.ToDateTime(maskedTextBoxRDTo.Text));
            }
            dataGridView1.Rows.Clear();
            foreach(Film f in filter)
            {
                dataGridView1.Rows.Add(f.Id, f.Title, f.Type, f.Direction, f.Release_date.ToShortDateString());
            }
            myconnection.Close();
        }

        private void ButtonAddP_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "") label5.Text = "Pusta wartość pola Imie";
            else if (textBoxSurname.Text == "") label5.Text = "Pusta wartość pola Nazwisko";
            else if (!DateTime.TryParse(maskedTextBoxBD.Text, out DateTime date)) label5.Text = "Niepoprawna data";
            else
            {
                myconnection = new SQLiteConnection(db);
                label5.Text = "";
                var newPerson = new Person();
                newPerson.Name = textBoxName.Text;
                newPerson.Surname = textBoxSurname.Text;
                newPerson.BirthDate = date;
                myconnection.Insert(newPerson);
                dataGridView2.Rows.Add(newPerson.Id, newPerson.Name, newPerson.Surname,newPerson.BirthDate.ToShortDateString());
                myconnection.Close();
            }
        }

        private void ButtonEditP_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells[0].Value != null)
            {
                if (textBoxName.Text == "") label5.Text = "Pusta wartość pola Imie";
                else if (textBoxSurname.Text == "") label5.Text = "Pusta wartość pola Nazwisko";
                else if (!DateTime.TryParse(maskedTextBoxBD.Text, out DateTime date)) label5.Text = "Niepoprawna data";
                else
                {
                    myconnection = new SQLiteConnection(db);
                    Person p = myconnection.Get<Person>(dataGridView2.CurrentRow.Cells[0].Value);
                    p.Name = textBoxName.Text;
                    p.Surname = textBoxSurname.Text;
                    p.BirthDate = date;
                    myconnection.Update(p);
                    dataGridView2.CurrentRow.Cells[1].Value = p.Name;
                    dataGridView2.CurrentRow.Cells[2].Value = p.Surname;
                    dataGridView2.CurrentRow.Cells[3].Value = p.BirthDate.ToShortDateString();
                    myconnection.Close();
                }

            }
        }

        private void ButtonDelP_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0 &&
                dataGridView2.SelectedRows[0].Index !=
                dataGridView2.Rows.Count - 1)
            {
                myconnection = new SQLiteConnection(db);
                myconnection.Delete<Person>(dataGridView2.CurrentRow.Cells[0].Value); // Id is the primary key
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                myconnection.Close();
            }
        }

        private void ButtonFindP_Click(object sender, EventArgs e)
        {
            myconnection = new SQLiteConnection(db);
            IEnumerable<Person> filter = myconnection.Table<Person>().ToList();
            if (textBoxNameF.Text != "")
            {
                filter = filter.Where(x => x.Name.Contains(textBoxNameF.Text));
            }
            if (textBoxSurnameF.Text != "")
            {
                filter = filter.Where(x => x.Surname.Contains(textBoxSurnameF.Text));
            }
            if (maskedTextBoxBDFrom.Text != "  .  ." && maskedTextBoxBDTo.Text != "  .  .")
            {
                filter = filter.Where(x => x.BirthDate >= Convert.ToDateTime(maskedTextBoxBDFrom.Text) &&
                x.BirthDate <= Convert.ToDateTime(maskedTextBoxBDTo.Text));
            }
            dataGridView2.Rows.Clear();
            foreach (Person p in filter)
            {
                dataGridView2.Rows.Add(p.Id, p.Name, p.Surname, p.BirthDate.ToShortDateString());
            }
            myconnection.Close();
        }


        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells[0].Value != null)
            {
                myconnection = new SQLiteConnection(db);
                Person p = myconnection.Get<Person>(dataGridView2.CurrentRow.Cells[0].Value);
                textBoxName.Text = p.Name;//dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxSurname.Text = p.Surname;//dataGridView1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBoxBD.Text = p.BirthDate.ToShortDateString();
                myconnection.Close();
            }
        }

        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentRow.Cells[0].Value != null && dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                myconnection = new SQLiteConnection(db);
                Reservation r = new Reservation();
                Film f = myconnection.Get<Film>(dataGridView1.CurrentRow.Cells[0].Value);
                Person p = myconnection.Get<Person>(dataGridView2.CurrentRow.Cells[0].Value);
                r.FilmId = f.Id;
                r.PersonId = p.Id;
                myconnection.Insert(r);
                dataGridView3.Rows.Add(r.Id, r.PersonId, r.FilmId);
                myconnection.Close();
            }
        }

        private void ButtonResDel_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0 &&
                dataGridView3.SelectedRows[0].Index !=
                dataGridView3.Rows.Count - 1)
            {
                myconnection = new SQLiteConnection(db);
                myconnection.Delete<Reservation>(dataGridView3.CurrentRow.Cells[0].Value); // Id is the primary key
                dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
                myconnection.Close();
            }
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.CurrentRow.Cells[0].Value != null)
            {
                myconnection = new SQLiteConnection(db);
                Reservation r = myconnection.Get<Reservation>(dataGridView3.CurrentRow.Cells[0].Value);
                try
                { 
                Film f = myconnection.Get<Film>(r.FilmId);
                Person p = myconnection.Get<Person>(r.PersonId);
                
                    dataGridView2.Rows.Clear();
                    dataGridView2.Rows.Add(p.Id, p.Name, p.Surname, p.BirthDate.ToShortDateString());
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(f.Id, f.Title, f.Type, f.Direction, f.Release_date.ToShortDateString());
                }
                catch(InvalidOperationException)
                {
                    myconnection.Delete<Reservation>(dataGridView3.CurrentRow.Cells[0].Value);
                    dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
                }
                myconnection.Close();
            }
        }
    }
    public class Film
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [MaxLength(10)]
        public string Type { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        [MaxLength(15)]
        public string Direction { get; set; }
        public DateTime Release_date { get; set; }
    }
    public class Person
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [MaxLength(10)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
    public class Reservation
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [MaxLength(10)]
        public int PersonId { get; set; }
        [MaxLength(20)]
        public int FilmId { get; set; }
    }

}
