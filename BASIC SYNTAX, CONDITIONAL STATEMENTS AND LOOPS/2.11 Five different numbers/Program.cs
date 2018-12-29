using System;

namespace _2._11_Five_different_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a + 5 >= b)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = a; i <= b-4; i++)
            {
                for (int j = a+1; j <= b-3; j++)
                {
                    for (int k = a+2; k <= b-2; k++)
                    {
                        for (int l = a+3; l <= b-1; l++)
                        {
                            for (int m  = a + 4; m <= b; m++)
                            {
                                if (a <= i && i < j && j < k && k < l && l < m && m <= b)
                                {
                                    Console.Write($"{i} {j} {k} {l} {m}");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
