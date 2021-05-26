using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Числа кратные 5");
            if (a% 5 ==0)
            {
                Console.WriteLine(a);
            }
            if (b%5==0)
            {
                Console.WriteLine(b);
            }
            if (c%5==0)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
