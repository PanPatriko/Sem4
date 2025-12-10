using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Osoba
    {
        public String imie;
        public String nazwisko { get; set; }
        public int rok_ur;
        public String Imie
        {
            get
            {
                return imie;
            }
            set
            {
                imie = value;
            }
        }
        public int Rok_ur
        {
            get
            {
                return rok_ur;
            }
            private set
            {
                rok_ur = value;
            }
        }
        public int Wiek
        {
            get
            {
                return 2018 - rok_ur;
            }
        }
        public String Imie_Nazwisko
        {
            get
            {
                return imie + "_" + nazwisko;
            }
        }
        public Osoba(string imie,string nazwisko,int rok_ur )
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rok_ur = rok_ur;
        }

        public override string ToString()
        {
            return Imie_Nazwisko;
        }
    }
}
