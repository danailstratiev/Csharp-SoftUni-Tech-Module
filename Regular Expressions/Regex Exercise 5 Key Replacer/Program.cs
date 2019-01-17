using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Regex_Exercise_5_Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Za-z]+)([<\|\\])(.*)([<\|\\])([A-Za-z]+)";
            Match myMatch = Regex.Match(input, pattern);
            string start = myMatch.Groups[1].Value;
            string end = myMatch.Groups[5].Value;
            string sentence = Console.ReadLine();
            string newPattern = $@"{start}(.*?){end}";
            StringBuilder sb = new StringBuilder();
            MatchCollection matches = Regex.Matches(sentence, newPattern);

            foreach (Match match in matches)
            {
                sb.Append(match.Groups[1]);
            }
            if (sb.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
            Console.WriteLine(sb.ToString());
            }
        }
    }
}
