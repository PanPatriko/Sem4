using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Osoba
    {
        public string Imie { get; set; }
        public DateTime Data { get; set; }
        public double Waga { get; set; }
        public char Plec { get; set; }
        public Osoba()
        {

        }
        public Osoba(string imie, DateTime data, double waga, char plec)
        {
            Imie = imie;
            Data = data;
            Waga = waga;
            Plec = plec;
        }
        public string zwrocDane()
            {
                 return Imie + " " + Data.ToBinary() ;
            }

        public override string ToString()
        {
            return Imie;
        }
    }
}
