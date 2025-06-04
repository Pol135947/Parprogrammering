namespace Parprog4;

public class Pokemon
{
    public string _name;
    public string _type;
    private int _health;
    private int _attack;

    public Pokemon(string name, string type)
    {
        _name = name;
        _type = type;
    }
    public Pokemon(string name, string type, int health, int attack)
    {
        _name = name;
        _type = type;
        _health = health;
        _attack = attack;
    }
    
    public void PrintPokemon()
    {
        Console.WriteLine($"NAME: {_name}, TYPE: {_type}");
    }

    public override string ToString()
    {
        return _name;
    }
}