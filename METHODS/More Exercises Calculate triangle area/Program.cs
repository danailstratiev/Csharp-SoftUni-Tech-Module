using System;

namespace _4._6_Lab_Calculate_triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideHa = double.Parse(Console.ReadLine());
            var result = FindArea(sideA, sideHa);
            Console.WriteLine(result);

        }

        static double FindArea (double sideA, double sideHa)
        {
            return sideA * sideHa / 2;
        }
    }
}
