using System;
using System.Linq;
using System.Collections.Generic;


namespace List_Exercise_6_Reversed_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int sum = 0;
            int reversedNumber = 0;


            for (int i = 0; i < numbers.Count; i++)
            {
                while (numbers[i] > 0)
                {
                    reversedNumber *= 10;
                    reversedNumber += numbers[i] % 10;
                    numbers[i] /= 10;
                }
                sum += reversedNumber;
                reversedNumber = 0;
            }
            Console.WriteLine(sum);
        }
    }
}
