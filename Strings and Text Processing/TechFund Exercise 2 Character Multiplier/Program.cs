using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace Exercise_4_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] someString = Console.ReadLine().Split(" ").ToArray();
            string first = someString[0];
            string second = someString[1];
            int sum = 0;
            int diff = 0;

            if (first.Length > second.Length)
            {
                diff = first.Length - second.Length;

                for (int i = 0; i < diff; i++)
                {
                    second += "|";
                }
            }
            else if (second.Length > first.Length)
            {
                diff = second.Length - first.Length;

                for (int i = 0; i < diff; i++)
                {
                    first += "|";
                }
            }

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == 124)
                {
                sum += 1 * second[i];                    
                }
                else if(second[i] == 124)
                {
                    sum += first[i] * 1;
                }
                else
                {
                    sum += first[i] * second[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
