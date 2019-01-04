using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_1_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split(" ").ToList();

            Dictionary<string, int> phonebook = new Dictionary<string, int>();

            while (contacts[0] != "END")
            {
                if (contacts[0] == "A")
                {
                    string name = contacts[1];
                    int number = int.Parse(contacts[2]);

                    if (!phonebook.ContainsKey(contacts[1]))
                    {
                        phonebook.Add(contacts[1],int.Parse(contacts[2]));
                    }
                    else
                    {
                        phonebook[contacts[1]] = int.Parse(contacts[2]);
                    }
                }
                else if (contacts[0] == "S")
                {
                    if (!phonebook.ContainsKey(contacts[1]))
                    {
                        Console.WriteLine($"Contact {contacts[1]} does not exist."); ;
                    }
                    else
                    {
                        Console.WriteLine($"{contacts[1]} -> {contacts[2]}");
                    }
                }
                contacts = Console.ReadLine().Split(" ").ToList();
            }
        }
    }
}
