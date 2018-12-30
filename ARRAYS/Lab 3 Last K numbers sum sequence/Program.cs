using System;

namespace Lab_3_Last_K_numbers_sum_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            numbers[0] = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                int sum = 0;
                int counter = 0;

                for (int j = i; j >= 0 ; j--)
                {
                    sum += numbers[j];
                    counter++;

                    if (counter > k)
                    {
                        break;
                    }
                }
                numbers[i] = sum;
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
