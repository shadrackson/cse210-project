using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
         // Order 1 (USA)
        Address address1 = new Address("123 Main Street", "Dallas", "Texas", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Laptop", "P100", 850.00, 1);
        Product product2 = new Product("Wireless Mouse", "P101", 25.00, 2);
        Product product3 = new Product("Keyboard", "P102", 45.00, 1);

        List<Product> products1 = new List<Product>
        {
            product1,
            product2,
            product3
        };

        Order order1 = new Order(customer1, products1);

        // Order 2 (International)
        Address address2 = new Address("45 Moi Avenue", "Mombasa", "Mombasa County", "Kenya");
        Customer customer2 = new Customer("Shadrack Onyango", address2);

        Product product4 = new Product("Phone", "P200", 400.00, 1);
        Product product5 = new Product("Phone Case", "P201", 15.00, 2);

        List<Product> products2 = new List<Product>
        {
            product4,
            product5
        };

        Order order2 = new Order(customer2, products2);

        // Display Order 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice()}");

        // Display Order 2
        Console.WriteLine("\n===== ORDER 2 =====");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice()}");
        
    }
}
