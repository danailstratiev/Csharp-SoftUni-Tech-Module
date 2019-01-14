using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace TechFund_Exercise_8_Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myCollection = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"\b(\w)(\d+)(\w)\b";
            double sum = 0.00;
            double totalSum = 0.00;

            foreach (var combination in myCollection)
            {
                Match currentMatch = Regex.Match(combination, pattern);
                char firstLetter = char.Parse(currentMatch.Groups[1].Value);
                long number = long.Parse(currentMatch.Groups[2].Value);
                char secondLetter = char.Parse(currentMatch.Groups[3].Value);
                int indexOfLetter = 0;

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    indexOfLetter = BigAlphabet(firstLetter);
                    sum = number*1.00 / indexOfLetter*1.00;
                }
                else
                {
                    indexOfLetter = SmallAlphabet(firstLetter);
                    sum = number*1.00 * indexOfLetter*1.00;
                }

                if (secondLetter >= 65 && secondLetter <= 90)
                {
                    indexOfLetter = BigAlphabet(secondLetter);
                    sum -= indexOfLetter;
                }
                else
                {
                    indexOfLetter = SmallAlphabet(secondLetter);
                    sum += indexOfLetter;
                }
                totalSum += sum;
                sum = 0;
            }
            Console.WriteLine($"{totalSum:F2}");
        }

        private static int BigAlphabet(char symbol)
        {
            List<char> letters = new List<char>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                letters.Add(i);
            }
            int index = letters.IndexOf(symbol)+1;

            return index;
        }
        private static int SmallAlphabet(char symbol)
        {
            List<char> letters = new List<char>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                letters.Add(i);
            }
            int index = letters.IndexOf(symbol)+1;

            return index;
        }
    }
}
