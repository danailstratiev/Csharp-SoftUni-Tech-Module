using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace Regex_Exercise_3_Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int first = numbers[0];
            int second = numbers[1];

            string camera = Console.ReadLine();
            string pattern = @"\|<([\w]{" + first + @"})([\w]{0," + second + @"})";
            // използваме конкатенация за да може да си прочетем числата за разделяне
            // разделянето на групи ни позволява да изберем тази част, която ще отговаря на условията

            MatchCollection matches = Regex.Matches(camera, pattern);
            List<string> films = new List<string>();

            foreach (Match film in matches)
            {
                films.Add(film.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", films));
        }
    }
}
