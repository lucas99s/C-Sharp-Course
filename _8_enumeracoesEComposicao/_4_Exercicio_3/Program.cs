using System;
using _4_Exercicio_3.Entities;
using _4_Exercicio_3.Entities.Enums;

namespace _4_Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birth);

            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int q = int.Parse(Console.ReadLine());

            for(int i = 1; i <= q; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: $");
                double pPrice = double.Parse(Console.ReadLine());
                Product product = new Product(pName, pPrice);

                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(pQuantity, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}