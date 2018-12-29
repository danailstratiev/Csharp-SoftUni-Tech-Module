using System;

namespace _2._4_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            double studio = 0;
            double doubleRoom = 0;
            double suite = 0;
            double totalPriseforStudio = 0;
            double totalPriseforDouble = 0;
            double totalPriseforSuite = 0;



            if (month == "May")
            {
                studio = 50;
                doubleRoom = 65;
                suite = 75;
                if (nightCount > 7)
                {
                    totalPriseforStudio = nightCount * studio * 0.95;
                }
                else
                {
                    totalPriseforStudio = nightCount * studio;
                }
                totalPriseforDouble = nightCount * doubleRoom;
                totalPriseforSuite = nightCount * suite;
            }
            else if (month == "October")
            {
                studio = 50;
                doubleRoom = 65;
                suite = 75;
                if (nightCount > 7)
                {
                    totalPriseforStudio = (nightCount - 1) * studio * 0.95;
                }
                else
                {
                    totalPriseforStudio = nightCount * studio;
                }
                totalPriseforDouble = nightCount * doubleRoom;
                totalPriseforSuite = nightCount * suite;
            }
            else if (month == "June")
            {
                studio = 60;
                doubleRoom = 72;
                suite = 82;
                if (nightCount > 14)
                {
                    totalPriseforDouble = nightCount * doubleRoom * 0.9;

                }
                else
                {
                    totalPriseforDouble = nightCount * doubleRoom;
                }
                totalPriseforStudio = nightCount * studio;
                totalPriseforSuite = nightCount * suite;
            }
            else if (month == "September")
            {
                studio = 60;
                doubleRoom = 72;
                suite = 82;
                if (nightCount > 14)
                {
                    totalPriseforDouble = nightCount * doubleRoom * 0.9;

                }
                else
                {
                    totalPriseforDouble = nightCount * doubleRoom;
                }
                if (nightCount > 7)
                {
                    totalPriseforStudio = (nightCount - 1);
                }
                else
                {
                    totalPriseforStudio = nightCount * studio;
                }
                totalPriseforSuite = nightCount * suite;
            }
            else if (month == "July")
            {
                studio = 68;
                doubleRoom = 77;
                suite = 89;
                if (nightCount > 14)
                {
                    totalPriseforSuite = nightCount * suite * 0.85;
                }
                else
                {
                    totalPriseforSuite = nightCount * suite;
                }
                totalPriseforStudio = nightCount * studio;
                totalPriseforDouble = nightCount * doubleRoom;
            }
            else if (month == "August")
            {
                studio = 68;
                doubleRoom = 77;
                suite = 89;
                if (nightCount > 14)
                {
                    totalPriseforSuite = nightCount * suite * 0.85;
                }
                else
                {
                    totalPriseforSuite = nightCount * suite;
                }
                totalPriseforStudio = nightCount * studio;
                totalPriseforDouble = nightCount * doubleRoom;
            }
            else if (month == "December")
            {
                studio = 68;
                doubleRoom = 77;
                suite = 89;
                if (nightCount > 14)
                {
                    totalPriseforSuite = nightCount * suite * 0.85;
                }
                else
                {
                    totalPriseforSuite = nightCount * suite;
                }
                totalPriseforStudio = nightCount * studio;
                totalPriseforDouble = nightCount * doubleRoom;
            }
            Console.WriteLine($"Studio: {totalPriseforStudio:F2} lv.");
            Console.WriteLine($"Double: {totalPriseforDouble:F2} lv.");
            Console.WriteLine($"Suite: {totalPriseforSuite:F2} lv.");

        }
    }
}
