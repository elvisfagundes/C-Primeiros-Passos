using System;
using System.Globalization;

namespace URI_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, media, p1 = 2, p2 = 3, p3 = 5, z;

            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (x * p1 + y * p2 + z * p3) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
