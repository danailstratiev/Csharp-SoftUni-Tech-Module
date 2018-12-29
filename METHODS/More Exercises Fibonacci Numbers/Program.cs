using System;

namespace _4._5_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var result = FibonacciNumber(number);
            Console.WriteLine(result);
        }
        static int FibonacciNumber (int number)
        {
            int f0 = 0;
            int f1 = 1;
            int nextF = 0;

            for (int i = 0; i < number; i++)
            {
                nextF = f0 + f1;
                f0 = f1;
                f1 = nextF;
            }
            return f1;
        }

    }
}
