using System;

namespace _1._2_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = a * b;

            Console.WriteLine($"{result:F2}");
        }
    }
}
