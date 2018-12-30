using System;
using System.Linq;
using System.Collections.Generic;


namespace Lists_Exercise_5_Array_manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List <string> commands = Console.ReadLine().Split(" ").ToList();

            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    int element = int.Parse(commands[2]);
                    int position = int.Parse(commands[1]);
                    numbers.Insert(position, element);
                }
                else if (commands[0] == "contains")
                {
                    int requested = int.Parse(commands[1]);
                    if (numbers.Contains(requested))
                    {
                        Console.WriteLine(numbers.IndexOf(requested));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (commands[0] == "remove")
                {
                    int numberToRemove = int.Parse(commands[1]);

                    numbers.RemoveAt(numberToRemove);
                }
                else if (commands[0] == "addMany")
                {
                    int startIndex = int.Parse(commands[1]);

                    numbers.InsertRange(startIndex, commands.Skip(2).Select(int.Parse));

                }
                else if (commands[0] == "sumPairs")
                {
                    int oldCount = numbers.Count/2;

                    for (int i = 0; i < oldCount; i++)
                    {
                        numbers[i] += numbers[i + 1];

                        numbers.RemoveAt(i + 1);
                    }
                   
                }
                else if (commands[0] == "shift")
                {
                    int position = int.Parse(commands[1]) % numbers.Count;
                    var helper = numbers.Skip(position).ToList();

                    for (int i = 0; i < position; i++)
                    {
                        helper.Add(numbers[i]);
                    }
                    numbers = helper;
                }
                commands = Console.ReadLine().Split(" ").ToList();
            }
            Console.WriteLine($"[{string.Join(", ",numbers)}]");
        }
    }
}
