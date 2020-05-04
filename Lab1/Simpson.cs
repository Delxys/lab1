using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Simpson : Abs
    {

        public string ErrorInfo;
        public override double Count(int n,double a, double b, Func<double, double> newfunc)
        {
            try
            {
                if ((a < b) && (n > 0)&&(a >= 0))
                {
                    double res = 0;
                    double h = (b - a) / n;
                    for (int i = 0; i < n ; i++)
                        res += (newfunc(a + h * i) + 4 * newfunc(a + h * (i + 0.5)) + newfunc(a + h * (i + 1))) * h / 6;
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
            }
            return 0.0;
        }
        public override double PCount(int n, int a, int b, Func<double, double> newfunc)
        {
            double Result = 0.0;
            try
            {
                if ((a < b) && (n > 0) && (a >= 0))
                {

                    double h = (double)((b - a)) / n;
                    var bag = new ConcurrentBag<double>();
                    Parallel.For<double>(0, n, () => 0, (i, state, subres) =>
                    {
                        double tmp;
                        tmp = (newfunc(a + h * i) + 4 * newfunc(a + h * (i + 0.5)) + newfunc(a + h * (i + 1))) * h / 6;
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
                Result = 0.0;
            }
            return Result;
        }
    }
}
