namespace Game.Pokemons
{
    internal abstract class Pokemon
    {
        public string Name { get; }
        public int Level { get; private set; }
        public ElementType Type { get; protected set; }
        public List<Attack> Attacks { get; }
        public Pokemon(string name, int level, ElementType type, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Type = type;
            Attacks = attacks ?? new List<Attack>();
        }

        public void RandomAttack()
        {
            // Todo: Pick a random attack from the list of attacks and invoke its Use method.
        }

        public void Attack()
        {
            // Todo: Let the user pick an attack from the list of attacks and invoke its Use method.
        }

        public void RaiseLevel()
        {
            // Todo: Increment the level og the given pokemon and print out that the pokemon has leveled up.
        }
    }
}
