using System;

namespace _2._8_Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                
                if (ingredient == "cheese")
                {
                    counter += 500;
                }
               else if (ingredient == "tomato sauce")
                {
                    counter += 150;
                }
               else if (ingredient == "salami")
                {
                    counter += 600;
                }
               else if (ingredient == "pepper")
                {
                    counter += 50;
                }
            }
            Console.WriteLine($"Total calories: {counter}");
        }
    }
}
