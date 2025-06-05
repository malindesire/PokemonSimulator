using Game.Pokemons.Types;

namespace Game.Pokemons
{
    internal class Pikachu : ElectricPokemon, IEvolvable
    {
        public Pikachu(int level, List<Attack> attacks) : base("Pikachu", level, attacks)
        { }

        public void Evolve()
        {
            string oldName = Name; // Store the old name
            Name = "Raichu";
            Level += 10; // Evolving increases the level by 10

            Console.WriteLine($"{oldName} is evolving... Now it's {Name}! Level {Level}!");
        }
    }
}
