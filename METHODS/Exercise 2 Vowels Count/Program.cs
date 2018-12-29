using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_2_Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int sum = 0;

            foreach (var item in word)
            {
                switch (item)
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'u':
                    case 'y':
                    case 'i':
                        sum++;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
