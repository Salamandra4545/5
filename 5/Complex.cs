using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Complex
    {
        private double a;
        private double b;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public Complex(int a, int b)
        {
            A = a;
            B = b;
        }



        public override string? ToString()
        {
            if (B > 0)
                return A + "+" + B + "i";
            else if (B < 0)
                return A + "-" + Math.Abs(B) + "i";
            return A.ToString();
        }
    }
}
