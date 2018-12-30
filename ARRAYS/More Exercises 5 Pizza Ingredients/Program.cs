using System;
using System.Linq;
using System.Collections.Generic;


namespace More_Exercises_5_Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ingredients = Console.ReadLine().Split(" ").ToList();
            int n = int.Parse(Console.ReadLine());
            List<string> pizza = new List<string>();
          
                for (int i = 0; i < ingredients.Count; i++)
                {
                    if (ingredients[i].Length == n)
                    {
                    pizza.Add(ingredients[i]);
                        Console.WriteLine($"Adding {ingredients[i]}.");
                    if (pizza.Count >= 10)
                    {
                        break;
                    }
                    }
                }
            Console.WriteLine($"Made pizza with total of {pizza.Count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",pizza)}.");            

        }
    }
}
