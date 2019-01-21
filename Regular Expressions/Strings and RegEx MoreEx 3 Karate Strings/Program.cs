using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;


namespace Strings_and_RegEx_MoreEx_3_Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> inputAsChar = input.ToList();
            int powerKick = 0;
            List<int> indexes = new List<int>();

            for (int i = 0; i < inputAsChar.Count; i++)
            {
                if (inputAsChar[i] > '0' && inputAsChar[i] <= '9')
                {
                    powerKick += (int)Char.GetNumericValue(inputAsChar[i]);
                    inputAsChar.RemoveAt(i);
                    powerKick--;
                }
                if (inputAsChar[i] == '>')
                {
                    if (inputAsChar[i + 1] > '0' && inputAsChar[i + 1] <= '9')
                    {
                        powerKick += (int)Char.GetNumericValue(inputAsChar[i + 1]);
                        inputAsChar.RemoveAt(i + 1);
                        powerKick--;
                    }
                }
                else
                {
                    if (powerKick > 0)
                    {
                        int j = i;
                        while (powerKick > 0 && inputAsChar[j] != '>')
                        {
                            inputAsChar.RemoveAt(j);
                            powerKick--;

                            if (j == inputAsChar.Count)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            input = string.Join("", inputAsChar);

            Console.WriteLine(input);
        }
    }
}
