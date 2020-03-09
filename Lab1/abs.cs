using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Abs
    {
        public double A { get; set; }
        public double B { get; set; }

        public Abs(double a, double b)
        {
            A = a;
            B = b;
        }
        public double Func(double x)
        {
            return (32 * x) - Math.Log(2 * x)-41;
        }
    }
}
