using System;

class Program
{
    static void Main(string[] args)
    {
        int numero1 = int.Parse(Console.ReadLine());
        int numero2 = int.Parse(Console.ReadLine());
        int numero3 = int.Parse(Console.ReadLine());

        System.Console.WriteLine(RetornarMaior(numero1,numero2,numero3));
    }

    static int RetornarMaior(int num1, int num2, int num3)
    {
        const int TAMANHO_VETOR = 3;
        int[] vetor = new int[TAMANHO_VETOR];

        vetor[0] = num1;
        vetor[1] = num2;
        vetor[2] = num3;

        int maiorNumero = num1;

        for(int i = 0; i < TAMANHO_VETOR; i++)
        {
            if(vetor[i] > maiorNumero)
            {
                maiorNumero = vetor[i];
            }
        }

        return maiorNumero;
    }
}