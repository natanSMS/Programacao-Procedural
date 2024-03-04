using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("\nDigite a quantidade de itens comprados:");
        int QuantidadeDeItens = int.Parse(Console.ReadLine());
        int contador = 1;
        double somatorioValores = 0;

        while (contador <= QuantidadeDeItens)
        {
            System.Console.WriteLine("\nDigite o valor do " + contador + "º produto:");
            double valor = double.Parse(Console.ReadLine());

            somatorioValores += valor;
            contador++;
        }
        if(somatorioValores > 150)
        {
            System.Console.WriteLine("\nParabens! Voce ganhou frete gratis em sua compra de valor R$" + somatorioValores);
        }
        else
        {
            System.Console.WriteLine("\nA compra nao possui frete gratis...");
        }
    }
}