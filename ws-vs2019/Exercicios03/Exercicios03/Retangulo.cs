using System;

namespace Exercicios03
{
    class Retangulo
    {
        public double L, A;

        public double Area()
        {
            return L * A;
        }
        public double Perimetro()
        {
            return 2.0 * (L + A);
        }
        public double Diagonal()
        {
            return Math.Sqrt(L * L + A * A);
        }
    }
}
