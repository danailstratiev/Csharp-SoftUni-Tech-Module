using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_10_Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            for (int i = 1; i <= number; i++)
            {
                if (DivisibleBy8(i) == true && HoldsOddDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool DivisibleBy8 (int n)
        {
            int number = n;
            int sumOfDigits = 0;
            bool isDivisible = false;

            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            if (sumOfDigits % 8 == 0)
            {
                isDivisible = true;
            }
            else
            {
                isDivisible = false;
            }
            return isDivisible;
        }
        static bool HoldsOddDigit (int n)
        {
            int number = n;
            int oddNumber = 0;
            bool holdOdd = false;

            while (number > 0)
            {
                oddNumber = number % 10;
                if (oddNumber % 2 == 1)
                {
                    holdOdd = true;
                    break;
                }
                number /= 10;
            }
            return holdOdd;
        }
    }
}
