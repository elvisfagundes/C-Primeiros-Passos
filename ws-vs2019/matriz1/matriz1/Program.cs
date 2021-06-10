using System;

namespace matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, C;
            string[] s = Console.ReadLine().Split(' ');
            L = int.Parse(s[0]);
            C = int.Parse(s[1]);
            int[,] matriz = new int[L, C];

            for (int i = 0; i < L; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        int negativos = matriz[i, j];
                        Console.WriteLine(negativos);
                    }
                }
            }
        }
    }
}
