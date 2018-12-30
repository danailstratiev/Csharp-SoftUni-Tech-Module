using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Lists_Exercises_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int bombNumber = commands[0];
            int bombPower = commands[1];

            while (numbers.Contains(bombNumber))
            {
                int position = numbers.IndexOf(bombNumber);

                if (0 > position - bombPower && position + bombPower >= numbers.Count)
                {
                    break;
                }
                else if (position - bombPower < 0)
                {
                    numbers.RemoveRange(0, position - 0 + 1 + bombPower);
                }
                else if (position + bombPower >= numbers.Count)
                {
                    numbers.RemoveRange(position - bombPower, bombPower + 1 + numbers.Count -1 - position);
                }
                else
                {
                    numbers.RemoveRange(position - bombPower, bombPower * 2 + 1);
                }
            }
            Console.WriteLine(numbers.Sum());            
        }
    }
}
