using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Arrays_p05_Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxNumber = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {                
              if (numbers[i] > numbers.Skip(i+1).Max())
               {
                Console.Write(numbers[i] + " ");
               }                              
            }
            Console.Write(numbers[numbers.Length-1] + " ");
        }
    }
}
