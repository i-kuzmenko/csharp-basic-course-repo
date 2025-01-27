
using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop for entering details of three orders
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\nEntering details for Order {i}:\n");

                string customerName;
                string customerAddress;
                string productName;
                decimal price;

                Console.Write("Enter customer name: ");
                customerName = Console.ReadLine();

                Console.Write("Enter customer address: ");
                customerAddress = Console.ReadLine();

                Console.Write("Enter product name: ");
                productName = Console.ReadLine();

                Console.Write("Enter product price: ");
                price = decimal.Parse(Console.ReadLine());


                // Display order details immediately
                Console.WriteLine($"\nOrder NO {i}");
                Console.WriteLine($"Client: {customerName}.");
                Console.WriteLine($"Product: {productName}, price {price:C} EUR.");
                Console.WriteLine($"Address: {customerAddress}.");
            }

            Console.WriteLine("\nAll orders have been entered.");
        }
    }
}
