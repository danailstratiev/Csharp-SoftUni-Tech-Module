using System;

namespace _4._11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    Triangle();
                    break;
                case "square":
                    Square();
                    break;
                case "circle":
                    Circle();
                    break;
                case "rectangle":
                    Rectangle();
                    break;

            }
        }
        static void Triangle ()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side*height/2:F2}");
        }
        static void Square()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Pow(side,2):F2}");
        }
        static void Circle()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI*side*side:F2}");
        }
        static void Rectangle()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine($"{sideA*sideB:F2}");
        }

    }
}
