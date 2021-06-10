using System;
using System.Globalization;

namespace URI_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159, raio, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            

        }
    }
}
