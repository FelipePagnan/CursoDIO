using ConsoleApp1.Models;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa();

        pessoa1.Nome = "Felipe";
        pessoa1.Idade = 23;

        pessoa1.Apresentar();

        //Declarando os tipos de variaveis
        string apresentacao = "Ola seja bem vindo";
        int quantidade = 1;
        double altura = 1.80;
        decimal preco = 1.80m;
        bool condicao = true;

        Console.WriteLine(apresentacao);
        Console.WriteLine("Valor da variavel quantidade: " + quantidade);
        Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
        Console.WriteLine("Valor da variavel preco: " + preco);
        Console.WriteLine("Valor da variavel condicao: " + condicao);

        Console.WriteLine("Valor da variavel quantidade: " + quantidade);
        quantidade = 20;
        Console.WriteLine("Valor da variavel quantidade: " + quantidade);


        //DateTime
        DateTime dataAtual = DateTime.Now.AddDays(5);
        Console.WriteLine(dataAtual);

        Console.ReadLine();
    }
}