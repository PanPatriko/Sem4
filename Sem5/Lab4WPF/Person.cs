using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFLab4
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int Year { get; set; }

        public Uri Photo { get; set; }

        public Person(string name,string surname,string city,int year)
        {
            Name = name;
            Surname = surname;
            City = city;
            Year = year;
        }


    }
}
