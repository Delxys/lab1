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
        public abstract double Count(int n, double a, double b, Func<double, double> myfunc);
    }
}
