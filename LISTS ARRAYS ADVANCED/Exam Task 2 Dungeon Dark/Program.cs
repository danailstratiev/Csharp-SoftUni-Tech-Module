using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Exam_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialCoins = 0;
            int bestRoom = 0;

            string[] input = Console.ReadLine().Split('|').ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string[] assignment = input[i].Split(" ").ToArray();
                string command = assignment[0];
                int quantity = int.Parse(assignment[1]);
                bestRoom++;

                if (command == "potion")
                {
                    if (initialHealth + quantity >= 100)
                    {
                        Console.WriteLine($"You healed for {100 - initialHealth} hp.");
                        initialHealth = 100;
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {quantity} hp.");
                        initialHealth += quantity;
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {quantity} coins.");
                    initialCoins += quantity;
                }
                else
                {
                    initialHealth -= quantity;

                    if (initialHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                }                
            }
            if (initialHealth > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Coins: {initialCoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }
            
        }
    }
}
