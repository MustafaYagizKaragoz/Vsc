using System;
using System.Collections.Generic;
using EnginDemirogOrnek1;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        Product product1 = new Product();
        product1.price = 10;
        product1.name = "Elma";
        product1.id = "1";

        Product product2 = new Product();
        product2.price = 20;
        product2.name = "Karpuz";
        product2.id = "2";

        Product product3 = new Product();
        product3.price = 30;
        product3.name = "Kavun";
        product3.id = "3";

        products.Add(product1);
        products.Add(product2);
        products.Add(product3);

        Console.WriteLine("Foreach ile");
        foreach (var product in products)
        {
            Console.WriteLine(product.name);
            Console.WriteLine(product.price);
            Console.WriteLine(product.id);
        }
        
        Console.WriteLine("For ile");

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(products[i].name);
            Console.WriteLine(products[i].price);
            Console.WriteLine(products[i].id);
        }

        Console.WriteLine("While ile");
        int j = 0;
        while (j < products.Count)
        {
            Console.WriteLine(products[j].name);
            Console.WriteLine(products[j].price);
            Console.WriteLine(products[j].id);
            j++;
        }



    }
}