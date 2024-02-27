using System;

class Program
{
    static void Main(string[] args)
    {
        string nome = Console.ReadLine();

        string senha = Console.ReadLine();

        if(nome == "admin" && senha == "123senha")
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais invalidas...");
        }
    }
}