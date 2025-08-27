using System;

class Program
{
    static void Main(string[] args)
    {
        string userName;    // nome de usuário para login
        int clientAge;      // idade do cliente
        decimal totalValue; // valor total

        // Atribuindo valores
        userName = "joao123";
        clientAge = 25;
        totalValue = 199.90m; // "m" indica que é um decimal

        // Exibindo no console
        Console.WriteLine("Nome de usuário: " + userName);
        Console.WriteLine("Idade do cliente: " + clientAge);
        Console.WriteLine("Valor total: R$ " + totalValue);
    }
}
