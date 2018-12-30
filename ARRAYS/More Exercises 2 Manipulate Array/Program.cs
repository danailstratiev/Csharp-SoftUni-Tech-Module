using System;
using System.Linq;
using System.Collections.Generic;



namespace More_Exercises_2_Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayofStrings = Console.ReadLine().Split(" ").ToList();
            int numberofCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberofCommands; i++)
            {
            List<string> commands = Console.ReadLine().Split(" ").ToList();

                if (commands[0] == "Reverse")
                {
                    arrayofStrings.Reverse();
                }
                else if (commands[0] == "Distinct")
                {
                 arrayofStrings = arrayofStrings.Distinct().ToList();
                }
                else if (commands[0] == "Replace")
                {
                    int index = int.Parse(commands[1]);
                    string replaced = commands[2];

                    arrayofStrings.Insert(index, replaced);
                    arrayofStrings.RemoveAt(index + 1);
                }
            }
            Console.WriteLine(string.Join(", ", arrayofStrings));
        }  
    }
}
