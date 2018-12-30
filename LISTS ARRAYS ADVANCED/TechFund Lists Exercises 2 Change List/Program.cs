using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Lists_2_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(" ").ToArray();

            while (commands[0] != "end")
            {
                string command = commands[0];

                if (command == "Delete")
                {
                int n = int.Parse(commands[1]);
                    numbers.RemoveAll(x => x == n);
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);

                    numbers.Insert(position, element);
                }
              commands = Console.ReadLine().Split(" ").ToArray();

            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
