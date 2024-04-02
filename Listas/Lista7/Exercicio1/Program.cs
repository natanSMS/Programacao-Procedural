using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());

        System.Console.WriteLine(VerificarSeEhPar(numero));
    }

    static bool VerificarSeEhPar(int numero)
    {
        if(numero % 2 == 0)
        {
            return true;
        }
        return false;
    }
}