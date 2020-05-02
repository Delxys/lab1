using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Simpson : Abs
    {
        public override double Count(int n,double a, double b, Func<double, double> newfunc)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException("error", "N должно быть > 0");
            double res = 0;
            double h = (b - a) / n;
            for (int i = 0; i < n-1; i++)
                res += (newfunc(a + h * i) + 4* newfunc(a + h * (i + 0.5)) + newfunc(a + h * (i + 1)))*h / 6;
            return res;
        }
    }
}
