using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 4;
        Produto[] produtos = new Produto[TAMANHO_VETOR];

        for (int i = 0; i < produtos.Length; i++)
        {
            produtos[i].id = int.Parse(Console.ReadLine());
            produtos[i].nome = Console.ReadLine();
            produtos[i].preco = double.Parse(Console.ReadLine());
            produtos[i].disponivelEmEstoque = bool.Parse(Console.ReadLine());
        }

        for(int i = 0; i < produtos.Length; i++)
        {
            if(produtos[i].disponivelEmEstoque)
            {
                System.Console.WriteLine(produtos[i].nome);
                System.Console.WriteLine(produtos[i].preco);
            }
        }
    }
}