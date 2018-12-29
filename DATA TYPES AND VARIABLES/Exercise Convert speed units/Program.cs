using System;

namespace _3._11_Convert_speed_units
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            
            float time = seconds + minutes * 60 + hours * 3600;
            float mps = meters / time;
            float kph = (meters / 1000) / (time / 3600);
            float mlph = (meters / 1609) / (time / 3600);

            Console.WriteLine($"{mps:0.######}");
            Console.WriteLine($"{kph:0.######}");
            Console.WriteLine($"{mlph:0.######}");

        }
    }
}
