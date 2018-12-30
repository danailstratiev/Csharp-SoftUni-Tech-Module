using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Lists_Exercises_6_Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (first.Count > 0 && second.Count > 0)
            {
                for (int i = 0; i < Math.Min(first.Count, second.Count); i++)
                {
                    if (first[i] > second[i])
                    {
                        first.Add(first[i]);
                        first.Add(second[i]);
                        second.RemoveAt(i);
                        first.RemoveAt(i);
                    }
                    else if (second[i] > first[i])
                    {
                        second.Add(second[i]);
                        second.Add(first[i]);
                        first.RemoveAt(i);
                        second.RemoveAt(i);
                    }
                    else if (first[i] == second[i])
                    {
                        first.RemoveAt(i);
                        second.RemoveAt(i);
                    }
                }
            }
                if (first.Count > 0)
                {
                    Console.WriteLine($"First player wins! Sum: {first.Sum()}");
                }
                else if(second.Count > 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
                }
            

        }
    }
}
