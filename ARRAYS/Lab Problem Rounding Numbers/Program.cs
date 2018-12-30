using System;
using System.Linq;

namespace Lab_Problem_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "-5.01 -1.599 -2.5 -1.50 0";
            double[] numbers = text.Split(' ').Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                var roundednumber = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {roundednumber}");
            }
        }
    }
}
