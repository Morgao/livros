using System;
using System.Globalization;

namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {

            // primeiro if
            int number1, number2, soma, produto, resto;

            Console.Write("Digite o primeiro Inteiro: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo Inteiro: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            soma = number1 + number2;
            produto = number1 * number2;
            resto = number1 % number2;
            Console.WriteLine("A soma dos numero é: ",soma);
            Console.WriteLine("O Produtodos numero é: ",produto);

            if ( number1 == number2)
                Console.WriteLine( number1 + " == " + number2 );
            if ( number1 != number2)
                Console.WriteLine( number1 + " != " + number2 );
            if ( number1 < number2)
                Console.WriteLine( number1 + " < " + number2 );
            if ( number1 > number2)
                Console.WriteLine( number1 + " > " + number2 );
            if ( number1 <= number2)
                Console.WriteLine( number1 + " <= " + number2 );
            if ( number1 >= number2)
                Console.WriteLine( number1 + " >= " + number2 );


            Console.WriteLine("O Quociente dos numeros é é: ", resto);
            
                
        }
    }
}