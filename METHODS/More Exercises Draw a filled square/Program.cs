using System;

namespace _3._4_Lab_Draw_a_filled_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintDashes(n);
            PrintBody(n);
            PrintDashes(n);
            
        }
        static void PrintDashes (int n)
        {
            string dashes = new string('-', 2 * n);
            Console.WriteLine(dashes);
        }
        static void PrintBody (int n)
        {
            for (int i = 0; i < n-2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < n-1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
