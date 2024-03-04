using System;

class Program
{
    static void Main(string[] args)
    {
        const int TENTATIVAS = 3;
        int contador = 1;

        do
        {
            System.Console.WriteLine("\nDigite seu nome de usuario:");
            string nomeDeUsuario = Console.ReadLine();

            System.Console.WriteLine("\nDigite sua senha:");
            string senha = Console.ReadLine();

            if(nomeDeUsuario == "admin" && senha == "123senha")
            {
                System.Console.WriteLine("\nLogin realizado com sucesso!");
                break;
            }
            else if(contador == TENTATIVAS)
            {
                System.Console.WriteLine("\nSua conta foi bloqueada...");
                break;
            }
            System.Console.WriteLine("\nLogin invalido! Tente novamente...");
            contador++;
        }
        while(contador <= TENTATIVAS);
    }
}