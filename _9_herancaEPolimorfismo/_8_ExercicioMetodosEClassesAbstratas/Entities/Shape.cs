using _8_ExercicioMetodosEClassesAbstratas.Entities.Enums;
using System;

namespace _8_ExercicioMetodosEClassesAbstratas.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape (Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
