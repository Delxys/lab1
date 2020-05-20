using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class Abs
    {
        public abstract Task<double>  Count(int n, double a, double b, CancellationToken token, IProgress<int> progress, Func<double, double> myfunc);
        public abstract Task<double> PCount(int n, int a, int b, CancellationToken token, IProgress<int> progress, Func<double, double> myfunc);
    }
}
