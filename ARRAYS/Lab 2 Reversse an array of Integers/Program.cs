using System;
using System.Linq;

namespace Lab_2_Reversse_an_array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            // може и по следния начин:
            //int[] reversednumbers = numbers.Reverse().ToArray;
            //което ще създаде нов масив
        }
    }
}
