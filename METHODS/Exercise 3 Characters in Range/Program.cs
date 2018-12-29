using System;

namespace Exercise_3_Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            for (int i = Math.Min((int)symbol1, (int)symbol2) + 1; i < Math.Max((int)symbol1, (int)symbol2); i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
