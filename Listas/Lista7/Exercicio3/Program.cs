using System;

class Program
{
    static void Main(string[] args)
    {
        int idade = int.Parse(Console.ReadLine());

        ClassificarNadador(idade);
    }

    static void ClassificarNadador(int idade)
    {
        if(idade < 12)
        {
            System.Console.WriteLine("Infantil");
        }
        else if(idade < 15)
        {
            System.Console.WriteLine("Juvenil A");
        }
        else if(idade < 18)
        {
            System.Console.WriteLine("Juvenil B");
        }
        else
        {
            System.Console.WriteLine("Adulto");
        }
    }
}