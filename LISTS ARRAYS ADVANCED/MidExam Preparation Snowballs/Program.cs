using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;


namespace MidExam_Preparation_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger bestBall = 0;
            var bestQuality = 0;
            var bestTime = 0;
            var bestSnow = 0;

            for (int i = 0; i < snowballs; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality) ;

                if (snowballValue > bestBall)
                {
                    bestBall = snowballValue;
                    bestQuality = snowballQuality;
                    bestTime = snowballTime;
                    bestSnow = snowballSnow;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestBall} ({bestQuality})");
        }
    }
}
