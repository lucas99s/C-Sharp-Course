using System;

namespace _2_CriandoUmaClasseParaRepresentarUmTriangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Perimetro()
        {
            return (A + B + C) / 2; ;
        }

        public double Area()
        {
            double p = Perimetro();
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
