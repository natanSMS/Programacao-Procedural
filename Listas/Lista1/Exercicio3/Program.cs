using System;

class program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Digite a quantidade de centavos");

        int totalCentavos = int.Parse(Console.ReadLine());

        int reais = totalCentavos / 100;

        int centavos = totalCentavos % 100;

        Console.WriteLine("O total em dinheiro é: " + reais + " real(is) e " + centavos + " centavo(s) ");
    }
}