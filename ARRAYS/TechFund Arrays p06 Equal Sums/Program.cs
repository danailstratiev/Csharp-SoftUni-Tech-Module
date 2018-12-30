using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Arrays_p06_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            bool isFound = false;

            for (int i = 0; i < numbers.Count; i++)
            {
               int leftSum = numbers.Take(i).Sum();
                int rightSum = numbers.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    isFound = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
