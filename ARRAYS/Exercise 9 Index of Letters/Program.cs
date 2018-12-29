using System;

namespace Exercise_9_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] alphabet = new char [26];
            int indecCounter = 0;

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                alphabet[indecCounter] = letter;
                indecCounter++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (currentLetter == alphabet[j])
                    {
                        Console.WriteLine($"{currentLetter} -> {j}");
                    }
                }
            }
        }
    }
}
