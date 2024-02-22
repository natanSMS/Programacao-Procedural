using System;

class program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Digite o valor da base do triângulo");

        double valorBase = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da altura do triângulo");

        double valorAltura = double.Parse(Console.ReadLine());

        double area = (valorBase * valorAltura) / 2;

        bool maiorQue20 = area > 20;

        Console.WriteLine("A área do triângulo é maior que 20? " + maiorQue20);
    }
}
