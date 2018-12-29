using System;
using System.Numerics;

namespace _4._14_Factorial_Trailing_Zones
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Factorial(n);
        }
        static void Factorial(int n)
        {
            BigInteger factorialofN = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialofN *= i;
            }
            int sum = 0;
            while (factorialofN % 10 == 0)
            {
                sum++;
                factorialofN /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
