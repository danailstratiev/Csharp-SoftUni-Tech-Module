using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_4_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> myClass = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] student = Console.ReadLine().Split(" ").ToArray();
                Students students = new Students();
                students.FirstName = student[0];
                students.LastName = student[1];
                students.Grade = double.Parse(student[2]);
                myClass.Add(students);
            }

            foreach (var mate in myClass.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{mate.FirstName} {mate.LastName}: {mate.Grade:F2}");
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
