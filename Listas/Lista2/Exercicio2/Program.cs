using System;

class Program
{
    static void Main(string[] args)
    {
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        double nota3 = double.Parse(Console.ReadLine());
        double nota4 = double.Parse(Console.ReadLine());

        double notaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

        if(notaFinal >= 5)
        {
            System.Console.WriteLine("Aluno aprovado");
        }
        else if(notaFinal < 5 && notaFinal >= 3)
        {
            System.Console.WriteLine("Aluno em recuperacao");
        }
        else
        {
            System.Console.WriteLine("Aluno reprovado");
        }
    }
}