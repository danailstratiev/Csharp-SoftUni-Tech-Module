using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Demo_Exam_Exercise_2_Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] decode = Console.ReadLine().Split(" ").ToArray();
            string decoded = Decoded(input);
            decoded = decoded.Replace(decode[0], decode[1]);
            string pattern = @"^[d-z\{\}\#\|]+$";

            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine(decoded);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }

        public static string Decoded(string input)
        {
            var sb = new StringBuilder();

            foreach (var symbol in input)
            {
                char changed = Convert.ToChar(symbol - 3);

                sb.Append(changed);
            }

            return sb.ToString();
        }
    }
}
