using System;
using System.Globalization;

namespace vetor5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] x = Console.ReadLine().Split(' ');
            int[] A = new int[N];
            int pares = 0;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(x[i]);
                if (A[i]% 2 == 0)
                {
                    pares = pares + A[i];
                    count++;
                }
            }
            int mediaA = pares / count;
            Console.WriteLine(mediaA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
