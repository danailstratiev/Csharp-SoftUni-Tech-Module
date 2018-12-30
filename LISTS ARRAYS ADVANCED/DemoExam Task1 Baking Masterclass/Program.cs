using System;
using System.Linq;
using System.Collections.Generic;


namespace DemoExam_Task1_Baking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            var totalAprons = apronPrice * (Math.Ceiling(students * 1.2m ));
            var totalForEggs = eggPrice * 10 * students;
            var totalForFlour = flourPrice * students;

            List<int> studs = new List<int>();
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    studs.Add(0);
                }
                else
                {
                    studs.Add(1);
                }
            }
            var totalStudents = studs.Sum();

            if (students >= 5 )
            {
                totalForFlour = flourPrice * totalStudents;
            }
            var sum = totalAprons + totalForEggs + totalForFlour;

            if (sum <= budget)
            {
                Console.WriteLine($"Items purchased for {sum:F2}$.");
            }
            else
            {
                Console.WriteLine($"{sum - budget:F2}$ more needed.");
            }
        }
    }
}
