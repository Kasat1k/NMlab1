using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMlab1
{
    public class ModificatedNewthon
    {
        double eps;
        public ModificatedNewthon(double e = 1e-5)
        {
            eps = e;
            ModificatedNewthonMethod();
        }

        double func(double x)
        {
            return Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - 8 * x + 9;
        }

        void ModificatedNewthonMethod()
        {
            double fx= 3 * Math.Pow(-3, 2) - 4 * (-3) - 8;
            double a = -3;
            double b = -2;
            double x = a;
            double prx;

            int i = 1;
            Console.WriteLine($" Iteration 1 \t x = {x:F10}\t x(k)-x(k-1) ={x - 0:F10} \t f(x) = {func(x):F10} ");
            do
            {
                prx = x;
                x -= func(x) / fx;

                Console.WriteLine($" Iteration {++i} \t x = {x:F10}\t x(k)-x(k-1) ={x - prx:F10} \t f(x) = {func(x):F10} ");
            }
            while (Math.Abs(func(x)) >= eps );

        }
    }
}
