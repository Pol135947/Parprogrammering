namespace Parprog6;

public class Wasp : Bug
{
    public bool CanBite { get; set; }
    public bool CanFly { get; set; }
    public int NumberOfLegs { get; set; }
    public string Disease { get; set; }

    public Wasp()
    {
        CanBite = true;
        CanFly = true;
        NumberOfLegs = 6;
        Disease = "You're screwed if you have the wrong allergy";
    }
    
    public void PrintBug()
    {
        Console.WriteLine($"Bug name: Wasp, can bite: {CanBite}, and can fly: {CanFly}, number of legs: {NumberOfLegs}, Diseases: {Disease} ");
    }
}