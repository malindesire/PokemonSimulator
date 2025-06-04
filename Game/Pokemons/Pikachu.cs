using Game.Pokemons.Types;

namespace Game.Pokemons
{
    internal class Pikachu : ElectricPokemon
    {
        public Pikachu(int level, List<Attack> attacks) : base("Pikachu", level, attacks)
        { }
    }
}
