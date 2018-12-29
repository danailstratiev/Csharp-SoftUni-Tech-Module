using System;

namespace _2._1_Choose_a_drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default: Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
