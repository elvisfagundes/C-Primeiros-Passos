using System;

namespace URI_1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

        if (numero > 0 && numero % 2 == 0)
            {
                numero = numero + 1;
            }

            Console.WriteLine(numero);
            Console.WriteLine(numero + 2);
            Console.WriteLine(numero + 4);
            Console.WriteLine(numero + 6);
            Console.WriteLine(numero + 8);
            Console.WriteLine(numero + 10);
            

        }
    }
}
