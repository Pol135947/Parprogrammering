namespace Parprog5;

public class Shop
{
   
    public List<Item> ShopItems = new List<Item>()
    { 
        new Item("Owl", 10), 
        new Item("Rats", 10), 
        new Item("Cat", 5),
        new Item("Phoenix Wand", 10), 
        new Item("Unicorn Wand", 5), 
        new Item("Dragon_Wand", 1) 
    };

    public void BuyItem(int index, Character character)
    {
    
        if (index < 0 || index >= ShopItems.Count)
        {
            Console.WriteLine("Invalid item number. Please try again.");
            return;
        }

        Item itemToBuy = ShopItems[index];

        if (itemToBuy.Quantity <= 0)
        {
            Console.WriteLine($"Sorry, '{itemToBuy.Name}' is out of stock.");
            return;
        }
        
        character.Inventory.AddItem(itemToBuy); 
        
        
        itemToBuy.ReduceQuantity(); 
        
        Console.WriteLine($"You have purchased one {itemToBuy.Name}.");
    }

    public void PrintShopItems()
    {
        Console.WriteLine("--- Available Items in Shop ---");
        for (int i = 0; i < ShopItems.Count; i++)
        {
            Item item = ShopItems[i];
            Console.WriteLine($"#{i + 1}: {item.PrintItem()}");
        }
        Console.WriteLine("-----------------------------");
    }
    
    public void BrowseItems(Character character){
        PrintShopItems();
        Console.WriteLine("Enter the number of the item you want to buy:");
        // Added try-catch for robust input handling
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            BuyItem(number - 1, character);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        
        Console.WriteLine("\nYour Inventory:");
        character.Inventory.PrintInventory();
    }
}