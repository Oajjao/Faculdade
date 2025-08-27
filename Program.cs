usingusing System;

class Program
{
    static void Main()
    {
        double a = 0.1;
        double b = 0.2;
        double c = 0.3;

        double soma = a + b;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("a + b = " + soma);

        // Comparação
        bool iguais = soma == c;
        Console.WriteLine("a + b == c ? " + iguais);
    }
}

