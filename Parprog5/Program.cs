namespace Parprog5;

class Program
{
    static void Main(string[] args)
    {
        Character character = new Character("Harry Potter", "Gryffindor");
        Shop shop = new Shop();
        
        
        character.IntroduceCharacter();

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Buy");
            Console.WriteLine("2. Magic");
            Console.WriteLine("3. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    shop.BrowseItems(character);
                    break;
                case "2":
                    Console.WriteLine("To be implemented, WIP");
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}