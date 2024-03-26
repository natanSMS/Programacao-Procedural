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

        for(int i = PESSOAS_QUANTIDADE - 1; i >= 0; i--)
        {
            if(i % 2 == 0)
            {
                System.Console.WriteLine(nomes[i]);
            }
        }
    }
}