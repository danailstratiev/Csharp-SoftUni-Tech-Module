using System;

namespace _4._7_Lab_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            Console.WriteLine(Power(number,power));
        }
        static double Power (int number, int power)
        {
            var result = 1.0;

            for (int i = 0; i < power; i++)
            {
                result *= number;

            }
            return result;
        }
    }
}
