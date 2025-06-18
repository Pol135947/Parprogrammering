namespace Parprog6;

public class Mosquito : Bug
{
    public bool CanBite { get; set; }
    public bool CanFly { get; set; }
    public int NumberOfLegs { get; set; }
    public string Disease { get; set; }

    public Mosquito()
    {
        CanBite = true;
        CanFly = true;
        NumberOfLegs = 6;
        Disease = "Itching";
    }
    
    public void PrintBug()
    {
        Console.WriteLine($"Bug name: Mosquito, can bite: {CanBite}, and can fly: {CanFly}, number of legs: {NumberOfLegs}, Diseases: {Disease} ");
    }
    
}