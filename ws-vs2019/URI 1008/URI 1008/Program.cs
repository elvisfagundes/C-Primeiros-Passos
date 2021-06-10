using System;
using System.Globalization;

namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, h;
            double vhora, salario;

            n = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            vhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = h * vhora;

            Console.WriteLine("NUMBER = " + n);
            Console.WriteLine("SALARY = U$ "  + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
