using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Lab_7_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            numbers.Sort();

            var currentNumber = numbers[0];
            var currentCount = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (currentNumber == numbers[i])
                {
                    currentCount++;
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> {currentCount}");
                    currentNumber = numbers[i];
                    currentCount = 1;
                }
            }
            Console.WriteLine($"{currentNumber} -> {currentCount}");
        }
    }
}
