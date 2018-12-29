using System;
using System.Linq;

namespace Exercise_8_Most_frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int [] counters = new int [numbers.Length];
            int counterMax = 0;
            int maxNumber = 0; 

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counters[i]++;

                        if (counters[i] > counterMax)
                        {
                            counterMax = counters[i];
                            maxNumber = numbers[i];
                        }
                    }
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
