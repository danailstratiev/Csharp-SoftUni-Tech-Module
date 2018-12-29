using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_1_Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers.Add(n);
            }
            Console.WriteLine(numbers.Min());
        }
    }
}
