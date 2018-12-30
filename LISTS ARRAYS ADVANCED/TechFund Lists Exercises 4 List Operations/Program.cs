using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Lists_Exercises_4_List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(" ").ToList();

            while (commands[0] != "End")
            {
                string command = commands[0];
                if (command == "Shift")
                {
                    string direction = commands[1];
                    int position = int.Parse(commands[2]) % numbers.Count;

                    if (direction == "left")
                    {
                        var helper = numbers.Skip(position).ToList();

                        for (int i = 0; i < position; i++)
                        {
                            helper.Add(numbers[i]);
                        }
                        numbers = helper;
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < position; i++)
                        {
                          numbers = Rotated(numbers).ToList();
                        }
                    }
                }
                else if (command == "Remove")
                {
                    int position = int.Parse(commands[1]);

                    if (position >= numbers.Count || position < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                    numbers.RemoveAt(position);
                    }
                }
                else if (command == "Add")
                {
                    int position = int.Parse(commands[1]);
                    numbers.Add(position);
                }
                else if(command == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                    numbers.Insert(index, element);                            
                    }
                }
                commands = Console.ReadLine().Split(" ").ToList();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
            static int[] Rotated (List<int> numbers)
        {
            int[] rotated = numbers.ToArray();
            var helper = new List<int>();
            for (int i = 1; i < rotated.Length; i++)
            {
                rotated[i] = numbers[i-1];
            }

            rotated[0] = numbers[numbers.Count - 1];
            return rotated;
        }
    }
}
