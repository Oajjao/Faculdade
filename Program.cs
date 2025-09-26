using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[7];

        // Entrada dos números
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros na ordem inversa:");

        // Exibindo na ordem inversa
        for (int i = 6; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
