using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_2_Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split(" ").ToList();

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (contacts[0] != "END")
            {
                if (contacts[0] == "A")
                {
                    string name = contacts[1];
                    string number = contacts[2];

                    phonebook[name] = number;
                }
                else if (contacts[0] == "S")
                {
                    string name = contacts[1];

                    foreach (var contact in phonebook)
                    {
                        string nameOfContact = contact.Key;
                        string numberOfContact = contact.Value;

                        if (phonebook.ContainsKey(nameOfContact))
                        {
                            Console.WriteLine($"{nameOfContact} -> {numberOfContact}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                    }
                }
                else if (contacts[0] == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        // Може да подредим и с phonebook.Orderby(x => x.Key)
                        string nameOfContact = contact.Key;
                        string numberOfContact = contact.Value;

                        Console.WriteLine($"{nameOfContact} -> {numberOfContact}");
                    }                    
                }
                contacts = Console.ReadLine().Split(" ").ToList();
            }

        }
    }
}
