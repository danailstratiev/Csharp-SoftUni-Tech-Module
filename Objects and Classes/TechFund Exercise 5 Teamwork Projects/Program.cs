using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_9_Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string name = "";
            string teamName = "";
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] data = input.Split("-").ToArray();
                name = data[0];
                teamName = data[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    // .Any проверява за наличието на поне един търсен елемент в дадена колекция
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    if (teams.Any(x => x.Creator == name))
                    {
                        Console.WriteLine($"{name} cannot create another team!");
                    }
                    else
                    {
                        Team team = new Team();
                        team.Creator = name;
                        team.Name = teamName;
                        List<string> members = new List<string>();
                        team.Members = members;
                        teams.Add(team);
                        Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                    }
                }
             input = Console.ReadLine();
            }
            string nameJoiner = "";
            string teamToJoin = "";

            while (input != "end of assignment")
            {
                string[] joiners = input.Split(new char[] {'-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                nameJoiner = joiners[0];
                teamToJoin = joiners[1];

                if (!teams.Any(x => x.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if(teams.Any(x => x.Members.Contains(nameJoiner) || teams.Any(y => y.Creator.Contains(nameJoiner))))
                {
                    Console.WriteLine($"Member {nameJoiner} cannot join team {teamToJoin}!");
                }
                else
                {
                    foreach (var squad in teams.Where(x => x.Name == teamToJoin))
                    {
                        squad.Members.Add(nameJoiner);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var squad in teams.Where(x => x.Members.Count != 0).
                OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{squad.Name}");
                Console.WriteLine($"- {squad.Creator}");

                foreach (var member in squad.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var squad in teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{squad.Name}");
            }
        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
