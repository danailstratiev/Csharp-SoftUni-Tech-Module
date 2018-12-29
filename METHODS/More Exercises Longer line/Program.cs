using System;

namespace _4._9_Longer_line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double xFirst = Math.Abs(x1) + Math.Abs(x2);
            double yFirst = Math.Abs(y1) + Math.Abs(y2);

            double xSecond = Math.Abs(x3) + Math.Abs(x4);
            double ySecond = Math.Abs(y3) + Math.Abs(y4);


            double distance1 = Math.Sqrt(xFirst * xFirst + yFirst * yFirst);
            double distance2 = Math.Sqrt(xSecond * xSecond + ySecond * ySecond);

            if (distance1 < distance2)
            {
                if (Math.Abs(x3 + y3) <= Math.Abs(x4 + y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
            else
            {
                if (Math.Abs(x1 + y1) <= Math.Abs(x1 + y1))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
        
        
        }
    }
}
