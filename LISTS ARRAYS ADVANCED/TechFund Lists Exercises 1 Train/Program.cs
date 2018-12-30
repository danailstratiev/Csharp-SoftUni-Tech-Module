using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_p01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> wagons = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int wagon = int.Parse(Console.ReadLine());
                wagons.Add(wagon);
            }
            Console.WriteLine(string.Join(" ",wagons));
            int sum = wagons.Sum();
            Console.WriteLine(sum);
        }
    }
}
