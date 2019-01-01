using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_1_Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charCounter = new Dictionary<char, int>();

            foreach (var letter in text)
            {
                if (letter != ' ')
                {
                    if (!charCounter.ContainsKey(letter))
                    {
                        charCounter.Add(letter, 1);
                    }
                    else
                    {
                        charCounter[letter]++;
                    }
                }
            }
            foreach (var kvp in charCounter)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
