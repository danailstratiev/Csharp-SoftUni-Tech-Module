using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Strings_and_RegEx_MoreEx_7_Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int index = -1;
            int traceLength = -1;


            while (true)
            {
                string[] traces = Console.ReadLine().Split(" ").ToArray();
                string first = traces[0];
                string pattern = @"[\" + first + "]*";
                int number = int.Parse(traces[1]);

                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    if (match.Length >= number)
                    {
                        index = input.IndexOf(match.Value);
                        traceLength = match.Length;

                        Console.WriteLine($"Hideout found at index {index} and it is with size {traceLength}!");
                        return;
                    }
                }
            }
        }
    }
}
