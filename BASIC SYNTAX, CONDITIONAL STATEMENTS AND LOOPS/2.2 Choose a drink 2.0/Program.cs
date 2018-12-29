using System;

namespace _2._2_Choose_a_drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalprise = 0;

            if (profession == "Athlete")
            {
                totalprise = quantity * 0.7;
            }
            else if (profession == "Businessman")
            {
                totalprise = quantity * 1.00;

            }
            else if (profession == "SoftUni Student")
            {
                totalprise = quantity * 1.7;
            }
            else
            {
                totalprise = quantity * 1.2;
            }
            Console.WriteLine($"The {profession} has to pay {totalprise:F2}.");
        }
    }
}
