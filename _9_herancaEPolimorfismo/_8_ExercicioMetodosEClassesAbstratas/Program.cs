using System;
using System.Collections.Generic;
using _8_ExercicioMetodosEClassesAbstratas.Entities;
using _8_ExercicioMetodosEClassesAbstratas.Entities.Enums;

namespace _8_ExercicioMetodosEClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("How many shapes? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Shape type ((c)ircle, (r)ectangle): ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Shape color (Black, Blue, Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(shape == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }
                else if(shape == 'r')
                {
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(height, width, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}
