﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMlab1
{
    public class Newton
    {
        double eps;
        public Newton(double e = 1e-5)
        {
            eps = e;
            NewtonMethod();
        }

        double func(double x)
        {
            return Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - 8 * x + 9;
        }

        double Dfun(double x)
        {
            return 3 * Math.Pow(x, 2) -4 * x - 8;
        }
        double SDfun(double x)
        {
            return 6 * x - 4;
        }

        void NewtonMethod()
        {
            double a = -3;
            double b = -2;
            double x = a;
            double prx;
            //double min = Math.Abs(Dfun(a));
           // double max = Math.Abs(SDfun(b));
            //double q = max * Math.Abs(a - b) / 2 / min;
            //double an = Math.Log((Math.Log(3.0) / eps) / Math.Log(1 / q),2)+1+1;
            //Console.WriteLine(q);
           //Console.WriteLine(an);
            int i = 1;
            Console.WriteLine($" Iteration 1 \t x = {x:F10}\t x(k)-x(k-1) ={x - 0:F10} \t f(x) = {func(x):F10} ");
            do
            {
                prx = x;
                x -= func(x) / Dfun(x);
  
                Console.WriteLine($" Iteration {++i} \t x = {x:F10}\t x(k)-x(k-1) ={x - prx:F10} \t f(x) = {func(x):F10} ");
            }
            while (Math.Abs(func(x)) >= eps || (Math.Abs(x-prx))>=eps);
           
        }
    }
}