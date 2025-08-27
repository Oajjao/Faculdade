using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string nome = "João";           //o aquivo string precisa de "" em vez de ''
        float valorProduto = 29.99f;    //valores decimais precisao ser float em vez de int e também adicionar o f no final
        char resposta = 'S';            //o aquivo char precisa de '' em vez de ""

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Valor do produto: {valorProduto}");
        Console.WriteLine($"Resposta: {resposta}");
        Console.WriteLine("\n");
    }
}
