using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace TechFund_Exercise_9_Force_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Za-z]+[ A-Za-z]*)(->|\|)( [A-Za-z]+[ A-Za-z]*)";
            var forceSides = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {
                Match match = Regex.Match(input, pattern);

                string left = match.Groups[1].Value;
                left = left.Remove(left.Length - 1, 1);
                string middle = match.Groups[2].Value;
                string right = match.Groups[3].Value;
                right = right.Remove(0, 1);

                if (middle == "|")
                {
                    if (!forceSides.ContainsKey(left))
                    {
                        forceSides[left] = new List<string>();
                        forceSides[left].Add(right);
                    }
                    else
                    {
                        if (!forceSides[left].Contains(right))
                        {
                            forceSides[left].Add(right);
                        }
                    }
                }
                else if (middle == "->")
                {
                    if (!forceSides.ContainsKey(right))
                    {
                        forceSides[right] = new List<string>();
                        forceSides[right].Add(left);
                    }
                    else
                    {
                        foreach (var kvp in forceSides)
                        {
                            var forceUsers = kvp.Value;

                            if (forceUsers.Contains(left))
                            {
                                int index = forceUsers.IndexOf(left);

                                forceUsers.RemoveAt(index);
                            }
                        }

                        forceSides[right].Add(left);
                    }

                    Console.WriteLine($"{left} joins the {right} side!");
                }

                input = Console.ReadLine();
            }

            foreach (var side in forceSides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                var force = side.Key;
                var users = side.Value;

                if (users.Count > 0)
                {
                    Console.WriteLine($"Side: {force}, Members: {users.Count}");

                    foreach (var forceUser in users.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {forceUser}");
                    }
                }
            }
        }
    }
}
