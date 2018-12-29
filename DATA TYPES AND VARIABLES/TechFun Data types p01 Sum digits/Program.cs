using System;
using System.Linq;
using System.Collections.Generic;



namespace TechFun_Data_types_p01_Sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number>0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
