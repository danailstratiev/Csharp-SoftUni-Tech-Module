using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exam_Preparation_Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string firstPattern = @"([^A-Za-z-]+)";
            string secondPattern = @"([A-Za-z]+-[A-Za-z]+)";

            while (Regex.IsMatch(input,firstPattern) || Regex.IsMatch(input,secondPattern))
            {
                if (Regex.IsMatch(input, firstPattern))
                {
                    Match firstMatch = Regex.Match(input,firstPattern);
                    string first = firstMatch.Groups[1].Value;

                    Console.WriteLine($"{first}");

                    var index = input.IndexOf(first);
                    input = input.Remove(0,first.Length+index);
                }

                if (Regex.IsMatch(input, secondPattern))
                {
                    Match secondMatch = Regex.Match(input, secondPattern);
                    string second = secondMatch.Groups[1].Value;

                    Console.WriteLine($"{second}");

                    var index = input.IndexOf(second);
                    input = input.Remove(0, second.Length+index);
                }
            }
        }
    }
}
