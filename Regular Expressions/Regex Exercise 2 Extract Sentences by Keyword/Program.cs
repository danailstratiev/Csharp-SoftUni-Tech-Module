using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace Regex_Exercise_2_Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string someText = Console.ReadLine();
            string pattern = $@"\b{word}\b";
            string[] sentences = someText.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> filteredList = new List<string>();

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence,pattern))
                {
                    Console.WriteLine(sentence.Trim());
                    // .Trim маха празните разстояния отпред и отзад
                }
            }
        }
    }
}
