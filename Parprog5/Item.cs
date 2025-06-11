namespace Parprog5;

public class Item
{
    private string _name;
    private int _quantity;

    public string Name => _name;
    public int Quantity => _quantity;

    public Item(string name, int quantity)
    {
        _name = name;
        _quantity = quantity;
    }

    public Item(string name)
    {
        _name = name;
        _quantity = 1;
    }

    public void ReduceQuantity()
    {
        _quantity--;
    }

    public void AddQuantity()
    {
        _quantity++;
    }

    public void SetQuantity(int number)
    {
        _quantity = number;
    }

    public string PrintItem()
    {
        return $"Name: {_name}, Quantity: {_quantity}";
    }
}
    