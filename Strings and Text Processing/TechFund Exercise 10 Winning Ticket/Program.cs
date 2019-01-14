using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;



namespace TechFund_Exercise_10_Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"([\w])*([@$^#]{6,10})+([\w])*([@#$^]{6,10})+([\w])*";

            foreach (var ticket in input)
            {
                if (ticket.Trim().Length == 20)
                {
                    if (Regex.IsMatch(ticket.Trim(), pattern))
                    {
                        Match match = Regex.Match(ticket, pattern);
                        int counter = match.Groups[2].Length;
                        char matchSymbol = ' ';
                        if (ticket.Contains('@'))
                        {
                            matchSymbol = '@';                            
                        }
                        else if (ticket.Contains('#'))
                        {
                            matchSymbol = '#';                            
                        }
                        else if (ticket.Contains('$'))
                        {
                            matchSymbol = '$';                            
                        }
                        else if (ticket.Contains('^'))
                        {
                            matchSymbol = '^';                            
                        }                        
                        if (counter == 10)
                        {
                            Console.WriteLine("ticket" + " " + '"' + ticket.Trim() + '"' + " " + '-' + " " + counter + matchSymbol + " " +  "Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine("ticket" + " " + '"' + ticket.Trim() + '"' + " " + '-' + " " + counter + matchSymbol);

                        }
                    }
                    else
                    {
                        Console.WriteLine("ticket" + " " + '"' + ticket.Trim() + '"' + " " + '-' + " " + "no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }        
    }
}
