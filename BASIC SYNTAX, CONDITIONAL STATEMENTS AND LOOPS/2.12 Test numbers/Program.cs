using System;

namespace _2._12_Test_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalCount = 0;

            for (int i = numberN; i >= 1; i--)
            {
                for (int j = 1 ; j <= numberM; j++)
                {
                    counter += (i * j) * 3;
                    totalCount++;

                    if (counter >= boundary)
                    {                       
                        Console.WriteLine($"{totalCount} combinations");
                        Console.WriteLine($"Sum: {counter} >= {boundary}");
                        return;
                    }                    
                }
            }            
                Console.WriteLine($"{totalCount} combinations");
                Console.WriteLine($"Sum: {counter}");                        
        }
    }
}
