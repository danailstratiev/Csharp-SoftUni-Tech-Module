using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;



namespace Regex_Exercise_4_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string weatherForecast = Console.ReadLine();
            string pattern = @"([A-Z]{2})([0-9]+\.[0-9]{1,2})([A-Za-z]+)\|";
            List<string> lines = new List<string>();

            while (weatherForecast != "end")
            {
                lines.Add(weatherForecast);
                weatherForecast = Console.ReadLine();
            }
            List<Match> myMatches = new List<Match>();
            // правим си List от Match, за да можем после да използваме функционалността Groups
            foreach (string line in lines)
            {
                MatchCollection myForecasts = Regex.Matches(line, pattern);

                foreach (Match match in myForecasts)
                {
                    myMatches.Add(match);
                }
            }

            Dictionary<string, List<string>> weather = new Dictionary<string, List<string>>();
            // Речникът ще ни удобен за разпределение на групите от Regex-а 
            // и последователно четене и презаписване (където е нужно)
            foreach (Match current in myMatches)
            {
                if (!weather.ContainsKey(current.Groups[1].Value))
                {
                    List<string> climat = new List<string>();
                    climat.Add(current.Groups[2].Value);
                    climat.Add(current.Groups[3].Value);

                    weather.Add(current.Groups[1].Value,climat);
                }
                else
                {
                    weather[current.Groups[1].Value].Clear();
                    weather[current.Groups[1].Value].Add(current.Groups[2].Value);
                    weather[current.Groups[1].Value].Add(current.Groups[3].Value);
                }
            }
            
            foreach (var kvp in weather.OrderBy(x => double.Parse(x.Value[0])))
            {
                Console.WriteLine($"{kvp.Key} => {double.Parse(kvp.Value[0]):F2} => {kvp.Value[1]}");
            }
        }
    }
}
