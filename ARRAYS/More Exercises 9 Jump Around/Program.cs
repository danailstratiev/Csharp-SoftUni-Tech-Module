using System;
using System.Linq;
using System.Collections.Generic;


namespace More_Exercises_9_Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int currentValue = 0;
            int currentIndex = 0;            
            int sum = 0;
            bool stop = false;
            int position = 0;
            currentIndex = 0;
            currentValue = numbers[currentIndex];
            sum = 0;


            while (stop == false)
            {                

                if (currentValue >= numbers.Length && currentIndex - currentValue < 0)
                {
                    if (sum == 0)
                    {
                        sum = currentValue;
                    }
                    Console.WriteLine(sum);
                    stop = true;
                    break;
                }
                else if (currentValue >= numbers.Length)
                {
                    position = currentIndex - currentValue;

                    if (position >= 0)
                    {
                        currentIndex = position;
                        currentValue = numbers[currentIndex];
                        sum += currentValue;
                        stop = false;
                    }
                    else
                    {
                        Console.WriteLine(sum);
                        stop = true;
                        break;
                    }
                }
                else if (currentValue < 0)
                {
                    position = currentIndex + currentValue;

                    if (position < numbers.Length)
                    {
                        currentIndex = position;
                        currentValue = numbers[currentIndex];
                        sum += currentValue;
                        stop = false;
                    }
                    else
                    {
                        Console.WriteLine(sum);
                        stop = true;
                        break;
                    }
                }
                else
                {
                    if (currentIndex < 0)
                    {
                        Console.WriteLine(sum);
                        stop = true;
                        break;
                    }
                    currentValue = numbers[currentIndex];
                    sum += currentValue;
                    if (currentValue + currentIndex >= numbers.Length)
                    {
                        currentIndex -= currentValue;
                    }                    
                    else
                    {
                     currentIndex += currentValue;          

                    }
                    stop = false;
                }
            }
        }
    }
}
