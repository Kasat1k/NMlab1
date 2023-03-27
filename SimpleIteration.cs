using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMlab1
{
    public class SimpleIteration
    {
        double eps;
        public SimpleIteration(double e = 0.00001)
        {
            eps = e;
            SimpleIterationMethod();
        }
        double func(double x)
        {
            return Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - 8 * x + 9;
        }
        // x=x-a(Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - 8 * x + 9)
        // a=1/max(3*Math.Pow(x, 2) - 4 * x - 8 )=1/31=0.0323
        double Gfun(double x)
        {
            return 0.0323 * (Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - 8 * x + 9);
        }

        void SimpleIterationMethod()
        {
    
            double xn = -3;
            double q = Gfun(xn);
            q = Math.Abs(q);
            //Console.WriteLine(q);
            //Console.WriteLine(Math.Log(1 / q));
            double a= (int)(Math.Log(Math.Abs(func(xn)-xn)/((1-q)* eps))/Math.Log(1/q))+1;
           // Console.WriteLine($"Апріорна оцінка : n <= {a}");
            double apos = (1 - q) / q * eps;
            //Console.WriteLine(apos);
            double xnext;
            Console.WriteLine($" Iteration {1}\t x = {xn:F10} \t x(k)-x(k-1) ={xn:F10} \t f(x) = {func(xn):F10}");
            int i = 1;
            bool flag=false;
            bool flagCout=false;
            bool flagEps = false;
            while (true)
            {
                xnext = xn - Gfun(xn);
                double xmx = xnext - xn;
                if (Math.Abs(xmx) < apos && flag==false) { apos = i; flag = true; }
                if (Math.Abs(xmx) <= eps && Math.Abs(func(xnext)) <= eps && flagEps == false) { Console.WriteLine($"x(k)-x(k-1)<Eps , |f(x)|<Eps у минулiй iтерацiї"); flagEps = true; }
                if(i==a) { break; }
                xn = xnext;
                if (flag==true && flagCout==false) {Console.WriteLine($"Iтерацiя апостерiорної оцiнки {apos}"); flagCout = true; }
                Console.WriteLine($" Iteration {++i} \t x = {xnext:F10}\t x(k)-x(k-1) ={xmx:F10} \t f(x) = {func(xnext):F10} ");
        
            }
            Console.WriteLine($"Апрiорна оцiнка : n <= {a}");
            Console.WriteLine($"Апострiорна оцiнка : n = {apos}");
        }
    }
}
