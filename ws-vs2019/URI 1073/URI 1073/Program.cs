using System;

namespace URI_1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    soma = (int)Math.Pow(i, 2);
                    Console.WriteLine(i + "^2" + " = " + soma);
                }
            }
        }
    }
}
