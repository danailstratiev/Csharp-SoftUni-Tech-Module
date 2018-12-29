using System;

namespace _1._5_Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string currentHealt = new string('|', health) + new string('.', maxHealth - health);
            string currentEnergy = new string('|', energy) + new string('.', maxEnergy - energy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{currentHealt}|");
            Console.WriteLine($"Energy: |{currentEnergy}|");

        }
    }
}
