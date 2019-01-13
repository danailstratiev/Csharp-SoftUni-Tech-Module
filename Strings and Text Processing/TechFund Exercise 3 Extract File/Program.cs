using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_3_Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] someString = Console.ReadLine().Split('\\').ToArray();

            string[] last = someString[someString.Length - 1].Split('.').ToArray();
            string fileName = last[0];
            string extension = last[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
