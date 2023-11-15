class Program
{
    static void Main()
    {
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");

        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                Console.WriteLine("Enter product type (1 for CatFood, 2 for DogLeash): ");
                string productType = Console.ReadLine();

                if (productType == "1")
                {
                    CatFood catFood = new CatFood();
                    Console.Write("Enter product name: ");
                    catFood.Name = Console.ReadLine();
                    Console.Write("Enter product price: ");
                    catFood.Price = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter product quantity: ");
                    catFood.Quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter product description: ");
                    catFood.Description = Console.ReadLine();
                    Console.Write("Enter product weight (in pounds): ");
                    catFood.WeightPounds = double.Parse(Console.ReadLine());
                    Console.Write("Is it kitten food? (true/false): ");
                    catFood.KittenFood = bool.Parse(Console.ReadLine());

                    Console.WriteLine(JsonSerializer.Serialize(catFood));
                }
                else if (productType == "2")
                {
                    DogLeash dogLeash = new DogLeash();
                    Console.Write("Enter product name: ");
                    dogLeash.Name = Console.ReadLine();
                    Console.Write("Enter product price: ");
                    dogLeash.Price = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter product quantity: ");
                    dogLeash.Quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter product description: ");
                    dogLeash.Description = Console.ReadLine();
                    Console.Write("Enter leash length (in inches): ");
                    dogLeash.LengthInches = int.Parse(Console.ReadLine());
                    Console.Write("Enter leash material: ");
                    dogLeash.Material = Console.ReadLine();

                    Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                }
                else
                {
                    Console.WriteLine("Invalid product type.");
                }
            }

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
        }
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }
}

class CatFood : Product
{
    public double WeightPounds { get; set; }
    public bool KittenFood { get; set; }
}

class DogLeash : Product
{
    public int LengthInches { get; set; }
    public string Material { get; set; }
}
