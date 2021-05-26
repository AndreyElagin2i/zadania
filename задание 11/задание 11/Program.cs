using System;

namespace задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            for (a = -15; a <= 15; a++)
            {

                if (a % 3 == 0)
                {
                     b = b + 1;
                }
               
            }
            b = b - 1;
            Console.WriteLine("Чисел кратных 3 = " + b);
            Console.WriteLine("Не считая ноля.");

        }
    }
}
