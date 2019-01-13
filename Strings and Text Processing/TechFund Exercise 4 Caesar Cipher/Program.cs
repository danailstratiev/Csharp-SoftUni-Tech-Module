using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace TechFund_Exercise_4_Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            int transformed = 0;
            StringBuilder sb = new StringBuilder();

            foreach (char symbol in phrase)
            {
                transformed = symbol + 3;
                sb.Append((char)transformed);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
