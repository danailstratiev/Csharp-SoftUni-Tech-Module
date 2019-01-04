using System;
using System.Linq;
using System.Collections.Generic;


namespace More_Exercises_2_Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> newNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    newNumbers.Add(numbers[i]);
                }
            }
            var avNum = newNumbers.Average();

            for (int i = 0; i < newNumbers.Count; i++)
            {
                if (newNumbers[i] <= avNum)
                {
                    newNumbers[i]--;
                }
                else if (newNumbers[i] > avNum)
                {
                    newNumbers[i]++;
                }
            }

            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
