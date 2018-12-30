using System;
using System.Linq;
using System.Collections.Generic;


namespace More_Exercises_4_Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            int index = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == n)
                {
                    index = i;
                }
            }
            if (!numbers.Contains(n))
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
            Console.WriteLine(numbers.Take(index).Sum());                        
            }
        }
    }
}
