using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Simpson : Abs
    {
        private const double left = 1;
        private const double right = 100;
        public override double Count(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException("error", "N должно быть > 0");
            double res = 0;
            double h = (right - left) / n;
            for (int i = 0; i < n-1; i++)
                res += (Func(left + h * i) + 4*Func(left + h * (i + 0.5)) + Func(left + h * (i + 1)))*h / 6;
            return res;
        }
    }
}
