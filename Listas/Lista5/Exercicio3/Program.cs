using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_MINIMO = 0;
        int alturaRetangulo = int.Parse(Console.ReadLine());
        int baseRetangulo = int.Parse(Console.ReadLine());

        for(int linha = NUMERO_MINIMO; linha < alturaRetangulo; linha++)
        {
            for(int coluna = NUMERO_MINIMO; coluna < baseRetangulo; coluna++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}