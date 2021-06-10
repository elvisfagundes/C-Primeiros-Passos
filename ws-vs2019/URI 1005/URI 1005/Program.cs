using System;
using System.Globalization;

namespace URI_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, media, p1 = 3.5, p2 = 7.5;

            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (x * p1 + y * p2) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
