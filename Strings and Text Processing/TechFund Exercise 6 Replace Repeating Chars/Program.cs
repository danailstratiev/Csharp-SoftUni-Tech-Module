using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace TechFund_Exercise_6_Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = Console.ReadLine();
            int n = someString.Length;
            StringBuilder sb = new StringBuilder();
            char currentSymbol = '0';

            for (int i = 0; i < n-1; i++)
            {
                currentSymbol = someString[i];
                if (someString[i] != someString[i+1])
                {
                    sb.Append(currentSymbol);
                }
                else
                {
                    continue;
                }
            }
            sb.Append(someString[someString.Length - 1]);

            Console.WriteLine(sb.ToString());
        }
    }
}
