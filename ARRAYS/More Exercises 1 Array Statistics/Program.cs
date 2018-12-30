using System;
using System.Linq;
using System.Collections.Generic;




namespace More_Exercises_1_Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            int sumofElements = 0;
            double averageNumber = 0;

            averageNumber = sumofElements*1.0 / numbers.Length*1.0;

            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Average = {numbers.Average()}");

        }
    }
}
