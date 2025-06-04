namespace Game.Characters
{
    internal class ElectricPokemon : Pokemon
    {
        // Constructor for ElectricPokemon that initializes the name, level, and attacks
        public ElectricPokemon(string name, int level, List<Attack> attacks) 
            : base(name, level, ElementType.Electric, attacks)
        {
        }
    }
}
