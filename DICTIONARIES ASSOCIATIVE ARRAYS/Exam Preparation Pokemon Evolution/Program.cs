using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Exam_Preparation_Pokemon_Evolution
{
    class Pokemon
    {
        public string Name { get; set; }

        public string Evolution { get; set; }

        public int Index { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pokeBalls = new Dictionary<string, List<Pokemon>>();
            string evolution = "";
            int index = 0;

            while (input != "wubbalubbadubdub")
            {
                string[] characteristics = input.Split(" -> ").ToArray();
                string name = characteristics[0];

                if (characteristics.Length == 3)
                {
                    evolution = characteristics[1];
                    index = int.Parse(characteristics[2]);
                }

                if (!pokeBalls.ContainsKey(name))
                {
                    pokeBalls[name] = new List<Pokemon>();
                }

                var pokemons = pokeBalls[name];

                var foundPokemon = pokemons.FirstOrDefault(x => x.Name == name);

                if (foundPokemon == null)
                {
                    if (characteristics.Length == 3)
                    {
                        var pokemon = new Pokemon
                        {
                            Name = name,
                            Evolution = evolution,
                            Index = index
                        };

                        pokemons.Add(pokemon);
                    }
                }
                else
                {
                    if (characteristics.Length == 3)
                    {
                        var pokemon = new Pokemon
                        {
                            Name = name,
                            Evolution = evolution,
                            Index = index
                        };

                        pokemons.Add(pokemon);
                    }
                    else
                    {
                        Console.WriteLine($"# {foundPokemon.Name}");
                        foreach (var pokemon in pokemons.Where(x => x.Name == name))
                        {
                            Console.WriteLine($"{pokemon.Evolution} <-> {pokemon.Index}");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pokemon in pokeBalls)
            {
                var pokeName = pokemon.Key;
                var pokemons = pokemon.Value.OrderByDescending(x => x.Index);

                Console.WriteLine($"# {pokeName}");

                foreach (var creature in pokemons)
                {
                    Console.WriteLine($"{creature.Evolution} <-> {creature.Index}");
                }
            }
        }
    }
}
