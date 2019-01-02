using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_6_Cources
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" : ").ToArray();
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();

            while (input[0] != "end")
            {
                string courseName = input[0];
                string studentName = input[1];

                if (!courseInfo.ContainsKey(courseName))
                {
                    List<string> students = new List<string>();
                    students.Add(studentName);
                    courseInfo.Add(courseName, students);
                }
                else
                {
                    if (courseInfo.ContainsKey(courseName))
                    {
                    if (!courseInfo[courseName].Contains(studentName))
                    {
                        courseInfo[courseName].Add(studentName);
                    }
                    }
                }
                input = Console.ReadLine().Split(" : ").ToArray();
            }
            foreach (var kvp in courseInfo.OrderByDescending(x => x.Value.Count))
            {
                kvp.Value.Sort();

                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
