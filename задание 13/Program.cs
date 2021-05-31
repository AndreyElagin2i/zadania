using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,x,y,f,z,c;
            Console.WriteLine("Введите a,b,x,c");
            a=Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            y = (Math.Sin(3 *x / 3) - (Math.Cos (4 * x )/ 4));
            f = (Math.Pow(x, 4) + a * Math.Pow(x, 2) + b * x)/c;
            z = (5 * y + 3 * f) / x;
            Console.WriteLine("y=" + y);
            Console.WriteLine("f=" + f);
            Console.WriteLine("z=" + z);
            Console.ReadKey();
        }
    }
}
