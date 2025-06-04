namespace Parprog3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dealership's inventory
            List<Car> dealershipCars = new List<Car>()
            {
                new Car("Mercedes", "E Class", 2006, "3F49JKW", 200000),
                new Car("Ford", "Mustang Fastback", 1967, "9I3JERH2", 100000),
                new Car("Dodge", "Charger R/T", 1969, "94JEM302", 120000), // Assuming "Volkswagen" was a typo for brand
                new Car("Porsche", "911 Carrera", 1983, "IDK24149", 38000)  // Assuming "Porsche 1928 1983" was Model Year
            };

            Customer customer1 = new Customer("Bruce Wayne");
            // Customer customer2 = new Customer("Danny Rand"); // Can be used later

            Console.WriteLine($"Welcome to the Car Dealership, {customer1.Name}!");

            bool shopping = true;
            while (shopping)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. View all available cars");
                Console.WriteLine("2. Filter cars");
                Console.WriteLine("3. View my cars");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewAllCars(dealershipCars);
                        break;
                    case "2":
                        FilterAndOfferCars(dealershipCars, customer1);
                        break;
                    case "3":
                        customer1.PrintOwnedCars();
                        break;
                    case "4":
                        shopping = false;
                        Console.WriteLine("Thank you for visiting!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        public static void ViewAllCars(List<Car> cars)
        {
            Console.WriteLine("\n--- Available Cars in Dealership ---");
            var availableCars = cars.Where(c => c.Owner == null).ToList();
            if (availableCars.Any())
            {
                for (int i = 0; i < availableCars.Count; i++)
                {
                    Console.Write($"{i + 1}. ");
                    availableCars[i].PrintCarDetails();
                }
            }
            else
            {
                Console.WriteLine("No cars currently available in the dealership.");
            }
        }
// (Continuing Program.cs)

public static void FilterAndOfferCars(List<Car> dealershipCars, Customer customer)
{
    Console.WriteLine("\n--- Filter Cars ---");
    Console.WriteLine("How do you want to filter?");
    Console.WriteLine("1. By Brand");
    Console.WriteLine("2. By Model"); // Now distinct from year
    Console.WriteLine("3. By Year Range");
    Console.WriteLine("4. By Registration Number");
    Console.WriteLine("5. By Kilometer Range (Less than / More than)");
    Console.Write("Enter filter type: ");

    if (!int.TryParse(Console.ReadLine(), out int filterChoice))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        return;
    }

    List<Car> availableCars = dealershipCars.Where(c => c.Owner == null).ToList();
    List<Car> filteredResults = new List<Car>();

    switch (filterChoice)
    {
        case 1: // Filter by Brand
            Console.Write("Enter brand: ");
            string? brandInput = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(brandInput))
            {
                filteredResults = availableCars.Where(c => c.Brand.Equals(brandInput, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            break;

        case 2: // Filter by Model
            Console.Write("Enter model: ");
            string? modelInput = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(modelInput))
            {
                // This allows partial matches in the model name
                filteredResults = availableCars.Where(c => c.Model.Contains(modelInput, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            break;

        case 3: // Filter by Year Range
            Console.Write("Enter minimum year: ");
            if (!int.TryParse(Console.ReadLine(), out int minYear)) { Console.WriteLine("Invalid min year."); break; }
            Console.Write("Enter maximum year: ");
            if (!int.TryParse(Console.ReadLine(), out int maxYear)) { Console.WriteLine("Invalid max year."); break; }
            filteredResults = availableCars.Where(c => c.Year >= minYear && c.Year <= maxYear).ToList();
            break;

        case 4: // Filter by Registration Number
            Console.Write("Enter registration number: ");
            string? regInput = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(regInput))
            {
                // Registration numbers are usually exact matches
                filteredResults = availableCars.Where(c => c.RegistrationNumber.Equals(regInput, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            break;

        case 5: // Filter by Kilometer Range
            Console.WriteLine("Filter by kilometers:");
            Console.WriteLine("  a. Less than a specific value");
            Console.WriteLine("  b. More than a specific value");
            Console.Write("Choose (a/b): ");
            string? kmChoice = Console.ReadLine()?.Trim().ToLower();
            Console.Write("Enter kilometer value: ");
            if (!int.TryParse(Console.ReadLine(), out int kmValue)) { Console.WriteLine("Invalid kilometer value."); break; }

            if (kmChoice == "a")
            {
                filteredResults = availableCars.Where(c => c.Kilometers < kmValue).ToList();
            }
            else if (kmChoice == "b")
            {
                filteredResults = availableCars.Where(c => c.Kilometers > kmValue).ToList();
            }
            else
            {
                Console.WriteLine("Invalid choice for kilometer filter.");
            }
            break;

        default:
            Console.WriteLine("Invalid filter type selected.");
            return;
    }

    if (filteredResults.Any())
    {
        Console.WriteLine("\n--- Filter Results ---");
        for (int i = 0; i < filteredResults.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            filteredResults[i].PrintCarDetails();
        }

        Console.Write("\nEnter the number of the car you want to buy (or 0 to cancel): ");
        if (int.TryParse(Console.ReadLine(), out int carSelection) && carSelection > 0 && carSelection <= filteredResults.Count)
        {
            Car selectedCar = filteredResults[carSelection - 1];
            Console.WriteLine("\nYou selected:");
            selectedCar.PrintCarDetails();
            BuyCar(customer, selectedCar, dealershipCars); // Pass dealership's main list
        }
        else if (carSelection == 0)
        {
            Console.WriteLine("Purchase cancelled.");
        }
        else
        {
            Console.WriteLine("Invalid car selection.");
        }
    }
    else
    {
        Console.WriteLine("No cars found matching your criteria.");
    }
}


private static void BuyCar(Customer customer, Car carToBuy, List<Car> dealershipInventory)
{
    Console.Write("Do you want to buy this car? (yes/no): ");
    string? confirm = Console.ReadLine()?.Trim().ToLower();
    if (confirm == "yes")
    {
        if (carToBuy.Owner == null) // Check if car is still available (owned by dealership)
        {
            customer.AddCar(carToBuy); // This also sets carToBuy.Owner = customer
            dealershipInventory.Remove(carToBuy); // CRITICAL: Remove from dealership inventory
            Console.WriteLine($"Congratulations, {customer.Name}! You now own the {carToBuy.Brand} {carToBuy.Model}.");
        }
        else
        {
            Console.WriteLine("Sorry, this car is no longer available or already sold.");
        }
    }
    else
    {
        Console.WriteLine("Purchase cancelled.");
    }
}
    }
}