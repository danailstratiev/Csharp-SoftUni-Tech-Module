using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Lists_Exercises_7_Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine().Split('|').ToList();
            collection.Reverse();
            var appened = new List<string>();

            for (int i = 0; i < collection.Count; i++)
            {
                string[] helper = collection[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (var item in helper)
                {
                    appened.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", appened));
            
            

        }
    }
}
