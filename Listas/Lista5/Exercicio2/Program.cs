using System;

class Program
{
    static void Main(string[] args)
    {
        const int FATOR_MINIMO = 1;
        const int FATOR_MAXIMO = 10;

        for(int fator1 = FATOR_MAXIMO; fator1 >= FATOR_MINIMO; fator1 --)
        {
            for(int fator2 = FATOR_MINIMO; fator2 <= FATOR_MAXIMO; fator2++)
            {
                System.Console.WriteLine($"{fator1} x {fator2} = {fator1 * fator2}");
            }
            System.Console.WriteLine();
        }
    }
}