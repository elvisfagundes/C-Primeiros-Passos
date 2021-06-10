using System;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hora = Console.ReadLine().Split(' ');
            int inicio = int.Parse(hora[0]);
            int fim = int.Parse(hora[1]);
            int duracao;
            
            if (inicio < fim ){
                duracao = fim - inicio;
            }
            else
            {
                duracao = 24 - inicio + fim;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
