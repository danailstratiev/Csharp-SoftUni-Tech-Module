using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Exam_Preparation_Iron_Girder
{
    class Voyage
    {
        public int Time { get; set; }

        public int Passengers { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int time = 0;
            var destinations = new Dictionary<string, Voyage>();

            while (input != "Slide rule")
            {
                string[] inputAsArr = input.Split(":").ToArray();
                string name = inputAsArr[0];
                string[] timeAndPassengers = inputAsArr[1].Split("->").ToArray();
                int passengers = int.Parse(timeAndPassengers[1]);

                if (timeAndPassengers[0] == "ambush")
                {
                    if (!destinations.ContainsKey(name))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        destinations[name].Time = 0;
                        destinations[name].Passengers -= passengers;
                        if (destinations[name].Passengers < 0)
                        {
                            destinations[name].Passengers = 0;
                        }
                    }
                }
                else
                {
                    time = int.Parse(timeAndPassengers[0]);

                    if (!destinations.ContainsKey(name))
                    {
                        destinations[name] = new Voyage();
                        destinations[name].Time = time;
                        destinations[name].Passengers = passengers;
                    }
                    else
                    {
                        if (time < destinations[name].Time || destinations[name].Time == 0)
                        {
                            destinations[name].Time = time;
                        }

                        destinations[name].Passengers += passengers;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var destination in destinations.Where(x => x.Value.Time > 0 && x.Value.Passengers > 0).OrderBy(x => x.Value.Time).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{destination.Key} -> Time: {destination.Value.Time} -> Passengers: {destination.Value.Passengers}");
            }
        }
    }
}
