using Game;
using Game.Pokemons;
using Game.Pokemons.Types;

var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
var ember = new Attack("Ember", ElementType.Fire, 6);
var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 14);
var bushes = new Attack("Bushes", ElementType.Electric, 7);
var waterfall = new Attack("Waterfall", ElementType.Water, 2);

var firePokemon = new FirePokemon("Charizard", 22, new List<Attack> { flamethrower, ember });
var charmander = new Charmander(25, new List<Attack> { flamethrower, ember });
var pikachu = new Pikachu(15, new List<Attack> { flamethrower, ember, thunderbolt, bushes, waterfall });

var pokemons = new List<Pokemon> { firePokemon, charmander, pikachu };

foreach (var pokemon in pokemons)
{
    pokemon.RaiseLevel();
    pokemon.Attack();

    if (pokemon is IEvolvable evolvable)
    {
        evolvable.Evolve();
    }
}

