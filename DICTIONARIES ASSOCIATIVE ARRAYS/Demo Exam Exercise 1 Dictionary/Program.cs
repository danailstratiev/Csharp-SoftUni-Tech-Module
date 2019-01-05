using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Demo_Exam_Exercise_1_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] descriptions = input[i].Split(": ").ToArray();
                string word = descriptions[0];

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }

                for (int j = 1; j < descriptions.Length; j++)
                {
                    words[word].Add(descriptions[j]);
                }
            }

            string[] wordCheck = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < wordCheck.Length; i++)
            {
                var word = wordCheck[i];

                if (words.ContainsKey(word))
                {
                    var vocabulary = words[word];

                    Console.WriteLine($"{word}");
                    foreach (var description in vocabulary.OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($" -{description}");
                    }
                }
            }

            string final = Console.ReadLine();

            if (final == "End")
            {
                return;
            }
            else
            {
                foreach (var kvp in words.OrderBy(x => x.Key))
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }
    }
}
