using System;

namespace _4._1_Hello_name__
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            HiName(name);
        }
        static void HiName (string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
