using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_4_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            Dictionary<string, double> priceOfProducts = new Dictionary<string, double>();
            Dictionary<string, int> quantityOfProducts = new Dictionary<string, int>();

            while (input[0] != "buy")
            {
                string product = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!priceOfProducts.ContainsKey(product))
                {
                    priceOfProducts.Add(product, price);
                }
                else
                {
                    priceOfProducts[product] = price;
                }
                if (!quantityOfProducts.ContainsKey(product))
                {
                    quantityOfProducts.Add(product, quantity);
                }
                else
                {
                    quantityOfProducts[product] += quantity;
                }
                input = Console.ReadLine().Split(" ").ToArray();
            }
            foreach (var kvp in priceOfProducts)
            {
                foreach (var pair in quantityOfProducts)
                {
                    if (kvp.Key == pair.Key)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value*pair.Value:F2}");
                    }
                }
            }
        }
    }
}
