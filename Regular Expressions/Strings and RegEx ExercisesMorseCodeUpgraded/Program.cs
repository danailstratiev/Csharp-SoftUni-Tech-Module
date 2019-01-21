using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Strings_and_RegEx_ExercisesMorseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split("|").ToArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                string elements = numbers[i];
                var sum = 0;
                var zeroes = 0;
                var ones = 0;

                for (int j = 0; j < elements.Length; j++)
                {
                    var symbol = elements[j];

                    if (symbol == '0')
                    {
                        zeroes++;
                    }
                    else
                    {
                        ones++;
                    }
                }
                sum = zeroes * 3 + ones * 5;
                var counter = 1;

                for (int j = 0; j < elements.Length - 1; j++)
                {
                    if (elements[j] == elements[j + 1])
                    {
                        counter++;
                    }
                    else if (counter > 1)
                    {
                        sum += counter;
                        counter = 1;
                    }
                }
                if (counter > 1)
                {
                    sum += counter;
                }
                char letter = Convert.ToChar(sum);
                sb.Append(letter);
            }

            Console.WriteLine(sb);
        }
    }
}
