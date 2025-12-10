using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new ReservationContext())
            {
                foreach(var f in db.Films)
                {
                    dataGridView1.Rows.Add(f.FilmId, f.Title, f.Type, f.Direction, f.Release_date.ToShortDateString());
                }
                foreach (var p in db.People)
                {
                    dataGridView2.Rows.Add(p.PersonId, p.Name, p.Surname, p.BirthDate.ToShortDateString());
                }
                foreach (var r in db.Reservations)
                {
                    dataGridView3.Rows.Add(r.ReservationId, r.PersonId, r.FilmId);
                }

            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "") label5.Text = "Pusta wartość pola Tytuł";
            else if (textBoxType.Text == "") label5.Text = "Pusta wartość pola Gatunek";
            else if (textBoxDirectory.Text == "") label5.Text = "Pusta wartość pola Reżyseria";
            else if (!DateTime.TryParse(maskedTextBoxReleaseDate.Text, out DateTime date)) label5.Text = "Niepoprawna data";
            else
            {
                using(var db = new ReservationContext())
                {
                    label5.Text = "";
                    Film f = new Film();
                    f.Title = textBoxTitle.Text;
                    f.Type = textBoxType.Text;
                    f.Direction = textBoxDirectory.Text;
                    f.Release_date = date;
                    db.Films.Add(f);
                    db.SaveChanges();
                    dataGridView1.Rows.Add(f.FilmId, f.Title, f.Type, f.Direction, f.Release_date.ToShortDateString());
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                if (textBoxTitle.Text == "") label5.Text = "Pusta wartość pola Tytuł";
                else if (textBoxType.Text == "") label5.Text = "Pusta wartość pola Gatunek";
                else if (textBoxDirectory.Text == "") label5.Text = "Pusta wartość pola Reżyseria";
                else if (!DateTime.TryParse(maskedTextBoxReleaseDate.Text, out DateTime date)) label5.Text = "Niepoprawna data";
                else
                {
                    using (var db = new ReservationContext())
                    {
                        int index = (int)dataGridView1.CurrentRow.Cells[0].Value;
                        Film f = db.Films.Single(x => x.FilmId == index);
                        f.Title = textBoxTitle.Text;
                        f.Type = textBoxType.Text;
                        f.Direction = textBoxDirectory.Text;
                        f.Release_date = date;
                        db.SaveChanges();
                        dataGridView1.CurrentRow.Cells[1].Value = f.Title;
                        dataGridView1.CurrentRow.Cells[2].Value = f.Type;
                        dataGridView1.CurrentRow.Cells[3].Value = f.Direction;
                        dataGridView1.CurrentRow.Cells[4].Value = f.Release_date.ToShortDateString();
                    }

                }

            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                using (var db = new ReservationContext())
                {
                    int index = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    Film f = db.Films.Single(x => x.FilmId == index);
                    textBoxTitle.Text = f.Title;//dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBoxType.Text = f.Type;//dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    textBoxDirectory.Text = f.Direction;//dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    maskedTextBoxReleaseDate.Text = f.Release_date.ToShortDateString();//dataGridView1.CurrentRow.Cells[4].Value.ToString();
                }

            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 &&
                dataGridView1.SelectedRows[0].Index !=
                dataGridView1.Rows.Count - 1)
            {               
                    using (var db = new ReservationContext())
                    {
                        Film f = new Film();
                        f.FilmId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                        //f.Title = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        //f.Type = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        //f.Direction = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        //f.Release_date = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        db.Films.Remove(f);
                        db.SaveChanges();
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    }
            }   
        }

        private void ButtonAddP_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "") label5.Text = "Pusta wartość pola Imie";
            else if (textBoxSurname.Text == "") label5.Text = "Pusta wartość pola Nazwisko";
            else if (!DateTime.TryParse(maskedTextBoxBD.Text, out DateTime date)) label5.Text = "Niepoprawna data";
            else
            {
                using (var db = new ReservationContext())
                {
                    label5.Text = "";
                    var p = new Person();
                    p.Name = textBoxName.Text;
                    p.Surname = textBoxSurname.Text;
                    p.BirthDate = date;
                    db.People.Add(p);
                    db.SaveChanges();
                    dataGridView2.Rows.Add(p.PersonId, p.Name, p.Surname,p.BirthDate.ToShortDateString());
                }
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
                    using (var db = new ReservationContext())
                    {
                        int index = (int)dataGridView2.CurrentRow.Cells[0].Value;
                        Person p = db.People.Single(x => x.PersonId == index);
                        p.Name = textBoxName.Text;
                        p.Surname = textBoxSurname.Text;
                        p.BirthDate = date;
                        db.SaveChanges();
                        dataGridView2.CurrentRow.Cells[1].Value = p.Name;
                        dataGridView2.CurrentRow.Cells[2].Value = p.Surname;
                        dataGridView2.CurrentRow.Cells[3].Value = p.BirthDate.ToShortDateString();
                    }
                }

            }
        }

        private void ButtonDelP_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0 &&
                dataGridView2.SelectedRows[0].Index !=
                dataGridView2.Rows.Count - 1)
            {
                using (var db = new ReservationContext())
                {
                    Person p = new Person();
                    p.PersonId = (int)dataGridView2.CurrentRow.Cells[0].Value;
                 //   p.Name = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                 //   p.Surname = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                 //   p.BirthDate = DateTime.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                    db.People.Remove(p);
                    db.SaveChanges();
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                }
            }
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells[0].Value != null)
            {
                using(var db = new ReservationContext())
                {
                    int index = (int)dataGridView2.CurrentRow.Cells[0].Value;
                    Person p = db.People.Single(x => x.PersonId == index);
                    textBoxName.Text = p.Name;
                    textBoxSurname.Text = p.Surname;
                    maskedTextBoxBD.Text = p.BirthDate.ToShortDateString();
                }
            }
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            using(var db = new ReservationContext())
            {
                IEnumerable<Film> filter = db.Films;
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
                foreach (Film f in filter)
                {
                    dataGridView1.Rows.Add(f.FilmId, f.Title, f.Type, f.Direction, f.Release_date.ToShortDateString());
                }
            }
        }

        private void ButtonFindP_Click(object sender, EventArgs e)
        {
            using(var db = new ReservationContext())
            {
                IEnumerable<Person> filter = db.People;
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
                    dataGridView2.Rows.Add(p.PersonId, p.Name, p.Surname, p.BirthDate.ToShortDateString());
                }
            }
        }

        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells[0].Value != null && dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                using(var db = new ReservationContext())
                {
                    Reservation r = new Reservation();
                    int index = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    r.film = db.Films.Single(x => x.FilmId == index);
                    index = (int)dataGridView2.CurrentRow.Cells[0].Value;
                    r.person = db.People.Single(x => x.PersonId == index);
                    db.Reservations.Add(r);
                    db.SaveChanges();
                    dataGridView3.Rows.Add(r.ReservationId, r.PersonId, r.FilmId);
                }
            }
        }

        private void ButtonResDel_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0 &&
                dataGridView3.SelectedRows[0].Index !=
                dataGridView3.Rows.Count - 1)
            {
                using(var db = new ReservationContext())
                {
                    Reservation r = new Reservation();
                    r.ReservationId = (int)dataGridView3.CurrentRow.Cells[0].Value;
                    db.Reservations.Remove(r);
                    db.SaveChanges(); dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
                }

            }
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.CurrentRow.Cells[0].Value != null)
            {
                using(var db = new ReservationContext())
                {
                    int index = (int)dataGridView3.CurrentRow.Cells[0].Value;
                    Reservation r = db.Reservations.Single(x => x.ReservationId == index);
                    Film f = db.Films.Single(x => x.FilmId == r.FilmId);
                    Person p = db.People.Single(x => x.PersonId == r.PersonId);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(f.FilmId, f.Title, f.Type, f.Direction, f.Release_date.ToShortDateString());
                    dataGridView2.Rows.Clear();
                    dataGridView2.Rows.Add(p.PersonId, p.Name, p.Surname, p.BirthDate.ToShortDateString());
                }

            }
        }
    }
    public class ReservationContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ReservationsDb;Trusted_Connection=True;");
        }
    }
    public class Film
    {
        public int FilmId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Direction { get; set; }
        public DateTime Release_date { get; set; }

        public List<Reservation> Reservations { get; set; }

    }
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
    public class Reservation
    {
        public int ReservationId { get; set; }

        public Film film { get; set; }
        public int FilmId { get; set; }
        public Person person { get; set; }
        public int PersonId { get; set; }
    }
}
