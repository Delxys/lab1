﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1
{
    public class Simpson : Abs
    {
        public override Task<double> Count(int n, double a, double b, CancellationToken token, IProgress<int> progress, Func<double, double> newfunc)
        {
            return Task<double>.Factory.StartNew(() =>
            {
                if ((a < b) && (n > 0)&&(a >= 0))
                {
                    int count = 0;
                    double res = 0;
                    double h = (b - a) / n;
                    for (int i = 0; i < n; i++)
                    {
                        token.ThrowIfCancellationRequested();
                        res += (newfunc(a + h * i) + 4 * newfunc(a + h * (i + 0.5)) + newfunc(a + h * (i + 1))) * h / 6;
                        Interlocked.Increment(ref count);
                        if (i % (0.1 * n) == 0 || (i == n - 1))
                        {
                            progress.Report(count * 100 / n);
                        }

                    }
                    return res;
                }
                else
                {
                    throw new ArgumentException();
                }
            }, token);
        }
        public override Task<double> PCount(int n, int a, int b, CancellationToken token, IProgress<int> progress, Func<double, double> newfunc)
        {
            return Task<double>.Factory.StartNew(() =>
            {
                double Result = 0.0;
                int count = 0;
                if ((a < b) && (n > 0) && (a >= 0))
                {
                    double h = (double)((b - a)) / n;
                    var bag = new ConcurrentBag<double>();
                    Parallel.For<double>(0, n, () => 0, (i, state, subres) =>
                    {
                        double tmp;
                        token.ThrowIfCancellationRequested();
                        tmp = (newfunc(a + h * i) + 4 * newfunc(a + h * (i + 0.5)) + newfunc(a + h * (i + 1))) * h / 6;
                        subres += tmp;
                        Interlocked.Increment(ref count);
                        if (count % (0.1 * n) == 0 || (count == n - 1))
                        {
                            progress.Report(count * 100 / n);
                        }
                        return subres;

                    }, (x) => bag.Add(x));

                    Result = bag.Sum();
                }
                else
                {
                    throw new ArgumentException();
                }
                return Result;
            }, token);
        }
    }
}
