using System;

namespace Exercise_8_Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            decimal factorialA = 1.00m;

            for (int i = 1; i <= a; i++)
            {
                factorialA *= i;
            }

            decimal factorialB = 1.00m;

            for (int i = 1; i <= b; i++)
            {
                factorialB *= i;
            }

            decimal result = factorialA / factorialB;

            Console.WriteLine($"{result:F2}");
        }
        
    }
}
