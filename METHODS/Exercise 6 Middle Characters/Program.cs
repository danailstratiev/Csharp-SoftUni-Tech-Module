using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_6_Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();


            if (word.Length % 2 == 0)
            {
                Console.WriteLine($"{word[word.Length/2 -1]}{word[word.Length/2]}");
            }
            else
            {
                Console.WriteLine($"{word[word.Length/2]}");
            }

        }
    }
}
