using System;
using System.Linq;

namespace TechFund_Exercise_7._1_String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = Console.ReadLine();
            int power = 0;

            for (int i = 0; i < someString.Length; i++)
            {
                if (someString[i] == '>')
                {
                    power += int.Parse(someString[i+1].ToString());
                    continue;
                }
                if ( power > 0)
                {
                    someString = someString.Remove(i, 1);
                    i--;
                    power--;
                }
            }
            Console.WriteLine(someString);
        }
    }
}
