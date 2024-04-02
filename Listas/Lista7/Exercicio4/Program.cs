using System;

class Porgram
{
    static void Main(string[] args)
    {
        int[] vagoes = new int[12];

        PreencherVetor(vagoes);

        VerificarPesoDosVagoes(vagoes);
    }

    static void PreencherVetor(int[] vetor)
    {
        for(int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static void VerificarPesoDosVagoes(int[] vetor)
    {
        for(int i = 0; i < vetor.Length; i++)
        {
            if(vetor[i] > 50)
            {
                System.Console.WriteLine($"{i + 1}º vagao ultrapassou o limite de peso");
            }
        }
    }
}