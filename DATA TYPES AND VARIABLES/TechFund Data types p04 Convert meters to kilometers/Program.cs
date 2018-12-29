using System;

namespace TechFund_Data_types_p04_Convert_meters_to_kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double kilometers = meters * 0.001;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
