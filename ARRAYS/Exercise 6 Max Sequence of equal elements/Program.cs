using System;
using System.Linq;

namespace Exercise_6_Max_Sequence_of_equal_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int counter = 1;
            // niama logica poredica da e ot 0 elementa
            int maxCounter = 0;
            int numberMax = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                // do lenght-1 za da ne grumne masiva s i+1
                if (numbers[i] == numbers[i+1] )
                {
                    counter++;
                }
                else
                {
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        numberMax = numbers[i];
                    }
                    counter = 1;
                }
                if (i + 1 == numbers.Length-1)
                {
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        numberMax = numbers[i];
                    }
                    counter = 1;
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(numberMax + " ");
            }
        }
    }
}
