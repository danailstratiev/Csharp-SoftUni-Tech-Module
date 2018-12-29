using System;

namespace _1._1_Debit_card_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            int secondnum = int.Parse(Console.ReadLine());
            int thirdnum = int.Parse(Console.ReadLine());
            int forthdnum = int.Parse(Console.ReadLine());

            Console.Write($"{firstnum:D4} {secondnum:D4} {thirdnum} {forthdnum:D4} ");

        }
    }
}
