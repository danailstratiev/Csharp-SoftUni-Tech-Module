using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;



namespace Strings_and_RegEx_MoreEx_6_Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Za-z{5,20}]+)@([a-z{3,20}]+)(.[combgorg]+)\b";

            int n = int.Parse(Console.ReadLine());

            var emails = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    string userName = match.Groups[1].Value;
                    string domain = match.Groups[2].Value;

                    if (userName.Length >= 5 && domain.Length >= 3)
                    {
                        domain = match.Groups[2].Value + match.Groups[3];

                        if (!emails.ContainsKey(domain))
                        {
                            emails[domain] = new List<string>();
                        }

                        if (!emails[domain].Contains(userName))
                        {
                            emails[domain].Add(userName);
                        }
                    }
                }
            }

            foreach (var email in emails.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{email.Key}:");

                foreach (var mail in email.Value)
                {
                    Console.WriteLine($"### {mail}");
                }
            }
        }
    }
}
