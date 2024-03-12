using System;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        const int ALTURA_MINIMA = 1;
        const int ALTURA_MAXIMA = 9;
        System.Console.WriteLine("Digite uma altura de " + ALTURA_MINIMA + " a " + ALTURA_MAXIMA + ":");
        int altura = int.Parse(Console.ReadLine());
        while(altura < ALTURA_MINIMA || altura > ALTURA_MAXIMA)
        {
            System.Console.WriteLine("altura invalida, insira uma altura de " + ALTURA_MINIMA + " a " + ALTURA_MAXIMA);
            altura = int.Parse(Console.ReadLine());
        }
        for(int linha = 1; linha <= altura; linha++)
        {
            for(int numero = 1; numero <= linha; numero++)
            {
                System.Console.Write(numero);
            }
            System.Console.WriteLine();
        }
    }
}