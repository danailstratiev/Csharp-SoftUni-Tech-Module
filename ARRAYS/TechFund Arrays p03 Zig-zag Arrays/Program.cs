using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Arrays_p03_Zig_zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = new List<int>();
            List<int> second = new List<int>();

            int n = int.Parse(Console.ReadLine());
            int oldN = n;

            for (int i = 1; i <= n; i++)
            {
                int[] additions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    first.Add(additions[1]);
                    second.Add(additions[0]);
                }
                else
                {
                    first.Add(additions[0]);
                    second.Add(additions[1]);
                }
            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));

        }
    }
}
