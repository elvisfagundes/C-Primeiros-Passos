using System;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int a, b;
            double cod1 = 4.00, cod2 = 4.50, cod3 = 5.00, cod4 = 2.00, cod5 = 1.50, c;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            switch (a) {
                case 1:
                c = cod1 * b;
                Console.WriteLine("Total: R$ " + c.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    c = cod2 * b;
                    Console.WriteLine("Total: R$ " + c.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    c = cod3 * b;
                    Console.WriteLine("Total: R$ " + c.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    c = cod4 * b;
                    Console.WriteLine("Total: R$ " + c.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    c = cod5 * b;
                    Console.WriteLine("Total: R$ " + c.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
        }    
    }
}