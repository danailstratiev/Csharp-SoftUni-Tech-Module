using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Arrays_Exercise_10._1_Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];

            var ladybugIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).Where(i => i >= 0 && i < size).ToList();

            foreach (var index in ladybugIndexes)
            {
                field[index] = 1;
            }

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                var commandParts = line.Split(' ');

                var currentLadybugIndex = int.Parse(commandParts[0]);
                var direction = commandParts[1];
                var flyLength = int.Parse(commandParts[2]);

                if (direction == "left")
                {
                    flyLength *= -1;
                }   
                // outside of the field
                if (currentLadybugIndex < 0 || currentLadybugIndex >= size)
                {
                    continue;
                }
                // no ladybug here
                if (field[currentLadybugIndex] == 0)
                {
                    continue;
                }
                field[currentLadybugIndex] = 0; // fly away

                var nextIndexToLand = currentLadybugIndex;

                while (true)
                {
                    nextIndexToLand += flyLength;
                    // в зависимост от посоката ще се движи на ++ или на --;

                    if (nextIndexToLand < 0 || nextIndexToLand >= size)
                    {
                        break;
                    }
                    if (field[nextIndexToLand] == 1) // there is a ladybug here
                    {
                        continue;
                    }
                    field[nextIndexToLand] = 1; // just landed
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
