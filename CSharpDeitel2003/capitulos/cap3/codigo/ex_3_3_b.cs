using System;
namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {

            // primeiro if
            int a, b, c;

            Console.Write("Digite o primeiro Inteiro: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo Inteiro: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a * b;
            Console.Write(c);

           
                
        }
    }
}