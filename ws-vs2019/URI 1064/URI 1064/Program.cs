﻿using System;
using System.Globalization;

namespace URI_1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int valores = 0;
            double soma = 0.0;

            if (a > 0.0)
            {
                valores = valores + 1;
                soma = soma + a;

            if (b > 0.0)
            {
                valores = valores + 1;
                soma = soma + b;
            }
            if (c > 0.0)
            {
                valores = valores + 1;
                soma = soma + c;
            }
            if (d > 0.0)
            {
                valores = valores + 1;
                soma = soma + d;
            }
            if (e > 0.0)
            {
                valores = valores + 1;
                soma = soma + e;

            }
            if (f > 0.0)
            {
                valores = valores + 1;
                soma = soma + f;
            }

            Console.WriteLine(valores + " valores positivos");
            
            double media = soma / valores;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}