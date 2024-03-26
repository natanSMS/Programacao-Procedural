using System;

class Program
{
    static void Main(string[] args)
    {
        const int PESSOAS_QUANTIDADE = 10;
        string[] nomes = new string[PESSOAS_QUANTIDADE];

        for(int i = 0; i < PESSOAS_QUANTIDADE; i++)
        {
            nomes[i] = Console.ReadLine();
        }
        string nomeBuscado = Console.ReadLine();

        bool estaNoVetor = false;

        for(int i = 0; i < PESSOAS_QUANTIDADE; i++)
        {
            if(nomes[i] == nomeBuscado)
            {
                estaNoVetor = true;
                break;
            }
        }
        if(estaNoVetor)
        {
            System.Console.WriteLine("ACHEI");
        }
        else
        {
            System.Console.WriteLine("NAO ACHEI");
        }
    }
}