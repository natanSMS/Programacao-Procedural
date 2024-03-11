using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        const int TAMANHO_TABULEIRO = 8;
        for(int coluna = 0; coluna < TAMANHO_TABULEIRO; coluna++)
        {
            for(int linha = 0; linha < TAMANHO_TABULEIRO; linha++)
            {
                if(coluna == 0 || coluna == 7 || linha == 0 || linha == 7)
                {
                    Tabuleiro.Adicionar(linha,coluna,"s");
                }
            }
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}