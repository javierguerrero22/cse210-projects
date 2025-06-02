using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("5 El silencio St", "Maturín", "Monagas", "Venezuela");

        Customer customer1 = new Customer("Maria López", address1);
        Customer customer2 = new Customer("Javier Guerrero", address2);

        Product product1 = new Product("Laptop", "A100", 1200, 1);
        Product product2 = new Product("Mouse", "B200", 25, 2);
        Product product3 = new Product("Keyboard", "C300", 60, 1);

        List<Product> order1Products = new List<Product>() { product1, product3 };
        List<Product> order2Products = new List<Product>() { product2, product3 };

        Order order1 = new Order(order1Products, customer1);
        Order order2 = new Order(order2Products, customer2);

        Console.WriteLine($"Total Price for Order 1: {order1.GetTotalPrice()} USD");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine();

        Console.WriteLine($"Total Price for Order 2: {order2.GetTotalPrice()} USD");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
    }
}