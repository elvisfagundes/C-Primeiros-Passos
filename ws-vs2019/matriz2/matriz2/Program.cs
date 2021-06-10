using System;

namespace matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());
            int[,] mat = new int[Q, Q];
;
            for (int i = 0; i < Q; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < Q; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            for (int i = 0; i < Q; i++)
            {
                int soma = 0;
                for (int j = 0; j < Q; j++)
                {
                    soma = soma + mat[i, j];
                }
                Console.WriteLine(soma);
            }
        }
    }
}
