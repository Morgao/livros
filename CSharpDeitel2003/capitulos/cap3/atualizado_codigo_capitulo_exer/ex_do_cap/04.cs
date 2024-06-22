using System;

class Program
{
    static void Main(string[] args)
    {
            // programa para somar 2 numeros inteiros
        string primeiroNumero, segundoNumero;

        int primeiro, segundo, soma;

        Console.WriteLine("Digite o primeiro Número: ");
        primeiroNumero = Console.ReadLine();

        Console.WriteLine("Digite o segundo Número: ");
        segundoNumero = Console.ReadLine();


        primeiro = Int32.Parse((primeiroNumero));
        segundo = Int32.Parse((segundoNumero));

        soma = primeiro + segundo;

        Console.WriteLine("\n A soma é {0} ", soma);

    }
}
