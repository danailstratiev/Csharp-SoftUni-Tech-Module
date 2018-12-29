using System;

namespace _2._7_Cake_ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int counter = 0;

            while (ingredient != "Bake!")
            {
                counter++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
               
                
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");

        }
    }
}
