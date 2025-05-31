using System;

class Program
{
    static void Main()
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address1 = new Address("575  Summerwood Drive", "Oklahoma", "OK", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Address address2 = new Address("474 Moose Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maria Garcia", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "NB101", 3.99, 5));
        order1.AddProduct(new Product("Pen", "P204", 1.50, 10));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Stapler", "ST33", 7.50, 2));
        order2.AddProduct(new Product("Paper", "PP10", 0.10, 500));

        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
    }
}
