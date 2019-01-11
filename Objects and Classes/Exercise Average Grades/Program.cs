using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_4_Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> ourClass = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(" ").ToList();
                Students student = new Students();
                // Винаги трябва да инициализираме обекта с неговия клас преди да започнем да го запълваме
                student.Name = input[0];
                input.RemoveAt(0);
                student.Grades = input.Select(double.Parse).ToList();
                ourClass.Add(student);
            }

            foreach (var person in ourClass.Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name).ThenBy(x => x.AverageGrade))
            {
                Console.WriteLine($"{person.Name} -> {person.AverageGrade:F2}");
            }
        }
    }
    class Students
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get {return Grades.Average(); } }
        // AverageGrade ще ни бъде необходим само за прочитане, така че нямаме нужда от set
    }
}