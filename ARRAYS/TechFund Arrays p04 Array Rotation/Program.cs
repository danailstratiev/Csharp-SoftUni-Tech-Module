using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Arrays_p04_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                numbers = Rotated(numbers);
            }
            Console.WriteLine(string.Join(" ",numbers));

        }static int[]Rotated (int[]numbers)
        {
            int[] rotated = new int[numbers.Length];
            rotated[rotated.Length - 1] = numbers[0];

            for (int i = 0; i < rotated.Length-1; i++)
            {
                rotated[i] = numbers[i+1];
            }
            return rotated;
        }
    }
}
