using System;
using System.Linq;

namespace Exercise_3_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] upper = new int[numbers.Length / 2];
            int[] lower = new int[numbers.Length / 2];

            for (int i = 0; i < k*2; i++)
            {
                lower[i] = numbers[k + i];
            }
            for (int i = 0; i < k; i++)
            {
                upper[i] = numbers[k - 1 - i];
                upper[k + i] = numbers[4 * k - 1 - i];
            }
            int[] sum = new int[k * 2];

            for (int i = 0; i < k*2; i++)
            {
                sum[i] = upper[i] + lower[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
