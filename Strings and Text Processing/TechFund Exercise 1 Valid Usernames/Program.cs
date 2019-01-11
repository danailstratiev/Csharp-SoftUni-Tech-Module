using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace TechFund_Exercise_1_Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ").ToArray();
            List<string> newWords = new List<string>();
            
            foreach (string word in words)
            {
                if (IsLongEnough(word) == true && AllowedSymbols(word) == true)
                {
                    newWords.Add(word);
                }
            }

            foreach (var item in newWords)
            {
                Console.WriteLine(item);
            }

        }
        public static bool IsLongEnough(string word)
        {
            bool isLongEnough = true;

           if (word.Length < 3 || word.Length > 16)
           {
                isLongEnough = false;
           }
           else
           {
               isLongEnough = true;
           }
            return isLongEnough;
        }
        public static bool AllowedSymbols(string word)
        {
            bool isAllowed = false;

            foreach (char symbol in word)
            {
                if ( symbol == 45 || (symbol >= 65 && symbol <= 90) 
                    || symbol == 95 || (symbol >= 97 && symbol <= 122) || (symbol >= 48 && symbol <= 57))
                // Може и с директен метод char.IsLetterOrDigit !!!
                {
                    isAllowed = true;
                }
                else
                {
                    isAllowed = false;
                    break;
                }                
            }

            return isAllowed;
        }
    }
}
