using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Exercise_10_Сръбско_Unleashed
{
    class Singer
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public long Income { get; set; }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+ ?[A-Za-z]* ?[A-Za-z]*) @([A-Za-z]+ ?[A-Za-z]* ?[A-Za-z]*) ([\d]+) ([\d]+)";
            string input = Console.ReadLine();
           
            Dictionary<string, List<Singer>> organizer = new Dictionary<string, List<Singer>>();

            while (input != "End")
            {
                if (!Regex.IsMatch(input,pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }

                Match match = Regex.Match(input, pattern);
                string name = match.Groups[1].Value;
                string location = match.Groups[2].Value;
                long price = long.Parse(match.Groups[3].Value);
                long visitors = long.Parse(match.Groups[4].Value);

                if (!organizer.ContainsKey(location))
                {
                    organizer[location] = new List<Singer>();
                }

                var singers = organizer[location];

                var foundSinger = singers.FirstOrDefault(x => x.Name == name);

                if (foundSinger == null)
                {
                    var singer = new Singer
                    {
                        Name = name,
                        Location = location,
                        Income = price * visitors
                    };
                    singers.Add(singer);
                }
                else
                {
                    foundSinger.Income += price * visitors;
                }

                input = Console.ReadLine();
            }

            foreach (var concert in organizer)
            {
                var place = concert.Key;
                var singers = concert.Value.OrderByDescending(x => x.Income);

                Console.WriteLine(place);
                foreach (var singer in singers)
                {
                    Console.WriteLine($"#  {singer.Name} -> {singer.Income}");
                }
            }
        }
    }
}

