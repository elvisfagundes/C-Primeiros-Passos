using System;

namespace URI_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int soma = 0;

            for (int i = 0; i > a; i++)
            {
                vet = Console.ReadLine().Split(' ');
                a = int.Parse(vet[0]);
                b = int.Parse(vet[1]);
                int soma = a + b;

                if (b > a)
                {
                    soma = a + b;              
                }
            }
            Console.WriteLine(i + "Sum=" + soma);
        }
    }
}
