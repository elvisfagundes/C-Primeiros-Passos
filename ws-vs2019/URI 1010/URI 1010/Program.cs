using System;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codp1, npec1, codp2, npec2;
            double v1, v2, total;

            string[] vet = Console.ReadLine().Split(' ');
            codp1 = int.Parse(vet[0]);
            npec1 = int.Parse(vet[1]);
            v1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet1 = Console.ReadLine().Split(' ');
            codp2 = int.Parse(vet1[0]);
            npec2 = int.Parse(vet1[1]);
            v2 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            total = (npec1 * v1) + (npec2 * v2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
