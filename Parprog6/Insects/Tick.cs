namespace Parprog6;

public class Tick : Bug
{
    public bool CanBite { get; set; }
    public bool CanFly { get; set; }
    public int NumberOfLegs { get; set; }
    public string Disease { get; set; }

    public Tick()
    {
        CanBite = true;
        CanFly = false;
        NumberOfLegs = 8;
        Disease  = "Can give lyme disease";
    }  
    
    public void PrintBug()
    {
        Console.WriteLine($"Bug name: Tick, can bite: {CanBite}, and can fly: {CanFly}, number of legs: {NumberOfLegs}, Diseases: {Disease} ");
    }
    
}