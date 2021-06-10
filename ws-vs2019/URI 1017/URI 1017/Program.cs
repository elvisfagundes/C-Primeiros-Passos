using System;
using System.Globalization;

namespace URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double total;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            total = (x * y) / (double)12;

            Console.WriteLine(total.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
