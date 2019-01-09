using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_7_Order_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ").ToArray();
            List<Person> people = new List<Person>();

            while (command[0] != "End")
            {
                Person person = new Person();
                person.Name = command[0];
                person.ID = command[1];
                person.Age = int.Parse(command[2]);
                people.Add(person);

                command = Console.ReadLine().Split(" ").ToArray();
            }
            foreach (var person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
