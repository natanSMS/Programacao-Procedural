using System;

class Program
{
    static void Main(string[] args)
    {
        const int MATRIZ_TAMANHO = 3;
        int[,] matriz = new int[MATRIZ_TAMANHO,MATRIZ_TAMANHO];

        for(int linha = 0; linha < MATRIZ_TAMANHO; linha++)
        {
            for(int coluna = 0; coluna < MATRIZ_TAMANHO; coluna++)
            {
                matriz[linha,coluna] = int.Parse(Console.ReadLine());
            }
        }
        int somatorioDiagonalPrincipal = 0;

        for(int linha = 0; linha < MATRIZ_TAMANHO; linha++)
        {
            for(int coluna = 0; coluna < MATRIZ_TAMANHO; coluna++)
            {
                if(linha == coluna)
                {
                    somatorioDiagonalPrincipal += matriz[linha,coluna];
                }
            }
        }
        System.Console.WriteLine(somatorioDiagonalPrincipal);
    }
}