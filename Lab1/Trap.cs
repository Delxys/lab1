using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Trap : Abs
    {
        public string ErrorInfo;
        public double Result = 0.0;
        public override double Count(int n, double a, double b, Func<double, double> newfunc)
        {
            try
            {
                if ((a < b) && (n > 0) && (a >= 0))
                {
                    double h = (b - a) / n;
                    double res = 0;

                    for (int i = 0; i < n; i++)
                        res += newfunc(a + h * (i + 0.5));
                    res *= h;
                    return res;

                }
                else
                {
                    throw new ArgumentException();
                }

            }
            catch (ArgumentException ae)
            {
                ErrorInfo = ae.Message;
                return 0.0;
            }

        }
        public override double PCount(int n, int a, int b, Func<double, double> newfunc)
        {
            
            try
            {
                if ((a < b) && (n >= 0) && (a >= 0))
                {
                   
                    double h = (double)((b - a)) / n;
                    var bag = new ConcurrentBag<double>();
                    Parallel.For<double>(0, n, () => 0, (i, state, subres) =>
                    {
                        double tmp;
                        tmp = h * newfunc(a + h * (i + 0.5));
                        subres += tmp;
                        return subres;

                    }, (x) => bag.Add(x));

                    Result = bag.Sum();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException ae)
            {
                ErrorInfo = ae.Message;
                Result= 0.0;
            }
            return Result;
        }
    }
}

