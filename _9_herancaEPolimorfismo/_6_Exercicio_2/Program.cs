using _6_Exercicio_2.Entities;
using System;
using System.Collections.Generic;

namespace _6_Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            List<Product> products = new List<Product>();
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for(int i = 1; i <= p; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                } 
                else if(productType == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customFee));
                } 
                else if(productType == 'c')
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(var product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
