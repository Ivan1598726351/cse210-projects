using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Vukovarska","Zagreb","Zagreb","Croatia");
        Customer customer1= new Customer("Andrej",address1);
        Product product1= new Product("Bread",123,2,3);
        Product product2= new Product("Milk",091,1,2);
        Product product3=new Product("Soap",871,3,1);
        Order order1= new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total price: {order1.TotalPriceOrder()}$");
        Address address2 = new Address("Random street","Random city","County Random","USA");
        Customer customer2= new Customer("Melvin Harris",address2);
        Product product4= new Product("Hamburger",9,3,2);
        Product product5= new Product("Fries",6,2,1);
        Product product6=new Product("Chicken Nuggets",45,5,2);
        Order order2= new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total price: {order2.TotalPriceOrder()}$");
        
    }
}