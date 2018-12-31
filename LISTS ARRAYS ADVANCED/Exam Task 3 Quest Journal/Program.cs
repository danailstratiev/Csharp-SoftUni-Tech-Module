using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Exam_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();


            while (true)
            {
             string[] commands = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
             string command = commands[0];

                if (command == "Retire!")
                {
                    break;
                }
                if (command == "Start")
                {
                    string quest = commands[1];

                    if (!journal.Contains(quest))
                    {
                        journal.Add(quest);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Complete")
                {
                   string quest = commands[1];

                    if (journal.Contains(quest))
                    {
                        int indexOfQuest = journal.IndexOf(quest);
                        journal.RemoveAt(indexOfQuest);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Side Quest")
                {
                    string[] sideQuest = commands[1].Split(":").ToArray();
                    string quest = sideQuest[0];
                    string miniQuest = sideQuest[1];

                    if (journal.Contains(quest))
                    {
                        if (!journal.Contains(miniQuest))
                        {
                            int indexOfQuest = journal.IndexOf(quest);

                            journal.Insert(indexOfQuest+1,miniQuest);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Renew")
                {
                    string quest = commands[1];


                    if (journal.Contains(quest))
                    {
                        int indexOfQuest = journal.IndexOf(quest);

                        journal.RemoveAt(indexOfQuest);
                        journal.Add(quest);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",journal));
        }
    }
}
