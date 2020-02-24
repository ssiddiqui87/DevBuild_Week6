using System;
using System.Collections.Generic;

namespace POS_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Good Burger, home of the Good Burger!");
            //Product products = new Product();
            Inventory inv = new Inventory();

            List<Product> products = new List<Product>();
            products.Add(new Product("Good Burger", "Food", "9001 calories", 17.99));
            products.Add(new Product("Good Burger 2", "Food", "9001 calories", 17.99));
            products.Add(new Product("Good Burger 3", "Food", "9001 calories", 17.99));
            products.Add(new Product("Good Burger 4", "Food", "9001 calories", 17.99));
            products.Add(new Product("Good Burger 5", "Food", "9001 calories", 17.99));

            foreach (Product p in products)
            {
                inv.AddProduct(p.Name, 120);

            }
            foreach (Product product in products)
            {
                Console.WriteLine(product);
                Console.WriteLine("Quantity: " + inv.Quantity);


            }

            Console.Write("Can I take your order? ");
            string input = Console.ReadLine();

            Console.Write("How many do you want to buy? ");
            int num = int.Parse(Console.ReadLine());
            int subTotal = 0;
            for (int i = 0; i < num; i++)
            {
                //subTotal += products.
            }

            inv.RemoveProduct(input, num);

            Console.WriteLine(inv);

        }
    }
}
