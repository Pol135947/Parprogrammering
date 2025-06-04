namespace Parprog4;

public class Trainer
{
    private string _name;
    public Pokemon _startPokemon;

    private int _pokeballs = 20;
    private int _potions = 20;
    private int _currency = 100;
    
    public List<Pokemon> _ownedPokemons = new List<Pokemon>();

    public Trainer(string name)
    {
        _name = name;
    }
    public Trainer(string name, Pokemon startPokemon)
    {
        _name = name;
        _startPokemon = startPokemon;
    }
    
    public Trainer(string name, Pokemon startPokemon, int pokeballs, int potions, int currency)
    {
        _name = name;
        _startPokemon = startPokemon;
        _pokeballs = pokeballs;
        _currency = currency;
        _potions = potions;
    }
    
    public void PrintTrainerInfo()
    {
        Console.WriteLine($"Name: {_name}, \nStart Pokemon: {ReturnName(_startPokemon)}, \nPokeballs: {_pokeballs}, \nPotions: {_potions},  \nCurrency: {_currency}");
    }
    
    public string ReturnName(Pokemon pokemon)
    {
        return pokemon._name;
    }

    public void AddPokemons(Pokemon pokemon)
    {
        _ownedPokemons.Add(pokemon);
    }
}