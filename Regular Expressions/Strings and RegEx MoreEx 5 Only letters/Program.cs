using System;
using System.Text;
using System.Text.RegularExpressions;


namespace Strings_and_RegEx_MoreEx_5_Only_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^A-Za-z]+";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string expendable = match.Value;
                int index = input.IndexOf(expendable);
                if (index + expendable.Length < input.Length)
                {
                    char symbol = input[index + expendable.Length];
                    string replaced = symbol.ToString();
                    input = input.Replace(expendable, replaced);
                }
            }

            Console.WriteLine(input);
        }
    }
}
