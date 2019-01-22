using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Strings_and_RegEx_MoreEx_8_Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"<\w*\W*>";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string bomb = match.Value;
                int bombPower = Math.Abs(bomb[1] - bomb[2]);

                List<char> inputAsChars = input.ToList();
                char bombStart = bomb[0];
                char bombEnd = bomb[bomb.Length - 1];
                int bombStartIndex = inputAsChars.IndexOf(bombStart);
                int bombEndIndex = inputAsChars.IndexOf(bombEnd);

                if (bombStartIndex - bombPower < 0 && bombEndIndex + bombPower >= inputAsChars.Count)
                {
                    for (int i = 0; i < inputAsChars.Count; i++)
                    {
                        inputAsChars[i] = '_';
                    }
                }
                else if (bombStartIndex - bombPower < 0)
                {
                    for (int i = 0; i <= bombEndIndex + bombPower; i++)
                    {
                        inputAsChars[i] = '_';
                    }
                }
                else if (bombEndIndex + bombPower >= inputAsChars.Count)
                {
                    for (int i = bombStartIndex - bombPower; i < inputAsChars.Count; i++)
                    {
                        inputAsChars[i] = '_';
                    }
                }
                else
                {
                    for (int i = bombStartIndex - bombPower; i <= bombEndIndex + bombPower; i++)
                    {
                        inputAsChars[i] = '_';
                    }
                }

                input = String.Join("", inputAsChars);
            }

            Console.WriteLine(input);
        }
    }
}
