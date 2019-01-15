using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Exam_Preparation_Chore_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalTime = 0;
            var dishTime = 0;
            var cleanTime = 0;
            var laundryTime = 0;

            while (input != "wife is happy")
            {
                string dishPattern = @"<([a-z0-9]+)>";
                string cleaningPattern = @"\[([A-Z0-9]+)\]";
                string laundryPattern = @"\{([\w\W]+)\}";

                if (Regex.IsMatch(input, dishPattern))
                {
                    Match match = Regex.Match(input, dishPattern);
                    string value = match.Groups[1].Value;
                    dishTime += DishTime(value);
                    totalTime += DishTime(value);
                }

                if (Regex.IsMatch(input, cleaningPattern))
                {
                    Match match = Regex.Match(input, cleaningPattern);
                    string value = match.Groups[1].Value;
                    cleanTime += CleanTheHouse(value);
                    totalTime += CleanTheHouse(value);
                }

                if (Regex.IsMatch(input, laundryPattern))
                {
                    Match match = Regex.Match(input, laundryPattern);
                    string value = match.Groups[1].Value;
                    laundryTime += LaundryTime(value);
                    totalTime += LaundryTime(value);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Doing the dishes - {dishTime} min.");
            Console.WriteLine($"Cleaning the house - {cleanTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");

            Console.WriteLine($"Total - {totalTime} min.");
        }
        public static int DishTime(string value)
        {
            int time = 0;

            foreach (char symbol in value)
            {
                if (symbol > '0' && symbol <= '9')
                {
                    time += (int)char.GetNumericValue(symbol);
                }
            }

            return time;
        }

        public static int CleanTheHouse(string value)
        {
            int time = 0;

            foreach (char symbol in value)
            {
                if (symbol > '0' && symbol <= '9')
                {
                    time += (int)char.GetNumericValue(symbol);
                }
            }

            return time;
        }

        public static int LaundryTime(string value)
        {
            int time = 0;

            foreach (char symbol in value)
            {
                if (symbol > '0' && symbol <= '9')
                {
                    time += (int)char.GetNumericValue(symbol);
                }
            }

            return time;
        }    
    }
}
