namespace Parprog6;

public class CustomBug : Bug
{
    public string Name { get; set; }
    public bool CanBite { get; set; }
    public bool CanFly { get; set; }
    public int NumberOfLegs { get; set; }
    public string Disease { get; set; }

    public CustomBug(string name, bool canBite, bool canFly, int numberOfLegs, string disease)
    {
        Name = name;
        CanBite = canBite;
        CanFly = canFly;
        NumberOfLegs = numberOfLegs;
        Disease = disease;
    }
    public void PrintBug()
    {
        Console.WriteLine($"Bug name: {Name}, can bite: {CanBite}, and can fly: {CanFly}, number of legs: {NumberOfLegs}, Diseases: {Disease} ");

    }
}