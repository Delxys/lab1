using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Trap : Abs
    {
        
        public override double Count(int n, double a, double b, Func<double, double> newfunc)
        { 
            if (n < 0)
                throw new ArgumentOutOfRangeException("Поле N", "N должно быть > 0");
            if (a < 0)
                throw new ArgumentOutOfRangeException("Левая граница", "Левая граница должна быть целым числом > 0");
            double h = (b - a) / n;
            double res = 0;

            for (int i = 1; i < n - 1; i++)
            {
                res += h * (newfunc(a + (h * i)));
            }

            res += (h * ((newfunc(a) + newfunc(b)) / 2));

            return res;
        }
    }
}
