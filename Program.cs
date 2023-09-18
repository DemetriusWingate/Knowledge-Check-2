using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"Product Name: {Name}\nPrice: {Price:C}\nQuantity: {Quantity}\nDescription: {Description}";
    }
}

public class Shoes : Product
{
    public string ShoeBrand { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}\nShoe Brand: {ShoeBrand}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        List<Product> recordList = new List<Product>();

        for (int i = 0; i < numberOfRecords; i++)
        {
            // Create a Shoes object
            Shoes shoes = new Shoes();

            Console.WriteLine("Enter Product Name: ");
            shoes.Name = Console.ReadLine();

            Console.WriteLine("Enter Price: ");
            shoes.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity: ");
            shoes.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Description: ");
            shoes.Description = Console.ReadLine();

            Console.WriteLine("Enter Shoe Brand: ");
            shoes.ShoeBrand = Console.ReadLine();

            // Add the Shoes object to the list
            recordList.Add(shoes);
        }

        // Print the objects in the list
        Console.WriteLine("\n--- Product List ---");
        foreach (var product in recordList)
        {
            Console.WriteLine(product);
            Console.WriteLine(); // Add a blank line for separation
        }
    }
}

