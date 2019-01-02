using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_5_SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> carLable = new Dictionary<string, string>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                
                if (input[0] == "register")
                {
                    string name = input[1];
                    string label = input[2];

                    if (!carLable.ContainsKey(name))
                    {
                        carLable.Add(name, label);

                        Console.WriteLine($"{name} registered {label} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carLable[name]}");
                    }

                }
                else if (input[0] == "unregister")
                {
                    string name = input[1];

                    if (carLable.ContainsKey(name))
                    {
                        carLable.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var kvp in carLable)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
