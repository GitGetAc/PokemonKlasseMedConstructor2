/* With Primary constructor (The whole class is in a constructor)

namespace PokemonKlasseMedConstructor2
{
    internal class Pokemon(string name, int health, int level)
    {
        public string? Name { get; set; } = name;
        public int Health { get; set; } = health;
        public int Level { get; set; } = level;

        public void ShowPokemon()
        {
            Console.WriteLine($"{Name} pokemon har {Health}hp og er level: {Level}");
        }
    }
}*/

namespace PokemonKlasseMedConstructor2
{
    internal class Pokemon
    {
        public string? Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public Pokemon(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }

        public void ShowPokemon()
        {
            Console.WriteLine($"{Name} pokemon har {Health}hp og er level: {Level}");
        }
    }
}
