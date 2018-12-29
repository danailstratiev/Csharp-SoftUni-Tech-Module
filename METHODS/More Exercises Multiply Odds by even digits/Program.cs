using System;

namespace _4._9_Lab_Multiply_Odds_by_even_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var absNumber = Math.Abs(number);

            var result = GetMultipleOfEvensAndOdds(absNumber);

            Console.WriteLine(result);
        }
        static int GetMultipleOfEvensAndOdds(int number)
        {
            var evenSum = GetSumOfEvenDigits(number);
            var oddSum = GetSumOfOddDigits(number);

            return evenSum * oddSum;
        }
        static int GetSumOfEvenDigits(int number)
        {

            int sum = 0;

            while (number > 0)
            {
                var currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                var currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 == 1)
                {
                    sum += currentDigit;
                }
            }
                return sum;

        }


    }
}
