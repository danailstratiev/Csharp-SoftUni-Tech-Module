using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_5_Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"{numbers[0] + numbers[1] - numbers[2]}");

        }
    }
}
