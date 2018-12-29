using System;

namespace _4._6_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            IsPrime(number);
        }
        static void IsPrime(long number)
        {
            bool isPrime = true;

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }               
            }
            Console.WriteLine($"{isPrime}");
        }

    }
}
