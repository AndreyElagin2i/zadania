using System;

namespace заданиеСаши
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            int i;
            for (i = 0; i < n; i++)
                myArray[i] = i * i;
            for (i = 0; i < n; i++)
                Console.Write(myArray[i]+" ");
            Console.WriteLine();
            for (i = 0; i < n; i++)
                if (myArray[i] % 8 == 0)
                {
                    myArray[i] = 0;
                }
            for (i = 0; i < n; i++)
                Console.Write(myArray[i] + " ");
        }
    }
}
