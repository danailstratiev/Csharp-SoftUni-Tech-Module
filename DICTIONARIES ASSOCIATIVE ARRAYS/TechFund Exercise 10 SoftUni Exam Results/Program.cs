using System;
using System.Linq;
using System.Collections.Generic;

namespace TechFund_Exercise_10_SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var participants = new Dictionary<string, int>();
            var languages = new Dictionary<string, int>();
            int points = 0;

            while (input != "exam finished")
            {
                string[] data = input.Split("-").ToArray();
                string name = data[0];
                string language = data[1];

                if (data.Length == 3)
                {
                    points = int.Parse(data[2]);
                }

                if (!participants.ContainsKey(name) && language != "banned")
                {
                    participants.Add(name, points);
                }
                else
                {
                    if (language == "banned")
                    {
                        participants.Remove(name);
                    }
                    else
                    {
                        if (participants[name] < points)
                        {
                            participants[name] = points;
                        }
                    }
                }

                if (!languages.ContainsKey(language) && language != "banned")
                {
                    languages.Add(language, 1);
                }
                else
                {
                    if (language != "banned")
                    {
                        languages[language]++;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var participant in participants.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{participant.Key} | {participant.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var submission in languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
