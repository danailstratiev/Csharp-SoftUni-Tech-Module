using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_3_Legendary__Farming
{
    class Program
    {
        static void Main(string[] args)
        {           
            Dictionary<string, int> mainResources = new Dictionary<string, int>();
            mainResources.Add("motes", 0);
            mainResources.Add("fragments", 0);
            mainResources.Add("shards", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (true)
            {
                List<string> resources = Console.ReadLine().Split(" ").ToList();
                bool hasToBreak = false;

                for (int i = 0; i < resources.Count; i+= 2)
                {
                    int quantity = int.Parse(resources[i]);
                    string resource = resources[i + 1].ToLower();

                    if (resource == "motes" || resource == "fragments" || resource == "shards")
                    {                   
                        mainResources[resource] += quantity;

                        if (mainResources[resource] >= 250)
                        {
                            mainResources[resource] -= 250;
                            if (resource == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if (resource == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (resource == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            hasToBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(resource))
                        {
                            junk.Add(resource, quantity);
                        }
                        else
                        {
                            junk[resource] += quantity;
                        }
                    }                                      
                }
                if (hasToBreak)
                {
                    break;
                }
            }
            foreach (var kvp in mainResources.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
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
