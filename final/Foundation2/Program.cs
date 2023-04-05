using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address1 = new Address("371 Pinetree Rd.","Rexburg","Idaho","USA");
        Customer customer1 = new Customer("Stan Crittenden",address1);

        List<Product> products1 = new List<Product>()
        {
            new Product("Bananas","BAN6",4.99,1),
            new Product("Chocolate Shell Topping","CHOCT1",3.99,1)
        };

        Order order1 = new Order(products1,customer1);
        Console.WriteLine(order1.GetShippingLabel());
        order1.GetPackingLabel();
        Console.WriteLine($"Total: {order1.SetOrderTotal()}");
        Console.WriteLine();

        Address address2 = new Address("201 Baker St.", "London","England","UK");
        Customer customer2 = new Customer("Basil of Baker Street",address2);

        List<Product> products2 = new List<Product>()
        {
            new Product("Cheese Crumpet Mix","CRU1",5.99,1),
            new Product("Iced Tea","ITEA1",4.99,1)
        };

        Order order2 = new Order(products2,customer2);
        Console.WriteLine(order2.GetShippingLabel());
        order2.GetPackingLabel();
        Console.WriteLine($"Total: {order2.SetOrderTotal()}");
        Console.WriteLine();
    }
}