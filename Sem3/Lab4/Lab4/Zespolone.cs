using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Zespolone
    {
        public double Rzeczywista { get; set; }
        public double Urojona { get; set; }
        public Zespolone(double r, double u)
        {
            Rzeczywista = r;
            Urojona = u;
        }
        public static Zespolone operator +(Zespolone zesp1, Zespolone zesp2)
        {
            return new Zespolone(zesp1.Rzeczywista + zesp2.Rzeczywista, zesp1.Urojona + zesp2.Urojona);
        }
        public static Zespolone operator -(Zespolone zesp1, Zespolone zesp2)
        {
            return new Zespolone(zesp1.Rzeczywista - zesp2.Rzeczywista, zesp1.Urojona - zesp2.Urojona);
        }
        public static Zespolone operator *(Zespolone zesp1, Zespolone zesp2)
        {
            double r, u;
            if ((zesp1.Urojona != 0) && (zesp2.Urojona != 0))
            {
                r = ((zesp1.Rzeczywista * zesp2.Rzeczywista) - (zesp1.Urojona * zesp2.Urojona));
                u = (zesp1.Rzeczywista * zesp2.Urojona) + (zesp1.Urojona * zesp2.Rzeczywista);
                return new Zespolone(r, u);
            }
            r = (zesp1.Rzeczywista * zesp2.Rzeczywista);
            u = (zesp1.Rzeczywista * zesp2.Urojona) + (zesp1.Urojona * zesp2.Rzeczywista);
            return new Zespolone(r, u);
        }
        public static Zespolone operator /(Zespolone zesp1, Zespolone zesp2)
        {
            double r, u;
            if ((zesp2.Urojona != 0))
            {
                r = ((zesp1.Rzeczywista * zesp2.Rzeczywista) + (zesp1.Urojona * zesp2.Urojona)) / ((Math.Pow(zesp2.Rzeczywista, 2) + Math.Pow(zesp2.Urojona, 2)));
                u = (-(zesp1.Rzeczywista * zesp2.Urojona) + (zesp1.Urojona * zesp2.Rzeczywista)) / ((Math.Pow(zesp2.Rzeczywista, 2) + Math.Pow(zesp2.Urojona, 2)));
                return new Zespolone(r, u);
            }
            r = (zesp1.Rzeczywista / zesp2.Rzeczywista);
            u = (zesp1.Urojona / zesp2.Rzeczywista);
            return new Zespolone(r, u);

        }
        public static bool operator ==(Zespolone zesp1, Zespolone zesp2)
        {
            if ((zesp1.Rzeczywista == zesp2.Rzeczywista) && (zesp1.Urojona == zesp2.Urojona)) return true;
            return false;
        }
        public static bool operator !=(Zespolone zesp1, Zespolone zesp2)
        {
            if ((zesp1.Rzeczywista != zesp2.Rzeczywista) || (zesp1.Urojona != zesp2.Urojona)) return true;
            return false;
        }
        public static bool operator >(Zespolone zesp1, Zespolone zesp2)
        {
            double mod1, mod2;
            mod1 = Math.Sqrt(Math.Pow(zesp1.Rzeczywista, 2) + Math.Pow(zesp1.Urojona,2));
            mod2 = Math.Sqrt(Math.Pow(zesp2.Rzeczywista, 2) + Math.Pow(zesp2.Urojona,2));
            if (mod1 > mod2) return true;
            return false;

        }
        public static bool operator <(Zespolone zesp1, Zespolone zesp2)
        {
            double mod1, mod2;
            mod1 = Math.Sqrt(Math.Pow(zesp1.Rzeczywista, 2) + Math.Pow(zesp1.Urojona, 2));
            mod2 = Math.Sqrt(Math.Pow(zesp2.Rzeczywista, 2) + Math.Pow(zesp2.Urojona, 2));
            if (mod1 < mod2) return true;
            return false;
        }
        public override bool Equals(Object obj)
        {
            Zespolone liczba = (Zespolone)obj;
            return (Rzeczywista == liczba.Rzeczywista) && (Urojona == liczba.Urojona);
        }
        public override int GetHashCode()
        {
            return (int)(Rzeczywista.GetHashCode() + Urojona.GetHashCode());
        }

    }
}
