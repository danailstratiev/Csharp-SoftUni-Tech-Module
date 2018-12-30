using System;

namespace Lab_1.__Day_of_the_week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {"Monday",
             "Tuesday",
             "Wednesday",
             "Thursday",
             "Friday",
             "Saturday",
             "Sunday"
             };
            int day = int.Parse(Console.ReadLine());

            if (day < 1 || day >7)
            {
                Console.WriteLine("Invalid day");
                return;
            }
            string daysInEnglish = days[day-1];

            Console.WriteLine(daysInEnglish);
        }
    }
}
