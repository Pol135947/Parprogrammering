namespace Parprog4;

public class Game
{
    private List<Pokemon> _allPokemons = new List<Pokemon>
    {
        new Pokemon("Pikachu", "Grass"),
        new Pokemon("Squirtle", "Water"),
        new Pokemon("Blastoise", "Water"),
        new Pokemon("Gyarados", "Water"), // Very famous Water type
        new Pokemon("Lapras", "Water"), // Famous Water/Ice type
        new Pokemon("Vaporeon", "Water"), // Popular Eeveelution
        new Pokemon("Kyogre", "Water"), // Legendary Water type
        new Pokemon("Suicune", "Water"), // Legendary Water type
        new Pokemon("Greninja", "Water"), // Very popular Water type
        new Pokemon("Psyduck", "Water"), // Iconic Water type
        new Pokemon("Marill", "Water"),
        new Pokemon("Quagsire", "Grass"), // Famous Water/Ground type
        new Pokemon("Swampert", "Grass"), // Popular Water/Ground starter evolution
        new Pokemon("Groudon", "Grass"), // Legendary Ground type
        new Pokemon("Sandshrew", "Grass"), // Classic Ground type
        new Pokemon("Cubone", "Grass"), // Famous Ground type with a story
        new Pokemon("Rhyhorn", "Grass"),
        new Pokemon("Rhydon", "Grass"),
        new Pokemon("Donphan", "Grass"), // Popular Ground type
        new Pokemon("Garchomp", "Grass"), // Very famous and powerful Ground type
        new Pokemon("Mamoswine", "Grass"), // Strong Ground type
        new Pokemon("Excadrill", "Grass"), // Popular competitive Ground type
        new Pokemon("Krookodile", "Grass"), // Famous Ground type
        new Pokemon("Hippowdon", "Grass"), // Weather-setting Ground type
    };
    
    private List<string> _terrains = new List<string>{"Grass", "Water"};

    public void PrintAllTerrains()
    {
        foreach (var terrain in _terrains)
        {
            Console.WriteLine(terrain);
        }
    }
    
    public void PrintAllPokemons()
    {
        foreach (var pokemon in _allPokemons)
        {
            pokemon.PrintPokemon();
        }
    }

    public Pokemon GetPokemon(string name)
    {
        foreach (var pokemon in _allPokemons)
        {
            if (pokemon._name == name)
            {
                return pokemon;
            }
            Console.WriteLine($"Pokemon {name} was not found");
        }
        return null;
    }

    public Pokemon ChooseStartPokemon()
    {
        Console.WriteLine("Choose a pokemon:");
        string pokemonInput = Console.ReadLine();
        Pokemon pokemon = GetPokemon(pokemonInput);
        Console.WriteLine($"{pokemonInput} has been promoted to startpokemon!");
        return pokemon;
    }
    
    public string ChooseRandomTerrain()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _terrains.Count); 
        string currentTerrain = _terrains[randomIndex];
        return currentTerrain;
    }
    
    public Pokemon ChooseRandomPokemon(string terrain)
    {
        Random random = new Random();

        List<Pokemon> grassPokemon = new List<Pokemon>();
        List<Pokemon> waterPokemon = new List<Pokemon>();

        foreach (Pokemon pokemon in _allPokemons)
        {
            switch (pokemon._type)
            {
                case "Grass":
                    grassPokemon.Add(pokemon);
                    break;
                case "Water":
                    waterPokemon.Add(pokemon);
                    break;
            }
        }
        
        switch (terrain)
        {
            case "Grass":
                int randomGrassIndex = random.Next(0, grassPokemon.Count); 
                Pokemon randomGrassPokemon = grassPokemon[randomGrassIndex];
                return randomGrassPokemon;
            case "Water":
                int randomWaterIndex = random.Next(0, waterPokemon.Count);
                Pokemon randomWaterPokemon = waterPokemon[randomWaterIndex];
                return randomWaterPokemon;
        }
        return null;
    }

    public void CatchPokemon(Pokemon pokemon, Trainer trainer)
    {
        Random random = new Random();
        int num = random.Next(2); // Generates 0 or 1
        switch (num)
        {
            case 0:
                Console.WriteLine($"{pokemon._name} has been caught!");
                trainer.AddPokemons(pokemon);
                break;
            case 1: // Now 1 represents "fled"
                Console.WriteLine($"{pokemon._name} has fled, and is chillin' in the wild!");
                break;
        }
    }
    
    public void Explore(Trainer trainer)
    {
        string terrain = ChooseRandomTerrain();
        Console.WriteLine($"You are now in {terrain}!");
        Pokemon randomPokemon =  ChooseRandomPokemon(terrain);
        Console.WriteLine($"You have encountered {randomPokemon._name}!");
        
        Console.WriteLine($"What do you want to do? \n1. Fight \n2. Catch \n3. Leave");
        switch (Console.ReadKey().KeyChar)
        {
            case '1':
                break;
            case '2':
                CatchPokemon(randomPokemon, trainer);
                break;
            case '3':
                Console.WriteLine($"{randomPokemon._name} remains free in the wilderness, chillin'!");
                break;
        }
    }
}