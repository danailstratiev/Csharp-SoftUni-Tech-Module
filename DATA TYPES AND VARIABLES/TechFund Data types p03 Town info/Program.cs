using System;

namespace TechFund_Data_types_p03_Town_info
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            long area = long.Parse(Console.ReadLine());

            Console.WriteLine($"Town { town } has population of {population} and area {area} square km.");
        }
    }
}
