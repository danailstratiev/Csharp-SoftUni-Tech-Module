using System;
using System.Numerics;


namespace TechFund_Exercise_5_Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            BigInteger result = firstNumber * secondNumber;

            Console.WriteLine(result);
        }
    }
}
