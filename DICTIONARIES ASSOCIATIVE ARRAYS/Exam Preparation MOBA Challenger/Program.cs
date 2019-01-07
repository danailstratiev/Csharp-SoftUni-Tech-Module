using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Exam_Preparation_MOBA_Challenger
{
    class Challenge
    {
        public string Position { get; set; }

        public int Score { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var champions = new Dictionary<string, List<Challenge>>();

            while (input != "Season end")
            {
                if (input.Contains("vs"))
                {
                    var battle = input.Split(" vs ").ToArray();
                    var firstContestant = battle[0];
                    var secondContestant = battle[1];
                    int removal = 0;

                    if (champions.ContainsKey(firstContestant) && champions.ContainsKey(secondContestant))
                    {
                        foreach (var firstStats in champions.Where(x => x.Key == firstContestant))
                        {
                            var firstPositions = firstStats.Value;

                            foreach (var secondStats in champions.Where(x => x.Key == secondContestant))
                            {
                                var secondPositions = secondStats.Value;

                                for (int i = 0; i < Math.Min(firstPositions.Count, secondPositions.Count); i++)
                                {
                                    if (firstPositions.Count > secondPositions.Count)
                                    {
                                        for (int j = 0; j < firstPositions.Count; j++)
                                        {
                                            if (firstPositions[j].Position == secondPositions[i].Position)
                                            {
                                                if (firstPositions[j].Score > secondPositions[i].Score)
                                                {
                                                    removal = 2;
                                                }
                                                else if (firstPositions[i].Score < secondPositions[i].Score)
                                                {
                                                    removal = 1;
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        for (int j = 0; j < secondPositions.Count; j++)
                                        {
                                            if (firstPositions[i].Position == secondPositions[j].Position)
                                            {
                                                if (firstPositions[i].Score > secondPositions[j].Score)
                                                {
                                                    removal = 2;
                                                    break;
                                                }
                                                else if (firstPositions[i].Score < secondPositions[j].Score)
                                                {
                                                    removal = 1;
                                                    break;
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (removal != 0)
                        {
                            if (removal == 1)
                            {
                                champions.Remove(firstContestant);
                            }
                            else if (removal == 2)
                            {
                                champions.Remove(secondContestant);
                            }
                        }
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    var currentChallenge = input.Split(" -> ").ToArray();
                    var name = currentChallenge[0];
                    var position = currentChallenge[1];
                    var score = int.Parse(currentChallenge[2]);

                    if (!champions.ContainsKey(name))
                    {
                        champions[name] = new List<Challenge>();
                    }

                    var currentContest = champions[name];

                    var currentTask = currentContest.FirstOrDefault(x => x.Position == position);

                    if (currentTask != null)
                    {
                        if (currentTask.Score < score)
                        {
                            currentTask.Score = score;
                        }
                    }
                    else
                    {
                        currentTask = new Challenge
                        {
                            Position = position,
                            Score = score
                        };

                        currentContest.Add(currentTask);
                    }
                }

                input = Console.ReadLine();
            }

            var result = new Dictionary<string, int>();

            foreach (var champion in champions)
            {
                var scores = champion.Value;
                var totalSum = 0;

                for (int i = 0; i < scores.Count; i++)
                {
                    totalSum += scores[i].Score;
                }

                result.Add(champion.Key, totalSum);
            }

            foreach (var player in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");

                foreach (var champion in champions.Where(x => x.Key == player.Key))
                {
                    var challenges = champion.Value.OrderByDescending(x => x.Score).ThenBy(x => x.Position);

                    foreach (var position in challenges)
                    {
                        Console.WriteLine($" - {position.Position} <::> {position.Score}");
                    }
                }
            }
        }
    }
}
