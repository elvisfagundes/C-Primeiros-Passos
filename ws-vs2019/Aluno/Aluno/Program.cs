using System;
using System.Globalization;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aln = new Aluno();

            Console.Write("Nome do aluno: ");
            aln.NomeAluno = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aln.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aln.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aln.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("NOTA FINAL = " + aln.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aln.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aln.NotaR().ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
