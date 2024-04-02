using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ,TAMANHO_MATRIZ];

        PreencherMatriz(matriz);

        if(VerificarBalistas(matriz))
        {
            System.Console.WriteLine("Fique atento! Existem balistas no tabuleiro");
        }
        else
        {
            System.Console.WriteLine("Nao ha balistas no tabuleiro");
        }
    }

    static void PreencherMatriz(int[,] matriz)
    {
        const  int TAMANHO_MATRIZ = 4;

        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                matriz[linha,coluna] = int.Parse(Console.ReadLine());
            }
        }
    }

    static bool VerificarBalistas(int[,] matriz)
    {
        const  int TAMANHO_MATRIZ = 4;

        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                if(matriz[linha,coluna] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
}