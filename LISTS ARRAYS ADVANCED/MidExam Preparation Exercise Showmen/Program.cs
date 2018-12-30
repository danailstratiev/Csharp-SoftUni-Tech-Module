using System;
using System.Linq;
using System.Collections.Generic;


namespace MidExam_Preparation_Exercise_Showmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var defeated = new List<int>();
            int count = snowmen.Count;

            while (snowmen.Count > 1)
            {                
                for (int i = 0; i < snowmen.Count; i++)
                {
                    if (snowmen.Count(x => x != -1) == 1)
                    {
                        // Ако останат 2 елемента може единия да убие другия и след това да се самоубие
                        // и програмата да гръмне
                        // това е най-сложното
                        break;
                    }

                    if (snowmen[i] == -1)
                    {
                        continue;
                    }

                    int attackerIndex = i;
                    int target = snowmen[i] % snowmen.Count;
                    
                    if (attackerIndex == target )
                    {
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                        snowmen[attackerIndex] = -1;
                    }
                    else if (Math.Abs(attackerIndex - target) % 2 == 0 )
                    {
                        Console.WriteLine($"{attackerIndex} x {target} -> {attackerIndex} wins");
                        snowmen[target] = -1;
                    }
                    else if (Math.Abs(attackerIndex - target) % 2 == 1)
                    {
                        Console.WriteLine($"{attackerIndex} x {target} -> {target} wins");
                        snowmen[attackerIndex] = -1;
                    }                   
                }
                snowmen = snowmen.Where(x => x != -1).ToList();                
            }
        }
    }
}
