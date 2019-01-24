using System;
using System.Linq;
using System.Collections.Generic;


namespace More_Exercises_3_Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            string virusName = Console.ReadLine();
            int power = 0;
            var health = initialHealth*1.00;
                Dictionary<string, int> viruses = new Dictionary<string, int>();
                int quantity = 1;
                viruses.Add(virusName,quantity);

            while (virusName != "end")
            {
                foreach (char symbol in virusName)
                {
                    power += symbol;
                }
            var virusPower = Math.Floor(power / 3.0);

            int timeInSecs = (int)virusPower * virusName.Length;
                if (viruses[virusName] > 1)
                {
                    timeInSecs = (int)Math.Floor(virusPower * virusName.Length / 3);
                }
                
            int[] timeInMinutes = new int [2] ;
            timeInMinutes[0] = (int)(Math.Floor((double)timeInSecs / 60));
            timeInMinutes[1] = timeInSecs % 60;

                if (health - timeInSecs > 0)
                {
                    health -= timeInSecs;
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
                Console.WriteLine($"Virus {virusName}: {virusPower} => {timeInSecs} seconds");                
                Console.WriteLine($"{virusName} defeated in {timeInMinutes[0]}m {timeInMinutes[1]}s.");
                Console.WriteLine($"Remaining health: {health:F0}");

                virusName = Console.ReadLine();
                if (virusName == "end")
                {
                    break;
                }
                if (!viruses.ContainsKey(virusName))
                {
                    viruses.Add(virusName, quantity);
                }
                else
                {
                    viruses[virusName]++;
                }
                power = 0;

                if (health * 1.2 > initialHealth)
                {
                    health = initialHealth ;
                }
                else
                {
                 health = Math.Floor(health *1.2);
                }

            }
            if (virusName == "end" && health > 0)
            {
                Console.WriteLine($"Final Health: {Math.Floor(health*1.2)}");
            }
        }
    }
}
