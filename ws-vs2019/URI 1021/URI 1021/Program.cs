using System;
using System.Globalization;



namespace URI_1021

{

    class Program

    {

        static void Main(string[] args)

        {
            double calculo, mod, cedula, moeda;
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("NOTAS:");

            cedula = 100.0;
            calculo = N / cedula;
            Console.WriteLine((int)calculo + " nota(s) de R$ " + cedula.ToString("f2", CultureInfo.InvariantCulture));
            mod = N % cedula;

            cedula = 50.0;
            calculo = mod / cedula;
            Console.WriteLine((int)calculo + " nota(s) de R$ " + cedula.ToString("f2", CultureInfo.InvariantCulture));
            mod = mod % cedula;

            cedula = 20.0;
            calculo = mod / cedula;
            Console.WriteLine((int)calculo + " nota(s) de R$ " + cedula.ToString("f2", CultureInfo.InvariantCulture));
            mod = mod % cedula;

            cedula = 10.0;
            calculo = mod / cedula;
            Console.WriteLine((int)calculo + " nota(s) de R$ " + cedula.ToString("f2", CultureInfo.InvariantCulture));
            mod = mod % cedula;

            cedula = 5.0;
            calculo = mod / cedula;
            Console.WriteLine((int)calculo + " nota(s) de R$ " + cedula.ToString("f2", CultureInfo.InvariantCulture));
            mod = mod % cedula;

            cedula = 2.0;
            calculo = mod / cedula;
            Console.WriteLine((int)calculo + " nota(s) de R$ " + cedula.ToString("f2", CultureInfo.InvariantCulture));
            mod = mod % cedula;

            Console.WriteLine("MOEDAS:");

            moeda = 1.0;
            calculo = mod / moeda;
            Console.WriteLine((int)calculo + " moeda(s) de R$ " + moeda.ToString("f2", CultureInfo.InvariantCulture));
            mod = mod % moeda;

            moeda = 0.50;
            calculo = mod / moeda;
            Console.WriteLine((int)calculo + " moeda(s) de R$ " + moeda.ToString("f2", CultureInfo.InvariantCulture));
            mod = mod % moeda;

            moeda = 0.25;
            calculo = mod / moeda;
            Console.WriteLine((int)calculo + " moeda(s) de R$ " + moeda.ToString("f2", CultureInfo.InvariantCulture));
            mod = mod % moeda;

            moeda = 0.10;
            calculo = mod / moeda;
            Console.WriteLine((int)calculo + " moeda(s) de R$ " + moeda.ToString("f2", CultureInfo.InvariantCulture));
            mod = mod % moeda;

            moeda = 0.05;
            calculo = mod / moeda;
            Console.WriteLine((int)calculo + " moeda(s) de R$ " + moeda.ToString("f2", CultureInfo.InvariantCulture));
            mod = mod % moeda;

            moeda = 0.01;
            calculo = mod / moeda;
            Console.WriteLine(calculo.ToString("f0", CultureInfo.InvariantCulture) + " moeda(s) de R$ " + moeda.ToString("f2", CultureInfo.InvariantCulture));
        }

    }

}