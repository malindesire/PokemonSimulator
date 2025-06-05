using Game.Pokemons.Types;

namespace Game.Pokemons
{
    internal class Squirtle : WaterPokemon, IEvolvable
    {
        public Squirtle(int level, List<Attack> attacks) : base("Squirtle", level, attacks)
        { }

        public void Evolve()
        {
            string oldName = Name; // Store the old name
            Name = "Wartortle";
            Level += 10; // Evolving increases the level by 10

            Console.WriteLine($"{oldName} is evolving... Now it's {Name}! Level {Level}!");
        }
    }
}
