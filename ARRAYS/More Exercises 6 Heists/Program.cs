using System;
using System.Linq;
using System.Collections.Generic;


namespace More_Exercises_6_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] prices = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            string[] treasures = Console.ReadLine().Split(" ").ToArray();
            long priceOfGold = prices[1];
            long priceOfJewels = prices[0];
            long totalEarnings = 0;
            long goldEncountered = 0;
            long jewelsEncountered = 0;
            long totalExpenses = 0;

            while (treasures[0] != "Jail")
            {
            long expenses = long.Parse(treasures[1]);
                totalExpenses += expenses;

                foreach (char symbol in treasures[0])
                {
                    if (symbol == '$')
                    {
                        goldEncountered++;
                    }
                    else if (symbol == '%')
                    {
                        jewelsEncountered++;
                    }
                }
                treasures = Console.ReadLine().Split(" ").ToArray();
            }
            totalEarnings = (goldEncountered * priceOfGold) + (jewelsEncountered * priceOfJewels);

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings-totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses-totalEarnings}.");
            }
        }
    }
}
