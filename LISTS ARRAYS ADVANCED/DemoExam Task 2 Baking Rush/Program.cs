using System;
using System.Linq;
using System.Collections.Generic;


namespace DemoExam_Task_2_Baking_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int health = 100;
            int coins = 100;
            bool isBankruped = false;

            string[] input = Console.ReadLine().Split('|').ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string[] miniInput = input[i].Split("-").ToArray();
                string command = miniInput[0];
                int quantity = int.Parse(miniInput[1]);

                if (health <= 0)
                {
                    break;
                }               

                if (command == "rest")
                {
                    if (health + quantity < initialHealth)
                    {
                     Console.WriteLine($"You gained {quantity} energy.");
                        health += quantity;
                    }
                    else
                    {
                        Console.WriteLine($"You gained {initialHealth - health} energy.");
                        health = initialHealth;
                    }
                    Console.WriteLine($"Current energy: {health}.");
                }
                else if (command == "order")
                {
                    health -= 30;

                    if (health > 0)
                    {
                        coins += quantity;
                        Console.WriteLine($"You earned {quantity} coins.");
                    }
                    else
                    {
                        health += 30;
                        health += 50;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    coins -= quantity;

                    if (coins > 0)
                    {
                        Console.WriteLine($"You bought {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed!Cannot afford {command}.");
                        break;
                    }
                }
            }
            if (health > 0 && coins > 0)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {health}");
            }
        }
    }
}
