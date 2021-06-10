using System;
using System.Globalization;

namespace URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, R, volume;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            volume = (double) (4.0 / 3.0) * pi * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
