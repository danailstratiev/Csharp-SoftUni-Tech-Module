using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_7_Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();  

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(studentName))
                {
                    List<double> grades = new List<double>();
                    grades.Add(grade);
                    studentGrades.Add(studentName, grades);
                }
                else
                {
                    studentGrades[studentName].Add(grade);
                }
            }           
            foreach (var kvp in studentGrades.OrderByDescending(x => x.Value.Average()))
            {
                if (kvp.Value.Average() >= 4.50)
                {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
                }
            }
        }
    }
}
