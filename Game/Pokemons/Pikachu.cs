using Game.Pokemons.Types;

namespace Game.Pokemons
{
    internal class Pikachu : ElectricPokemon, IEvolvable
    {
        public Pikachu(int level, List<Attack> attacks) : base("Pikachu", level, attacks)
        { }

        public void Evolve()
        {
            Name = "Raichu";
            Level += 10; // Evolving increases the level by 10

            Console.WriteLine($"Pikachu is evolving... Now it's {Name}! Level {Level}!");
        }
    }
}
