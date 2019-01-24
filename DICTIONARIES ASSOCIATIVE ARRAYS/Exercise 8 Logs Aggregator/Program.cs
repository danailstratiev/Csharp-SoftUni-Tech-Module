using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_8_Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userLogs = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            string name = "";
            string ip = "";
            int time = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                name = input[1];
                ip = input[0];
                time = int.Parse(input[2]);

                if (!userLogs.ContainsKey(name))
                {
                    Dictionary<string, int> currentLog = new Dictionary<string, int>();
                    currentLog.Add(ip, time);
                    userLogs.Add(name, currentLog);
                }
                else
                {
                    if (!userLogs[name].ContainsKey(ip))
                    {
                        userLogs[name].Add(ip, time);
                    }
                    else
                    {
                        userLogs[name][ip] += time;
                    }
                }
            }

            foreach (var kvp in userLogs.OrderBy(x => x.Key))
            {
                Console.Write($"{kvp.Key}: {kvp.Value.Values.Sum()} [");
                List<string> helper = new List<string>();

                foreach (var pair in kvp.Value.OrderBy(y => y.Key))
                {
                    helper.Add($"{pair.Key}");
                }
                Console.Write(string.Join(", ",helper) + "]");
                Console.WriteLine();
            }
        }
    }
}
