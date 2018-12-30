using System;
using System.Linq;
using System.Collections.Generic;



namespace Lists_Lab_6_Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> squares = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                var square = Math.Sqrt(currentNumber);

                if (square == (int) square)
                {
                    squares.Add(currentNumber);
                }
            }
            squares.Sort();
            squares.Reverse();

            Console.WriteLine(string.Join(" ",squares));
        }
    }
}
