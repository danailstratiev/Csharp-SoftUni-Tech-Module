using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_9_Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            bool isPalindrome = false;

            while (n != "END")
            {
                char[] nums = n.ToString().ToArray();

                int newNum = int.Parse(string.Join("", nums.Reverse()));

                if (newNum == int.Parse(n))
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                }
                if (isPalindrome == true)
                {
                Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                n = Console.ReadLine();
            }
        }
    }
}
