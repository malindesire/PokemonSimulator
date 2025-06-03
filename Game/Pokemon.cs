namespace Game
{
    internal abstract class Pokemon
    {
        public string Name { get; }
        public int Level { get; private set; }
        public ElementType Type { get; }
        public List<Attack> Attacks { get; }
        public Pokemon(string name, int level, ElementType type, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Type = type;
            Attacks = attacks ?? new List<Attack>();
        }
    }
}
