// In a separate file (e.g., Customer.cs) or above the Program class
public class Customer
{
    public string Name { get; private set; }
    private List<Car> _ownedCars;

    public Customer(string name)
    {
        Name = name;
        _ownedCars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        if (!_ownedCars.Contains(car))
        {
            _ownedCars.Add(car);
            car.Owner = this; // Important: set the car's owner
        }
    }

    public void PrintOwnedCars()
    {
        Console.WriteLine($"\n--- Cars owned by {Name} ---");
        if (_ownedCars.Any())
        {
            foreach (Car car in _ownedCars)
            {
                // Using ToString() or PrintCarDetails()
                Console.WriteLine(car.ToString());
            }
        }
        else
        {
            Console.WriteLine("No cars currently owned.");
        }
    }
}