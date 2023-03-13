using _8_ExercicioMetodosEClassesAbstratas.Entities.Enums;
using System;

namespace _8_ExercicioMetodosEClassesAbstratas.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double height, double width, Color color) : base(color)
        {
            Height = height;
            Width = width;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
