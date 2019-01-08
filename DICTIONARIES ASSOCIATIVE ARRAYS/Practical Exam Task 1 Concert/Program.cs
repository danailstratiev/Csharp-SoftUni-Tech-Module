using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace Exam_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var bandNameAndMembers = new Dictionary<string, List<string>>();
            var bandPlayTime = new Dictionary<string, int>();

            while (input != "start of concert")
            {
                var typeOfAction = input.Split("; ").ToArray();

                if (typeOfAction[0] == "Play")
                {
                    string bandName = typeOfAction[1];
                    int bandConcertTime = int.Parse(typeOfAction[2]);

                    if (!bandPlayTime.ContainsKey(bandName))
                    {
                        bandPlayTime[bandName] = bandConcertTime;
                    }
                    else
                    {
                        bandPlayTime[bandName] += bandConcertTime;
                    }
                }
                else if (typeOfAction[0] == "Add")
                {
                    string bandName = typeOfAction[1];
                    List<string> bandMembers = typeOfAction[2].Split(", ").ToList();

                    if (!bandNameAndMembers.ContainsKey(bandName))
                    {
                        bandNameAndMembers[bandName] = bandMembers;
                    }
                    else
                    {
                        var rockOfAges = bandNameAndMembers[bandName];

                        foreach (var performer in bandMembers)
                        {
                            if (!rockOfAges.Contains(performer))
                            {
                                rockOfAges.Add(performer);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            string timeForRockAndRoll = Console.ReadLine();
            var totalPlayTime = bandPlayTime.Values.Sum();

            Console.WriteLine($"Total time: {totalPlayTime}");
            foreach (var concertTime in bandPlayTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{concertTime.Key} -> {concertTime.Value}");
            }

            Console.WriteLine(timeForRockAndRoll);
            foreach (var player in bandNameAndMembers.Where(x => x.Key == timeForRockAndRoll))
            {
                var members = player.Value;
                foreach (var member in members)
                {
                  Console.WriteLine($"=> {member}");
                }
            }
        }
    }
}
