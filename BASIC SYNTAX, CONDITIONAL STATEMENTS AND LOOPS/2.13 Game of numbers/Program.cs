using System;

namespace _2._13_Game_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int i = n ; i >= m; i--)
            {
                for (int j = n; j >= m ; j--)
                {
                   
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
                        return;
                    }
                    counter++;

                }
            }
            Console.WriteLine($"{counter} combinations - neither equals 100");
        }
    }
}
