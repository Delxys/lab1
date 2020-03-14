﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Trap : Abs
    {
        private const double left = 1;
        private const double right = 100000;
        public Trap(double left, double right):base(left,right)
        {
        }
        
        public override double Count(int n)
        {
            double h = (right - left) / n;
            double res = 0;

            for (int i = 1; i < n - 1; i++)
            {
                res += h * (Func(left + (h * i)));
            }

            res += (h * ((Func(left) + Func(right)) / 2));

            return res;
        }
    }
}
