namespace Game.Pokemons
{
    internal abstract class Pokemon
    {
        private readonly Random random = new Random();
        public string Name { get; internal set; }
        public int Level { get; internal set; }
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
            // Pick a random attack from the list of attacks and invoke its Use method.
            int randomIndex = random.Next(0, Attacks.Count - 1);

            Attacks[randomIndex].Use(Level);
        }

        public void Attack()
        {
            // Let the user pick an attack from the list of attacks and invoke its Use method.
            Console.WriteLine($"Choose an attack for {Name}:");
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Attacks[i].Name}");
            }
            int choice = int.Parse(Console.ReadLine() ?? string.Empty) - 1; // ToDo: Handle if input is invalid
           
            Attacks[choice].Use(Level);
        }

        public void RaiseLevel()
        {
            // Increment the level of the given pokemon and print out that the pokemon has leveled up.
            Level += 1;
        }
    }
}
