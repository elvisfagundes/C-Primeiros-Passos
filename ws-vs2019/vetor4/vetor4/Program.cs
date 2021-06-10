using System;
using System.Globalization;

namespace vetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] numeros = Console.ReadLine().Split(' ');
            double[] x = new double[n];

            for (int i = 0; i < n; i++)
            {
                x[i] = double.Parse(numeros[i], CultureInfo.InvariantCulture);
            }
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma = soma + x[i];
            }

            double mediaA = soma / n;
            Console.WriteLine(mediaA.ToString("F3", CultureInfo.InvariantCulture));

            foreach (double C in x)
            {
                if (mediaA >= C)
                {
                    mediaA = C;
                    Console.WriteLine(mediaA.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        } 
    } 
}
