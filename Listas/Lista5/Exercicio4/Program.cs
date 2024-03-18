using System;

class Program
{
    static void Main(string[] args)
    {
        int somatorio = 0;

        while(true)
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor < 0)
            {
                break;
            }
            else if (valor % 2 == 1)
            {
            somatorio += valor;
            }
        }
        System.Console.WriteLine($"O somatorio de impares eh: {somatorio}");
    }
}