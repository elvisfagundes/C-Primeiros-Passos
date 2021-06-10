using System;

namespace vetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numeros = Console.ReadLine().Split(' ');
            string[] numeros2 = Console.ReadLine().Split(' ');

            int[] a = new int[n];
            int[] b = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(numeros[i]);
                b[i] = int.Parse(numeros2[i]);
            }
            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma = a[i] + b[i];
                Console.Write(soma + " ");
            }            
        }
    }
}
