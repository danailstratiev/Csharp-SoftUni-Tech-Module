using System;

namespace _2._3_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double priceperPerson = 0;
            double totalPrice = 0;
            string hall = "hall";

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            if (groupSize <= 50)
            {
                hall = "Small Hall";
                Console.WriteLine($"We can offer you the {hall}");
                if (package == "Normal")
                {
                    totalPrice = (2500 + 500) - ((2500 + 500) * 0.05);
                    priceperPerson = totalPrice / groupSize;
                }
                else if (package == "Gold")
                {
                    totalPrice = (2500 + 750) - ((2500 + 750) * 0.1);
                    priceperPerson = totalPrice / groupSize;
                }
                else if (package == "Platinum")
                {
                    totalPrice = (2500 + 1000) - ((2500 + 1000) * 0.15);
                    priceperPerson = totalPrice / groupSize;
                }
                Console.WriteLine($"The price per person is {priceperPerson:F2}$");
            }
            else if (50 < groupSize && groupSize <=100)
            {
                hall = "Terrace";
                Console.WriteLine($"We can offer you the {hall}");
                if (package == "Normal")
                {
                    totalPrice = (5000 + 500) - ((5000 + 500) * 0.05);
                    priceperPerson = totalPrice / groupSize;
                }
                else if (package == "Gold")
                {
                    totalPrice = (5000 + 750) - ((5000 + 750) * 0.1);
                    priceperPerson = totalPrice / groupSize;
                }
                else if (package == "Platinum")
                {
                    totalPrice = (5000 + 1000) - ((5000 + 1000) * 0.15);
                    priceperPerson = totalPrice / groupSize;
                }
                Console.WriteLine($"The price per person is {priceperPerson:F2}$");
            }
            else if (100 < groupSize && groupSize <= 120)
            {
                hall = "Great Hall";
                Console.WriteLine($"We can offer you the {hall}");
                if (package == "Normal")
                {
                    totalPrice = (7500 + 500) - ((7500 + 500) * 0.05);
                    priceperPerson = totalPrice / groupSize;
                }
                else if (package == "Gold")
                {
                    totalPrice = (7500 + 750) - ((7500 + 750) * 0.1);
                    priceperPerson = totalPrice / groupSize;
                }
                else if (package == "Platinum")
                {
                    totalPrice = (7500 + 1000) - ((7500 + 1000) * 0.15);
                    priceperPerson = totalPrice / groupSize;
                }
                Console.WriteLine($"The price per person is {priceperPerson:F2}$");
            }
        }
    }
}
