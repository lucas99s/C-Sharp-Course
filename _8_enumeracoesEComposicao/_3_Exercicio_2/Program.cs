using System;
using _3_Exercicio_2.Entities;

namespace _3_Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Amazing!");
            Comment c2 = new Comment("I want to go too!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travaling to New Zealand",
                "I'm going to visit my mother land",
                12
            );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Yeah, see u soon!");

            Post p2 = new Post(
                DateTime.Parse("22/06/2018 13:32:12"),
                "Good morning everyone",
                "Time to have fun!",
                12
            );
            p2.AddComment(c3);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
