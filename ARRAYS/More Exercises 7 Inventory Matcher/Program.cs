using System;
using System.Linq;
using System.Collections.Generic;


namespace More_Exercises_7_Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(" ").ToArray();
            long[] quantities = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            string[] prices = Console.ReadLine().Split(" ").ToArray();
            Dictionary<string,Dictionary<string,long>> priceOfProducts = new Dictionary<string, Dictionary<string, long>> ();
            string input = Console.ReadLine();
            if (products.Length == 5)
            {
                for (long i = 0; i < products.Length - 1; i++)
                {
                    string currentProduct = products[i];
                    string price = prices[i];
                    long quantity = quantities[i];

                    if (!priceOfProducts.ContainsKey(currentProduct))
                    {
                        Dictionary<string, long> quantityOfProducts = new Dictionary<string, long>();
                        if (!quantityOfProducts.ContainsKey(price))
                        {
                            quantityOfProducts.Add(price, quantity);
                        }
                        priceOfProducts.Add(currentProduct, quantityOfProducts);
                    }
                }
            }
            else
            {
                for (long i = 0; i < products.Length; i++)
                {
                    string currentProduct = products[i];
                    string price = prices[i];
                    long quantity = quantities[i];

                    if (!priceOfProducts.ContainsKey(currentProduct))
                    {
                        Dictionary<string, long> quantityOfProducts = new Dictionary<string, long>();
                        if (!quantityOfProducts.ContainsKey(price))
                        {
                            quantityOfProducts.Add(price, quantity);
                        }
                        priceOfProducts.Add(currentProduct, quantityOfProducts);
                    }
                }
            }
            while (input != "done")
            {
                if (priceOfProducts.ContainsKey(input))
                {
                    foreach (var kvp in priceOfProducts)
                    {
                        foreach (var pair in kvp.Value)
                        {
                            if (kvp.Key == input)
                            {
                                Console.WriteLine($"{kvp.Key} costs: {pair.Key}; Available quantity: {pair.Value}");
                                break;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

        }
    }
}
