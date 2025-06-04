namespace Game.Characters
{
    internal class FirePokemon : Pokemon
    {
        // Constructor for FirePokemon that initializes the name, level, and attacks
        public FirePokemon(string name, int level, List<Attack> attacks) 
            : base(name, level, ElementType.Fire, attacks)
        {
        }
    }
}
