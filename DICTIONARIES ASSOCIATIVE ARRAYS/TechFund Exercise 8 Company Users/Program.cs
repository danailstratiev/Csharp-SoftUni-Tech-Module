using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_8_Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ").ToArray();
            Dictionary<string, List <string>> dataBase = new Dictionary<string, List<string>> ();

            while (input[0] != "End")
            {
                string company = input[0];
                string employeeID = input[1];

                if (!dataBase.ContainsKey(company))
                {
                    List<string> workers = new List<string>();
                    workers.Add(employeeID);
                    dataBase.Add(company, workers);
                }
                else
                {
                    if (!dataBase[company].Contains(employeeID))
                    {
                        dataBase[company].Add(employeeID);
                    }
                }
                input = Console.ReadLine().Split(" -> ").ToArray();
            }
            foreach (var kvp in dataBase.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var worker in kvp.Value)
                {
                    Console.WriteLine($"-- {worker}");
                }
            }
        }
    }
}
