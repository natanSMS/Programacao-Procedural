using System;

class Program
{
    static void Main(string [] args)
    {
        const int NUMERO_MINIMO = 0;
        const int NUMERO_MAXIMO_UM = 100;
        const int NUMERO_MAXIMO_DOIS = 200;

        for(int contador1 = NUMERO_MINIMO; contador1 <= NUMERO_MAXIMO_UM; contador1 += 2)
        {
            int contador2 = NUMERO_MAXIMO_DOIS;

            System.Console.WriteLine($"{contador1} - {contador2 - contador1 * 2}");
        }
    }
}