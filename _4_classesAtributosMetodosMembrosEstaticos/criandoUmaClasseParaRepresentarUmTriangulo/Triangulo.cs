using System;

namespace _2_CriandoUmaClasseParaRepresentarUmTriangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Perimetro(double a, double b, double c)
        {
            double perimetro = (a + b + c) / 2;
            return perimetro;
        }

        public double Area(double a, double b, double c)
        {
            double p = Perimetro(a, b, c);
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
