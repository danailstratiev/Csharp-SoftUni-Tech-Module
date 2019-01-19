using System;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_Lab_1_Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matches = Regex.Matches(someString, pattern);

            foreach (var match in matches)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();
        }
    }
}
