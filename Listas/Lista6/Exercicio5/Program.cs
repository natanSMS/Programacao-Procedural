using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMEROS_QUANTIDADE = 10;
        const int NUMERO_MINIMO = 10;
        const int NUMERO_MAXIMO = 50;

        int[] numeros = new int[NUMEROS_QUANTIDADE];

        int contador = 0;

        while(contador < NUMEROS_QUANTIDADE)
        {
            int numero = int.Parse(Console.ReadLine());

            if(numero >= NUMERO_MINIMO && numero <= NUMERO_MAXIMO)
            {
                numeros[contador] = numero;
                contador++;
            }
        }

        for(int i = 0; i < NUMEROS_QUANTIDADE; i++)
        {
            System.Console.WriteLine(numeros[i]);
        }
    }
}