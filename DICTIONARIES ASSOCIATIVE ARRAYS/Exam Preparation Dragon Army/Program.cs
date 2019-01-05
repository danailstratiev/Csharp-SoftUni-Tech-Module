using System;
using System.Linq;
using System.Collections.Generic;


namespace Exam_Preparation_Dragon_Army
{
    class Dragon
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dragonArmy = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string type = input[0];
                string name = input[1];
                string damaged = input[2];
                int damage = 45;
                if (damaged != "null")
                {
                    damage = int.Parse(damaged);
                }
                string originalHealth = input[3];
                int health = 250;
                if (originalHealth != "null")
                {
                    health = int.Parse(input[3]);
                }
                string armored = input[4];
                int armor = 10;
                if (armored != "null")
                {
                    armor = int.Parse(armored);
                }

                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy[type] = new List<Dragon>();
                }

                var dragons = dragonArmy[type];

                var foundDragon = dragons.FirstOrDefault(x => x.Name == name && x.Type == type);

                if (foundDragon != null)
                {
                    foundDragon.Health = health;
                    foundDragon.Damage = damage;
                    foundDragon.Armor = armor;
                }
                else
                {
                    var dragon = new Dragon
                    {
                        Type = type,
                        Name = name,
                        Damage = damage,
                        Health = health,
                        Armor = armor
                    };

                    dragons.Add(dragon);
                }
            }

            foreach (var army in dragonArmy)
            {
                var types = army.Value.OrderBy(x => x.Name);
                var avDamage = types.Average(x => x.Damage);
                var avHealth = types.Average(x => x.Health);
                var avArmor = types.Average(x => x.Armor);

                Console.WriteLine($"{army.Key}::({avDamage:F2}/{avHealth:F2}/{avArmor:F2})");

                foreach (var dragon in types)
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
}
