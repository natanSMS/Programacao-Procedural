using System;

class Program
{
    static void Main(string[] args)
    {
        const int RESPONDENTES_MAXIMO = 20;
        double somatorioSalarios = 0;
        int somatorioFilhos = 0;
        double maiorSalario = 0;

        for(int i = 1; i <= RESPONDENTES_MAXIMO; i++)
        {
            System.Console.WriteLine("\nDigite seu salario:");
            double salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("\nDigite a quantidade de filhos que voce tem:");
            int numeroDeFilhos = int.Parse(Console.ReadLine());

            somatorioSalarios += salario;

            somatorioFilhos += numeroDeFilhos;

            if(salario > maiorSalario)
            {
                maiorSalario = salario;
            }
        }
        System.Console.WriteLine("\nMedia salarial = R$" + Math.Round(somatorioSalarios / RESPONDENTES_MAXIMO,2));
        System.Console.WriteLine("Media do numero de filhos por habitante = " + somatorioFilhos / RESPONDENTES_MAXIMO);
        System.Console.WriteLine("Maior salario = R$" + maiorSalario);
    }
}