using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_11_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(" ").ToArray();

            while (commands[0] != "end")
            {
                if (commands[0] == "exchange")
                {
                    int numberOfRotations = int.Parse(commands[1]);
                    if (numberOfRotations >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        List<int> helper = numbers.Skip(numberOfRotations+1).ToList();

                        for (int i = 0; i <= numberOfRotations ; i++)
                        {
                            helper.Add(numbers[i]);
                        }
                        numbers = helper;
                    }
                }
                else if (commands[0] == "max")
                {
                    string typeOfNumber = commands[1];
                    int indexOfNum = -1;
                    int maxNum = int.MinValue;

                    if (typeOfNumber == "odd")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                if (numbers[i] >= maxNum)
                                {
                                    maxNum = numbers[i];
                                    indexOfNum = i;
                                }
                            }
                        }
                        if (indexOfNum < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(indexOfNum);
                        }
                    }
                    else if (typeOfNumber == "even")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                if (numbers[i] >= maxNum)
                                {
                                    maxNum = numbers[i];
                                    indexOfNum = i;
                                }
                            }
                        }
                        if (indexOfNum < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(indexOfNum);
                        }
                    }
                }
                else if (commands[0] == "min")
                {
                    string typeOfNumber = commands[1];
                    int indexOfNum = -1;
                    int minNumber = int.MaxValue;

                    if (typeOfNumber == "odd")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                if (numbers[i] <= minNumber)
                                {
                                    minNumber = numbers[i];
                                    indexOfNum = i;
                                }
                            }
                        }
                        if (indexOfNum < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(indexOfNum);
                        }
                    }
                    else if (typeOfNumber == "even")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                if (numbers[i] <= minNumber)
                                {
                                    minNumber = numbers[i];
                                    indexOfNum = i;
                                }
                            }
                        }
                        if (indexOfNum < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(indexOfNum);
                        }
                    }
                }
                else if (commands[0] == "first")
                {
                    string typeOfNumber = commands[2];
                    int count = int.Parse(commands[1]);

                    if (count > numbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (typeOfNumber == "odd")
                    {
                        List<int> helper = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                helper.Add(numbers[i]);
                            }
                        }
                        if (helper.Count == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else if (count <= helper.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", helper.Take(count))}]");
                        }
                        else if (count > helper.Count && count < numbers.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", helper)}]");
                        }
                    }
                    else if (typeOfNumber == "even")
                    {
                        List<int> helper = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                helper.Add(numbers[i]);
                            }
                        }
                        if (helper.Count == 0)
                        {
                            Console.WriteLine("[]");

                        }
                        else if (count <= helper.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", helper.Take(count))}]");
                        }
                        else if (count > helper.Count && count < numbers.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", helper)}]");
                        }
                    }
                }
                else if (commands[0] == "last")
                {
                    string typeOfNumber = commands[2];
                    int count = int.Parse(commands[1]);

                    if (count > numbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (typeOfNumber == "odd")
                    {
                        List<int> helper = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                helper.Add(numbers[i]);
                            }
                        }
                        if (helper.Count == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else if (count <= helper.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", helper.Skip(helper.Count - count))}]");
                        }
                        else if (count > helper.Count && count < numbers.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", helper)}]");
                        }
                    }
                    else if (typeOfNumber == "even")
                    {
                        List<int> helper = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                helper.Add(numbers[i]);
                            }
                        }
                        if (helper.Count == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else if (count <= helper.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", helper.Skip(helper.Count - count))}]");
                        }
                        else if (count > helper.Count && count < numbers.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", helper)}]");
                        }
                    }
                }
                commands = Console.ReadLine().Split(" ").ToArray();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
