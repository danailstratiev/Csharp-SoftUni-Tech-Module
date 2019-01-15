using System;
using System.Text.RegularExpressions;
using System.Text;


namespace Regex_Exercise_1_Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = Console.ReadLine();
            string pattern = @"(^|(?<=\s))([a-z0-9]+)([_\.-]?[a-z0-9])*@([a-z0-9])+([-.][a-z0-9]+)*\.([a-z0-9]+)([-.][a-z-0-9]+)*";

            MatchCollection matches = Regex.Matches(someString, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
