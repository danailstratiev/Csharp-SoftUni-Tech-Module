using System;

namespace _1._4_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energycon = int.Parse(Console.ReadLine());
            int sugarcon = int.Parse(Console.ReadLine());
            double realenergy = energycon * volume * 0.01;
            double realsugar = sugarcon * volume * 0.01;

            Console.WriteLine($"{volume}ml {name}: ");
            Console.WriteLine($"{realenergy}kcal, {realsugar}g sugars");
        }
    }
}
