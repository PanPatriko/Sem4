using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Person
    {
        public string Name { get; set; }
        public Gender gender;
        public MaritalStatus status;
        public Hobby hobby;

        public enum Gender { Unkonwn, Male, Female  }
        public enum MaritalStatus
        {
            Unknown,
            Single,
            Married,
            Widowed,
            Divorcee,
        }
        [Flags]
        public enum Hobby
        {
            NotSpecified = 0,
            Cars = 1,
            Films = 2,
            Football = 4,
            Books = 8,
            Computers = 16
        }
        public override string ToString()
        {
            return Name+" "+gender.ToString()+" "+status.ToString()+" "+hobby.ToString();
        }
    }
}
