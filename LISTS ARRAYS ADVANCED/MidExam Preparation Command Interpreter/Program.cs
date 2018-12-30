using System;
using System.Linq;
using System.Collections.Generic;


namespace MidExam_Preparation_Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int startIndex = 2;
            int count = 4;

            numbers.Reverse(startIndex, count);

        }
    }
}
