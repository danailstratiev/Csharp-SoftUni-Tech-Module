using System;
using System.Linq;


namespace Exercise_10_Pairs_by_differece
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayofNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arrayofNumbers.Length; i++)
            {
                for (int j = 0; j < arrayofNumbers.Length; j++)
                {
                    if (arrayofNumbers[i] != arrayofNumbers[j])
                    {
                        if (Math.Abs(arrayofNumbers[i]-arrayofNumbers[j]) == difference)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter/2);
        }
    }
}
