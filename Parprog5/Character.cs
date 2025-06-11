namespace Parprog5;

public class Character
{
    private string _name;
    private string _house;

    private Inventory _inventory = new Inventory();
    
    public Inventory Inventory => _inventory;
    
    public Character(string name, string house)
    {
        _name = name;
        _house = house;
    }
    public void IntroduceCharacter()
    {
        Console.WriteLine($"{_name} is a part of the House of {_house}");
        Console.WriteLine("Current Inventory:");
        Inventory.PrintInventory();
    }
    
}