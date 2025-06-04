// In a separate file (e.g., Car.cs) or above the Program class

public class Car
{
    public string Brand { get; private set; }
    public string Model { get; private set; } // Model name
    public int Year { get; private set; }     // Year of manufacture
    public string RegistrationNumber { get; private set; }
    public int Kilometers { get; private set; }
    public Customer? Owner { get; set; } // Null if owned by the dealership

    public Car(string brand, string model, int year, string registrationNumber, int kilometers)
    {
        Brand = brand;
        Model = model;
        Year = year;
        RegistrationNumber = registrationNumber;
        Kilometers = kilometers;
        Owner = null; // Dealership owns it initially
    }

    public void PrintCarDetails()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Reg No: {RegistrationNumber}, Kilometers: {Kilometers}km");
        if (Owner != null)
        {
            Console.WriteLine($"   Owned by: {Owner.Name}");
        }
        else
        {
            Console.WriteLine("   Available for sale.");
        }
    }

    public override string ToString() // Useful for display
    {
        return $"{Brand} {Model} ({Year}) - {RegistrationNumber}, {Kilometers}km";
    }
}
