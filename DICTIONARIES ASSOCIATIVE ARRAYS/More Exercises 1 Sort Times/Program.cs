using System;
using System.Linq;
using System.Collections.Generic;


namespace More_Exercises_1_Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> times = Console.ReadLine().Split(" ").ToList();
            times.Sort();

            Console.WriteLine(string.Join(", ",times));
        }
    }
}
