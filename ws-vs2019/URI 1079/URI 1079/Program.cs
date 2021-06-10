using System;
using System.Globalization;

namespace URI_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
             
            for (int i = 0; i < n; i++){
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);
                double mediaP = (a * 2.0 + b * 3.0 + c * 5.0) / 10;
                Console.WriteLine(mediaP.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
