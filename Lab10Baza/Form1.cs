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

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new OwnerContext())
            {
                dataGridView1.DataSource = db.Cars.ToList();
                dataGridView2.DataSource = db.Person.ToList();
            }
        }

        private void ButtonAddCar_Click(object sender, EventArgs e)
        {
            if (textBoxMake.Text == "") label5.Text = "Pusta wartość pola Marka";
            else if (textBoxModel.Text == "") label5.Text = "Pusta wartość pola Model";
            else if (!int.TryParse(textBoxYear.Text, out int year)) label5.Text = "Niepoprawna wartość pola Rok";
            else if (textBoxEngine.Text == "") label5.Text = "Pusta wartość pola Silnik";
            else
            {
                using (var db = new OwnerContext())
                {
                    label5.Text = "";
                    Car c = new Car();
                    c.Brand = textBoxMake.Text;
                    c.Model = textBoxModel.Text;
                    c.Year = year;
                    c.Engine = textBoxEngine.Text;
                    db.Cars.Add(c);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.Cars.ToList();
                }
            }
        }

        private void ButtonEditCar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                if (textBoxMake.Text == "") label5.Text = "Pusta wartość pola Marka";
                else if (textBoxModel.Text == "") label5.Text = "Pusta wartość pola Model";
                else if (!int.TryParse(textBoxYear.Text, out int year)) label5.Text = "Niepoprawna wartość pola Rok";
                else if (textBoxEngine.Text == "") label5.Text = "Pusta wartość pola Silnik";
                else
                {
                    using (var db = new OwnerContext())
                    {
                        label5.Text = "";
                        int index = (int)dataGridView1.CurrentRow.Cells[0].Value;
                        Car c = db.Cars.Single(x => x.CarId == index);
                        c.Brand = textBoxMake.Text;
                        c.Model = textBoxModel.Text;
                        c.Year = year;
                        c.Engine = textBoxEngine.Text;
                        db.SaveChanges();
                        dataGridView1.DataSource = db.Cars.ToList();
                    }

                }
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                using (var db = new OwnerContext())
                {
                    int index = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    Car c = db.Cars.Single(x => x.CarId == index);
                    textBoxMake.Text=c.Brand;
                    textBoxModel.Text= c.Model;
                    textBoxYear.Text=c.Year.ToString();
                    textBoxEngine.Text=c.Engine;
                }
            }
        }

        private void ButtonDelCar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                using (var db = new OwnerContext())
                {
                    Car c = new Car();
                    c.CarId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    db.Cars.Remove(c);
                    db.SaveChanges();
                }
            }
        }

        private void ButtonAddP_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                if (textBoxName.Text == "") label5.Text = "Pusta wartość pola Imie";
                else if (textBoxSurname.Text == "") label5.Text = "Pusta wartość pola Nazwisko";
                else if (textBoxCity.Text == "") label5.Text = "Pusta wartość pola Miasto";
                else if (!DateTime.TryParse(maskedTextBoxBD.Text, out DateTime date)) label5.Text = "Niepoprawna data";
                else
                {
                    using (var db = new OwnerContext())
                    {
                        label5.Text = "";
                        int index = (int)dataGridView1.CurrentRow.Cells[0].Value;
                        var p = new Person();
                        p.Name = textBoxName.Text;
                        p.Surname = textBoxSurname.Text;
                        p.City = textBoxCity.Text;
                        p.BirthDate = date;
                        p.CarId = index;
                        db.Person.Add(p);
                        db.SaveChanges();                 
                        dataGridView2.DataSource = db.Person.ToList();
                    }
                }
            }
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null && dataGridView2.CurrentRow.Cells[0].Value != null)
            {
                using (var db = new OwnerContext())
                {
                    int index = (int)dataGridView2.CurrentRow.Cells[0].Value;
                    Person pp = db.Person.Single(x => x.PersonId == index);
                    textBoxName.Text = pp.Name;
                    textBoxSurname.Text = pp.Surname;
                    maskedTextBoxBD.Text = pp.BirthDate.ToString();
                    textBoxCity.Text = pp.City;

                    var entryPoint = (from p in db.Person
                                      join c in db.Cars on p.CarId equals c.CarId
                                      where p.PersonId == (int)dataGridView2.CurrentRow.Cells[0].Value
                                      select new
                                      {
                                          PersonId=p.PersonId,
                                          Name = p.Name,
                                          Surname = p.Surname,
                                          City = p.City,
                                          BirthDate = p.BirthDate,
                                          CarId = c.CarId,
                                          Brand=c.Brand,
                                          Model=c.Model,
                                          Engine = c.Engine,
                                          Year = c.Year,
                                      }).ToList();
                    dataGridView3.DataSource = entryPoint;
                }
            }
        }
        private void ButtonDelP_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells[0].Value != null)
            {
                using (var db = new OwnerContext())
                {
                    Person p = new Person();
                    p.PersonId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    db.Person.Remove(p);
                    db.SaveChanges();
                    dataGridView2.DataSource = db.Person.ToList();
                }
            }
        }
        private void ButtonEditP_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                if (textBoxName.Text == "") label5.Text = "Pusta wartość pola Imie";
                else if (textBoxSurname.Text == "") label5.Text = "Pusta wartość pola Nazwisko";
                else if (textBoxCity.Text == "") label5.Text = "Pusta wartość pola Miasto";
                else if (!DateTime.TryParse(maskedTextBoxBD.Text, out DateTime date)) label5.Text = "Niepoprawna data";
                else
                {
                    using (var db = new OwnerContext())
                    {
                        label5.Text = "";
                        int index = (int)dataGridView2.CurrentRow.Cells[0].Value;
                        Person p = db.Person.Single(x => x.PersonId == index);
                        p.Name = textBoxName.Text;
                        p.Surname = textBoxSurname.Text;
                        p.City = textBoxCity.Text;
                        p.BirthDate = date;
                        p.CarId = (int)dataGridView1.CurrentRow.Cells[0].Value; ;
                        db.SaveChanges();
                        dataGridView2.DataSource = db.Person.ToList();
                    }
                }
            }
        }
    }
    public class OwnerContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Person { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=lab10serv.database.windows.net;Initial Catalog=CarOwners;User ID=PanPatryk;Password=lab10!@#;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
    public class Car
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Year { get; set; }

        public List<Person> Person { get; set; }
    }
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public int CarId { get; set; }
    }
}
