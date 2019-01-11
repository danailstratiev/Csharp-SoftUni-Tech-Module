using System;

namespace Lab_2_Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var ri = random.Next(0, words.Length);

                var tempValue = words[i];
                words[i] = words[ri];
                words[ri] = tempValue;
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
