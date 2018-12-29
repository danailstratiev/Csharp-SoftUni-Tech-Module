using System;

namespace TechFund_Data_types_p02_Chars_to_string
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            char symbol3 = char.Parse(Console.ReadLine());
            char[] symbols = new char[3];
            symbols[0] = symbol1;
            symbols[1] = symbol2;
            symbols[2] = symbol3;
            


            Console.WriteLine(string.Join("",symbols));
        }
    }
}
