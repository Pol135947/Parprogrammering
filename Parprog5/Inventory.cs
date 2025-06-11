namespace Parprog5;

public class Inventory
{
    public List<Item> _inventoryList = new List<Item>();
   
    public void PrintInventory()
    {
        if (_inventoryList.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        foreach (Item item in _inventoryList)
        {
            Console.WriteLine($"Item Name: {item.Name}, Amount: {item.Quantity}");
        }
    }

    public void AddItem(Item newItem)
    {
        Item existingItem = _inventoryList.Find(item => item.Name == newItem.Name);

        if (existingItem != null)
        {
            existingItem.AddQuantity(); 
        }
        else
        {
            _inventoryList.Add(new Item(newItem.Name, 1));
        }
    }
}