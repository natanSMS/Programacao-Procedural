using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        const int NUMERO_MINIMO = 0;
        const int TABULEIRO_TAMANHO = 8;

        for(int linha = NUMERO_MINIMO; linha < TABULEIRO_TAMANHO; linha++)
        {
            for(int coluna = NUMERO_MINIMO; coluna < TABULEIRO_TAMANHO; coluna++)
            {
                if(linha % 2 == 0)
                {
                    Tabuleiro.Adicionar(linha,coluna,"C");
                }
            }
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}