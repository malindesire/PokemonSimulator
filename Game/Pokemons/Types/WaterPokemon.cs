namespace Game.Pokemons.Types
{
    internal class WaterPokemon : Pokemon
    {
        // Constructor for WaterPokemon that initializes the name, level, and attacks
        public WaterPokemon(string name, int level, List<Attack> attacks) 
            : base(name, level, ElementType.Water, attacks)
        {
        }
    }
}
