namespace Parprog6;

public interface Bug
{
    public bool CanBite { get; set; }
    public bool CanFly { get; set; }
    public int NumberOfLegs { get; set; }
    public string Disease  { get; set; }

    public void PrintBug();
}
    