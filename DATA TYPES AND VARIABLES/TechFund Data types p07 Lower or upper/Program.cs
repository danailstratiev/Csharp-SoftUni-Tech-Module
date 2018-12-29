using System;

namespace TechFund_Data_types_p07_Lower_or_upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            for (char i = 'a'; i <= 'z' ; i++)
            {
                if (letter == i)
                {
            Console.WriteLine("lower-case");                    
                }
            }
            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (letter == i)
                {
                    Console.WriteLine("upper-case");
                }
            }

        }
    }
}
