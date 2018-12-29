using System;

namespace _1._3_Miles_to_Kilometres
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = a * 1.60934;
            Console.WriteLine($"{b:F2}");
        }
    }
}
