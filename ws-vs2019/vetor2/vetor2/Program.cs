using System;

namespace vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pares = 0;
            string[] x = Console.ReadLine().Split(' ');
            int[] numeros = new int[n];
            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(x[i]);
            }
            foreach (int D in numeros)
            {
                if (D % 2 == 0)
                {
                    pares++;
                    Console.Write(D + " ");                    
                }                
            }
            Console.WriteLine();
            Console.WriteLine(pares);
        }
    }
}
