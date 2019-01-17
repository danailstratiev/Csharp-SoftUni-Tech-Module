using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_Exercise_6_Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Za-z][\w]{2,24})\b";
            string[] userNames = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> result = new List<string>();

            foreach (var name in userNames)
            {
                if (Regex.IsMatch(name,pattern))
                {
                    result.Add(name);
                }
            }
            int counter = 0;
            int counterMax = 0;
            int position = 0;

            for (int i = 0; i < result.Count-1; i++)
            {
                counter = result[i].Length + result[i + 1].Length;

                if (counter > counterMax)
                {
                    counterMax = counter;
                    position = i;
                }
            }

            Console.WriteLine(result[position]);
            Console.WriteLine(result[position+1]);
        }
    }
}
