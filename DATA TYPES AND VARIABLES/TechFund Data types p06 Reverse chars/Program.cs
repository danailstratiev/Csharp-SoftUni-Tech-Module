using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Data_types_p06_Reverse_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            char symbol3 = char.Parse(Console.ReadLine());
            List<char> symbols = new List <char>();
            symbols.Add(symbol1);
            symbols.Add(symbol2);
            symbols.Add(symbol3);
            symbols.Reverse();



            Console.WriteLine(string.Join(" ", symbols));
        }
    }
}
