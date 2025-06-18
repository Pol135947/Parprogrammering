namespace Parprog6;

public class Spider : Bug
{
    public bool CanBite { get; set; }
    public bool CanFly { get; set; }
    public int NumberOfLegs { get; set; }
    public string Positives { get; set; }
    public string Negatives { get; set; }
    public string Disease { get; set; }

    public Spider()
    {
        CanBite = true;
        CanFly = false;
        NumberOfLegs = 8;
        Positives = "Can eat flies and other bugs";
        Negatives = "Scary and disgusting";
        Disease = "Some can kill ya";
    }
    public void PrintBug()
    {
        Console.WriteLine($"Bug name: Spider, can bite: {CanBite}, and can fly: {CanFly}, number of legs: {NumberOfLegs}, Positives: {Positives}, Negative: {Negatives}, Diseases: {Disease} ");
    }
}