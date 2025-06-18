namespace Parprog6;

public class Bugs
{
    public List<Bug> BugList = new List<Bug>()
    {
        new Mosquito(),
        new Fly(),
        new Spider(),
        new Tick(),
        new Wasp()
    };

    public void PrintBugs()
    {
        foreach (var bug in BugList)
        {
            bug.PrintBug();
        }
    }

    public void CreateNewBug()
    {
        bool canBite = false;
        bool canFly = false;
        Console.Write("Enter the name of the bug: ");
        string name = Console.ReadLine();
        
        Console.Write("Can it bite? (yes/no)");
        switch (Console.ReadLine()){
            case "yes":
                canBite = true;
                break;
            case "no":
                break;
        }
        Console.Write("Can it fly? (yes/no) ");
        switch (Console.ReadLine())
        {
            case "yes":
                canFly = true;
                break;
            case "no":
                break;
        }
        
        Console.Write("How many legs? ");
        int legs = int.Parse(Console.ReadLine());
        
        Console.Write("Any diseases?");
        string disease = Console.ReadLine();
        
        CustomBug newBug = new CustomBug(name, canBite, canFly, legs, disease);
        
        BugList.Add(newBug);
    }

}