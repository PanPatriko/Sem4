using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person Mom { get; set; }
        public Person Dad { get; set; }
        public DateTime BirtDate { get; set; }
        public string BirthPlace { get; set; }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
        public override bool Equals(object obj)
        {
            if (Dad == null || Mom == null) return false;
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
