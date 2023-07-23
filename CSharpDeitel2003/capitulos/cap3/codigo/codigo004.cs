using System;
namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {
            string fisrtNumber, secondNumber;
            int number1, number2, sum;

            Console.WriteLine("Digite o primeiro Inteiro: ");
            fisrtNumber = Console.ReadLine();
            Console.WriteLine("Digite o segundo Inteiro: ");
            secondNumber = Console.ReadLine();

            number1 = Int32.Parse(fisrtNumber);
            number2 = Int32.Parse(secondNumber);

            sum = number1 + number2;

            Console.WriteLine("\nA soma é {0}.", sum);
        }
    }
}