using System;
using System.Text;
using System.Linq;


namespace Strings_and_Regex_Exercise_1_Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string someString = Console.ReadLine();

            string exchange = new string('*', keyword.Length);

            someString = someString.Replace(keyword, exchange);

            Console.WriteLine(someString);
        }
    }
}
