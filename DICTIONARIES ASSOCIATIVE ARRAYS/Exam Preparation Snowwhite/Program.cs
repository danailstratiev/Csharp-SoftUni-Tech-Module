using System;
using System.Linq;
using System.Collections.Generic;



namespace Exam_Preparation_Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Physics { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var colorToDwarf = new Dictionary<string, List<Dwarf>>();
            var allDwarves = new List <Dwarf>();

            while (input != "Once upon a time")
            {
                List<string> dwarfEquipment = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string dwarfName = dwarfEquipment[0];
                string hatColor = dwarfEquipment[1];
                int dwarfPhysics = int.Parse(dwarfEquipment[2]);

                if (!colorToDwarf.ContainsKey(hatColor))
                {
                    colorToDwarf[hatColor] = new List<Dwarf>();
                }

                var dwarvesByCurrentColor = colorToDwarf[hatColor];

                var foundDwarf = dwarvesByCurrentColor.FirstOrDefault(d => d.Name == dwarfName);
                // Ако сме намерили джуджето по цвят и име, трябва да стравним по физика

                if (foundDwarf != null)
                {
                    foundDwarf.Physics = Math.Max(dwarfPhysics, foundDwarf.Physics);
                    // Ако сме го намерили презаписваме по-голямата от двете стойности (по условие)
                }
                else
                {
                    var dwarf = new Dwarf
                    {
                        Name = dwarfName,
                        Color = hatColor,
                        Physics = dwarfPhysics
                    };

                    dwarvesByCurrentColor.Add(dwarf);
                    allDwarves.Add(dwarf);
                }

                input = Console.ReadLine();
            }

            var result = allDwarves.OrderByDescending(d => d.Physics).
                ThenByDescending(d => colorToDwarf[d.Color].Count()).
                ToList();

            foreach (var dwarf in result)
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}
