using System;
using System.Numerics;

namespace _4._13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Factorial(n);
        }
        static void Factorial (int n)
        {
           BigInteger factorialofN = 1;

            for (int i = 1; i <= n; i++)
            {
             factorialofN *= i;
            }
            Console.WriteLine(factorialofN);
        }
    }
}
