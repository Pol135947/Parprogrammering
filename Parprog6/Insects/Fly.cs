namespace Parprog6;

public class Fly : Bug
{
    public bool CanBite { get; set; }
    public bool CanFly { get; set; }
    public int NumberOfLegs { get; set; }
    public string Disease { get; set; }
    
    public Fly(){
        CanBite = false;
        CanFly = true;
        NumberOfLegs = 6;
        Disease = "Can spread sickness";
    }
    
    public void PrintBug()
    {
        Console.WriteLine($"Bug name: Fly, can bite: {CanBite}, and can fly: {CanFly}, number of legs: {NumberOfLegs}, Diseases: {Disease} ");
    }

}