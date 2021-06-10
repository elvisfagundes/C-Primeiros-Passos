using System;
using System.Globalization;

namespace URI_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, kml;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            kml = x / y;

            Console.WriteLine(kml.ToString("F3", CultureInfo.InvariantCulture) + " kml");
        }
    }
}
