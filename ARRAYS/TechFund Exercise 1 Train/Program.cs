using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_1_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ").ToArray();

            while (commands[0] != "end")
            {
                if (commands[0] == "Add")
                {
                    int addMore = int.Parse(commands[1]);
                    passengers.Add(addMore);
                }
                else 
                {
                    try
                    {
                        int morePassamgers = int.Parse(commands[0]);

                        for (int i = 0; i < passengers.Count; i++)
                        {
                            if (capacity - passengers[i]  >= morePassamgers)
                            {
                                passengers[i] += morePassamgers;
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                commands = Console.ReadLine().Split(" ").ToArray();
            }
            Console.WriteLine(string.Join(" ", passengers));

        }
    }
}
