using Game;
using Game.Pokemons;
using Game.Pokemons.Types;

var inferno = new Attack("Inferno", ElementType.Fire, 22);
var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
var ember = new Attack("Ember", ElementType.Fire, 6);

var electroBall = new Attack("Electro Ball", ElementType.Electric, 19);
var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 14);
var spark = new Attack("Spark", ElementType.Electric, 3);

var waterfall = new Attack("Waterfall", ElementType.Water, 2);
var whirlpool = new Attack("Whirlpool", ElementType.Water, 10);
var steamEruption = new Attack("Steam Eruption", ElementType.Water, 15);

var charmander = new Charmander(25, [inferno, flamethrower, ember]);
var charizard = new FirePokemon("Charizard", 32, [inferno, flamethrower, ember]);
var charmeleon = new FirePokemon("Charmeleon", 35, [inferno, flamethrower, ember]);

var pikachu = new Pikachu(15, [electroBall, thunderbolt, spark]);
var magnemite = new ElectricPokemon("Magnemite", 21, [electroBall, thunderbolt, spark]);
var voltorb = new ElectricPokemon("Voltorb", 29, [electroBall, thunderbolt, spark]);

var squirtle = new Squirtle(10, [waterfall, whirlpool, steamEruption]);
var blastoise = new WaterPokemon("Blastoise", 32, [waterfall, whirlpool, steamEruption]);
var poliwag = new WaterPokemon("Poliwag", 17, [waterfall, whirlpool, steamEruption]);

var pokemons = new List<Pokemon> { charizard, charmander, charmeleon, pikachu, magnemite, voltorb, squirtle, blastoise, poliwag };
foreach (var pokemon in pokemons)
{
    pokemon.RaiseLevel();
    pokemon.RandomAttack();

    if (pokemon is IEvolvable evolvable)
    {
        evolvable.Evolve();
    }
}
