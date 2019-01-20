using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Strings_and_RegEx_Exercise_2_Email_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> email = Console.ReadLine().Split("@").ToList();
            string left = email[0];
            string right = email[1];
            int leftSum = 0;
            int rightSum = 0;

            foreach (var symbol in left)
            {
                leftSum += symbol;
            }

            foreach (var symbol in right)
            {
                rightSum += symbol;
            }

            var result = leftSum - rightSum;

            if (result >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
