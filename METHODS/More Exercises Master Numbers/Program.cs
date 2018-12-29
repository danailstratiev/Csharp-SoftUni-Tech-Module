using System;

namespace _4._12_Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (Divisibleby7(i) && HoldEvenDigit(i) && IsSymmetric(i))
                {
                    Console.WriteLine(i);
                }
            }
            
            
        }
        static bool Divisibleby7 (int number)
        {
            bool isDivisible = true;
            int sum = 0;
            int n = 0;

            while (number != 0)
            {
                n = number % 10;
                sum += n;
                number /=10;
            }
            if (sum % 7 == 0)
            {
                return true; ;
            }
            else
            {
                return false;
            }
        }
        static bool HoldEvenDigit (int number)
        {
            int evenDigit = 0;
            int oldNum = number;
            bool isEven = false;

            while (number != 0)
            {
                evenDigit = number % 10;

                if (evenDigit % 2 == 0)
                {
                    isEven = true;
                    return isEven;
                }
                number /= 10;                
            }
            return isEven;
        }
        static bool IsSymmetric (int number)
        {
            int reversed = 0;
            int oldNumber = number;
            int power = number.ToString().Length - 1;

            for (int i = 0; i < oldNumber.ToString().Length; i++)
            {
                reversed += number % 10 * (int)Math.Pow(10, power);
                power--;
                number /= 10;
            }
            if (reversed == oldNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
