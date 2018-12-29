using System;

namespace _2._10_Triangle_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " " );
                }
                Console.WriteLine();
            }
        }
    }
}
