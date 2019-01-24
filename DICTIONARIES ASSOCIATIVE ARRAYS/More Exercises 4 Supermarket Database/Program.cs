using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_4_Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split(" ").ToList();
            Dictionary<string, decimal> productsAndPrices = new Dictionary<string, decimal>();
            Dictionary<string, int> productsAndQuantities = new Dictionary<string, int>();

            while (products[0] != "stocked")
            {
                string name = products[0];
                decimal priceOfProduct = decimal.Parse(products[1]);
                int quantity = int.Parse(products[2]);
               


                if (!productsAndPrices.ContainsKey(name))
                {                    
                    productsAndPrices.Add(name, priceOfProduct);
                }
                else
                {
                    productsAndPrices[name] = priceOfProduct;            
                }
                if (!productsAndQuantities.ContainsKey(name))
                {
                    productsAndQuantities.Add(name, quantity);
                }
                else
                {
                    productsAndQuantities[name] += quantity;
                }

                products = Console.ReadLine().Split(" ").ToList();
            }
            var sum = 0.0m;
            foreach (var kvp in productsAndPrices)
            {
                foreach (var pair in productsAndQuantities)
                {
                    if (kvp.Key == pair.Key)
                    {
                        Console.WriteLine($"{kvp.Key}: ${kvp.Value} * {pair.Value} = ${kvp.Value*pair.Value:F2} ");
                        sum += kvp.Value * pair.Value;
                    }
                }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${sum:F2}");

        }
    }
}
