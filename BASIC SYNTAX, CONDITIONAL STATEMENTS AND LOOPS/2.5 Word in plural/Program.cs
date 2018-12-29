using System;

namespace _2._5_Word_in_plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith('y'))
            {
                word = word.Remove(word.Length-1);
                word = word + "ies";
            }
            else if (word.EndsWith('z') || word.EndsWith('s') || word.EndsWith('o') || word.EndsWith('x') ||
                word.EndsWith("ch") || word.EndsWith("sh"))
            {
                word = word + "es";
            }
            else
            {
                word = word + "s";
            }
            Console.WriteLine($"{word}");
        }
    }
}
