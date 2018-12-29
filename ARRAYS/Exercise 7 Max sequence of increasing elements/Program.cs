using System;
using System.Linq;

namespace Exercise_7_Max_sequence_of_increasing_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int counterMax = 0;
            int startNumber = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] < numbers[i+1] && numbers[i]+1 == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        startNumber = numbers[i] - counterMax;
                    }
                    counter = 0;
                }
                if (numbers [i+1] == numbers[numbers.Length-1])
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        startNumber = numbers[i+1] - counterMax;
                    }
                    counter = 0;
                }
            }
            for (int i = startNumber; i <= counterMax + startNumber; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
