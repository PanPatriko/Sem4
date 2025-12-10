using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Calculations
    {
        public double SquareField(double a)
        {
            if (a <= 0) throw new ArgumentException("Incorrect side of the square");
            return a * a;
        }
        public double Multiply(double a,double b)
        {
            return a * b;
        }
        public double Division(double dividend, double divider)
        {
            if (divider == 0) throw new DivideByZeroException();
            return dividend / divider;
        }
        public double TriangleCircuit(double a,double b,double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Incorrect sides of the triangle");
            else if (!(a < b + c && b < a + c && c < a + b)) throw new Exception("The sum of the lengths of any two sides of a triangle must be greater than the length of the third side.");
            return a + b + c;
        }
    }
}
