using System;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite uma altura de 1 a 9:");
        int altura = int.Parse(Console.ReadLine());
        while(altura < 1 || altura > 9)
        {
            System.Console.WriteLine("altura invalida, insira uma altura de 1 a 9");
            altura = int.Parse(Console.ReadLine());
        }
        int coluna = 1;
        for(int linha = 1; linha <= altura; linha++)
        {
            while(coluna <= linha)
            {
                for(int numero = 1; numero <= coluna; numero++)
                {
                    System.Console.Write(numero);
                }
                coluna++;
            }
            System.Console.WriteLine();
        }
    }
}