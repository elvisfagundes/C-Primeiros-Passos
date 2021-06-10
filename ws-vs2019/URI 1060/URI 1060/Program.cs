using System;
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

            if (a > 0)
            {
                valores = valores + 1;
                if (b > 0)
                {
                    valores = valores + 1;
                }
                if (c > 0)
                {
                    valores = valores + 1;
                }
                if (d > 0)
                {
                    valores = valores + 1;
                }
                if (e > 0)
                {
                    valores = valores + 1;
                }
                if (f > 0)
                {
                    valores = valores + 1;
                }
            }

            Console.WriteLine(valores + " valores positivos");
        }
    }
}
