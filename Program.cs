// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Joe's Pizza!");

        List<string> menuItems = new List<string>
        {
            "1. Margherita Pizza - $10.99",
            "2. Pepperoni Pizza - $12.99",
            "3. Veggie Pizza - $11.99",
            "4. Meat Lovers Pizza - $14.99",
            "5. Exit"
        };
        bool ordering = true;
        List<string> orderItems = new List<string>();

        while (ordering)
        {
            Console.WriteLine("\nMenu:");
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
            }

            Console.Write("Enter the number of your choice (or '5' to exit): ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    orderItems.Add("Margherita Pizza");
                    break;
                case "2":
                    orderItems.Add("Pepperoni Pizza");
                    break;
                case "3":
                    orderItems.Add("Veggie Pizza");
                    break;
                case "4":
                    orderItems.Add("Meat Lovers Pizza");
                    break;
                case "5":
                    ordering = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }

        // Display Order Summary
        Console.WriteLine("\nOrder Summary:");
        if (orderItems.Count > 0)
        {
            foreach (var item in orderItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Thank you for your order! Enjoy your pizza!");
        }
        else
        {
            Console.WriteLine("No items in the order. Goodbye!");
        }
    }
}
