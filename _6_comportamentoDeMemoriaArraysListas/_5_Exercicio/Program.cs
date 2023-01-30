using System;

namespace _5_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Rent[] Rooms = new Rent[10];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i+1}");
                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                Rooms[room] = new Rent { Name = nome, Email = email, Room = room };
            }

            Console.WriteLine();
            Console.WriteLine("Busy Rooms:");

            for(int i = 0; i < Rooms.Length; i++)
            {
                if(Rooms[i] != null)
                {
                    Console.WriteLine($"{Rooms[i].Room}: {Rooms[i].Name}, {Rooms[i].Email}");
                }
            }
        }
    }
}
