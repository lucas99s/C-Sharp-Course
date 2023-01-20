using System;

namespace _6_Exercicio_4
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * Largura + 2 * Altura;
        }

        public double Diagonal()
        {
            double d = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
            return d;
        }

        public override string ToString()
        {
            return $"Área = {Area():F2}; Perímetro = {Perimetro():F2}; Diagonal = {Diagonal():F2}";
        }
    }
}
