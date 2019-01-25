using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_7_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            string[] input = Console.ReadLine().Split("|").ToArray();
            string country;
            string city;
            long population;

            while (input[0] != "report")
            {
                city = input[0];
                country = input[1];
                population = long.Parse(input[2]) ;

                if (!countries.ContainsKey(country))
                {
                    Dictionary<string, long> currentCity = new Dictionary<string, long>();
                    currentCity.Add(city, population);

                    countries.Add(country, currentCity);
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);
                    }
                }
                input = Console.ReadLine().Split("|").ToArray();
            }
            foreach ( var pair in countries.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");

                foreach (var cityPair in pair.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=> {cityPair.Key}: {cityPair.Value}");
                }
            }
        }
    }
}
