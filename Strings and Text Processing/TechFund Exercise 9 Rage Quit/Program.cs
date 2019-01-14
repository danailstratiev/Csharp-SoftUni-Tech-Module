using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Exercise_9_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            
            string pattern = @"(\D+)(\d{1,2})";
            MatchCollection matches = Regex.Matches(someText, pattern);

            foreach (Match match in matches)
            {
                int n = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < n; i++)
                {
                    sb.Append(match.Groups[1].Value.ToUpper());
                }
            }
            List<char> elements = sb.ToString().ToList();
            var distinct = elements.Distinct();            

            Console.WriteLine($"Unique symbols used: {distinct.Count()}");
            Console.WriteLine(sb);
        }
    }
}
