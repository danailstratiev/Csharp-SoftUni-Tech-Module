using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_9._1_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valanyrObtained = false;
            bool dragonwrathObtained = false;
            bool shadowmourneObtained = false;
            SortedDictionary<string, int> resources = new SortedDictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            int quantity = 0;
            string currentResource = "";
            resources.Add("shards", quantity);
            resources.Add("fragments", quantity);
            resources.Add("motes", quantity);

            while (valanyrObtained == false && dragonwrathObtained == false && shadowmourneObtained == false)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    quantity = int.Parse(input[i]);
                    currentResource = input[i + 1].ToLower();

                    if (currentResource == "shards")
                    {
                        resources["shards"] += quantity;
                    }
                    else if (currentResource == "fragments")
                    {
                        resources["fragments"] += quantity;
                    }
                    else if (currentResource == "motes")
                    {
                        resources["motes"] += quantity;
                    }
                    else
                    {
                        if (!junk.ContainsKey(currentResource))
                        {
                            junk.Add(currentResource, quantity);
                        }
                        else
                        {
                            junk[currentResource] += quantity;
                        }
                    }
                    if (resources["shards"] >= 250)
                    {
                        shadowmourneObtained = true;
                        Console.WriteLine("Shadowmourne obtained");
                        resources["shards"] -= 250;
                        break;
                    }
                    else if (resources["fragments"] >= 250)
                    {
                        valanyrObtained = true;
                        Console.WriteLine("Valanyr obtained!");
                        resources["fragments"] -= 250;
                        break;
                    }
                    else if (resources["motes"] >= 250)
                    {
                        dragonwrathObtained = true;
                        Console.WriteLine("Dragonwrath obtained!");
                        resources["motes"] -= 250;
                        break;
                    }
                }
            }
            foreach (var kvp in resources.OrderByDescending(x => x.Value))
            {

                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
     }
}
