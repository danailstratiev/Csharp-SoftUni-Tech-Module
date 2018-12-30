using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Arrays_p02_Common_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words1 = Console.ReadLine().Split(" ").ToList();
            List<string> words2 = Console.ReadLine().Split(" ").ToList();

            for (int i = 0; i < words2.Count; i++)
            {
                if (words1.Contains(words2[i]))
                {
                    Console.Write(words2[i] + " ");
                }
            }

        }
    }
}
