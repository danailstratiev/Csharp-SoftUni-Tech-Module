using System;
using System.Linq;
using System.Collections.Generic;


namespace Lists_Exercise_6._1_Sum_Reverse_Numbers_Version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                List<char> num = numbers[i].ToString().ToList();
                num.Reverse();
                sum += int.Parse(string.Join("",num));
            }
            Console.WriteLine(sum);
        }
    }
}
