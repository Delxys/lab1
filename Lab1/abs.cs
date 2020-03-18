using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class Abs
    {
        public Abs()
        {
        }
        public double Func(double x)
        {
            return (32 * x) - Math.Log(2 * x) - 41;
        }
        public abstract double Count(int n, double a, double b);
    }
}
