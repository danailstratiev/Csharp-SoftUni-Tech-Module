using System;
using System.Linq;
using System.Collections.Generic;


namespace List_Exercise_3_Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int[] conditions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            List<int> newNumbers = new List<int>();

            for (int i = 0; i < conditions[0]; i++)
            {
                newNumbers.Add(numbers[i]);
            }
            int secondTask = conditions[1];
            newNumbers.RemoveRange(0,secondTask);

            if (newNumbers.Contains(conditions[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
