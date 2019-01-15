using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Exam_Preparation_Roli___The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<int, Dictionary<string, List<string>>> eventOrganizer = new Dictionary<int, Dictionary<string, List<string>>>();

            while (input != "Time for Code")
            {
              List<string> someInput = input.Split(" ").ToList();
                var id = int.Parse(someInput[0]);
                var eventName = someInput[1];
                var guests = someInput.Skip(2).ToList();

                if (!eventName.Contains('#'))
                {
                    input = Console.ReadLine();
                    continue;
                }
               string eventType = eventName.Substring(1,eventName.Length-1);

                if (!eventOrganizer.ContainsKey(id))
                {
                    Dictionary<string, List<string>> partyOrganizer = new Dictionary<string, List<string>>();
                    partyOrganizer.Add(eventType, guests);
                    eventOrganizer.Add(id, partyOrganizer);
                }
                else
                {
                    if (!eventOrganizer[id].ContainsKey(eventType))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        foreach (var guest in guests)
                        {
                            if (!eventOrganizer[id][eventType].Contains(guest))
                            {
                                eventOrganizer[id][eventType].Add(guest);
                            }
                        }
                        eventOrganizer[id][eventType].Sort();
                    }
                }
                input = Console.ReadLine();
            }
            Dictionary<string, List<string>> organizer = new Dictionary<string, List<string>>();
            foreach (var kvp in eventOrganizer)
            {
                foreach (var pair in kvp.Value)
                {
                    var name = pair.Key;
                    var sequence = pair.Value;
                    if (!organizer.ContainsKey(name))
                    {
                        organizer.Add(name, sequence);
                    }
                }
            }
            foreach (var kvp in organizer.OrderByDescending(x => x.Value.Count))
            {
                var party = kvp.Key;
                var people = kvp.Value;

                Console.WriteLine($"{party} - {people.Count}");

                foreach (var guest in people.OrderBy(x => x))
                {
                    Console.WriteLine($"{guest}");
                }
            }
        }       
    }
}
