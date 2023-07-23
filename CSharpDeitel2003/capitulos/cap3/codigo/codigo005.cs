using System;
namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {

            // primeiro if
            int number1, number2;

            Console.Write("Digite o primeiro Inteiro: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo Inteiro: ");
            number2 = Convert.ToInt32(Console.ReadLine());

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
                
        }
    }
}