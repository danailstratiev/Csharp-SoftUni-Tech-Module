using System;
using System.Linq;
using System.Collections.Generic;


namespace More_Exercises_5_Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> driver = new Dictionary<string, string>();


            for (int i = 0; i < n; i++)
            {
            List <string> input = Console.ReadLine().Split(" ").ToList();
                string command = input[0];
                string user = input[1];             
                
                if (command == "register")
                {
                string code = input[2];
                char[] codeCheck = code.ToString().ToArray();
                    if (HasFourDigits(codeCheck) == true && HasUpperCase(codeCheck) == true 
                        && IsLongEnough(codeCheck) == true)
                    {
                        if (!driver.ContainsKey(user))
                        {
                            if (driver.ContainsValue(code))
                            {
                                Console.WriteLine($"ERROR: license plate {code} is busy");
                            }
                            else
                            {
                                driver.Add(user, code);
                                Console.WriteLine($"{user} registered {code} successfully");
                            }
                        }
                        else 
                        {                             
                            Console.WriteLine($"ERROR: already registered with plate number {code}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {code}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!driver.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {user} unregistered successfully");
                        driver.Remove(user);
                    }
                }
            }
            foreach (var kvp in driver)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
        static bool IsLongEnough(char[] codeCheck)
        {
            bool isLongEnough = false;
            char[] tableOFchars = codeCheck;
            if (tableOFchars.Length == 8)
            {
                isLongEnough = true;
            }
            return (isLongEnough);
        }
        static bool HasFourDigits(char[] codeCheck)
        {
            bool hasFourDigits = false;
            char[] tableOFchars = codeCheck;

            List<char> numbers = new List<char>();
            numbers.Add(tableOFchars[2]);
            numbers.Add(tableOFchars[3]);
            numbers.Add(tableOFchars[4]);
            numbers.Add(tableOFchars[5]);
            foreach (char symbol in numbers)
            {
                if (48 <= symbol && symbol <= 57 )
                {
                    hasFourDigits = true;
                }
                else
                {
                    hasFourDigits = false;
                    break;
                }
            }

            return hasFourDigits;
        }
        static bool HasUpperCase (char[] codeCheck)
        {
            bool hasUpperCase = false;
            char[] tableOFchars = codeCheck;

            List<char> letters = new List<char>();
            letters.Add(tableOFchars[0]);
            letters.Add(tableOFchars[1]);
            letters.Add(tableOFchars[6]);
            letters.Add(tableOFchars[7]);
            foreach (char j in letters)
            {
                if (j >= 65 && j <= 90)
                {
                    hasUpperCase = true;
                }
                else
                {
                    hasUpperCase = false;
                    break;
                }
            }
            return hasUpperCase;
        }
    }
}
