using System;

namespace _4._2_Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(first,second,third));
        }
        static int GetMax (int first,int second,int third)
        {
            var biggestNumber1 = Math.Max(first, second);
            var biggestofThree = Math.Max(biggestNumber1, third);
            return biggestofThree;
        }
    }
}
