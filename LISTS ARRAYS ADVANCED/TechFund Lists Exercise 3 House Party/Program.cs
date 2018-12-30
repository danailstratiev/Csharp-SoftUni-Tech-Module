using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Lists_Exercise_3_House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guestsList = new List<string>();

            for (int i = 0; i < n; i++)
            {
               var guests = Console.ReadLine().Split(" ").ToList();
                string name = guests[0];
                string position = guests[2];

                if (!guestsList.Contains(name))
                {
                    if (position == "going!")
                    {
                        guestsList.Add(name);                        
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (position == "not")
                    {
                        guestsList.RemoveAll(x => x == name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }
            foreach (string guest in guestsList )
            {
                Console.WriteLine(guest);
            }
        }
    }
}
