using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {

            
            // conversao forcada conversao implicita e unicode
            Console.WriteLine("O caracter " + 'A' +  "tem o valor"+ (int) 'A');
            Console.WriteLine("O caracter " + 'B' +  "tem o valor"+ (int) 'B');
            Console.WriteLine("O caracter " + 'C' +  "tem o valor"+ (int) 'C');
            Console.WriteLine("O caracter " + 'a' +  "tem o valor"+ (int) 'a');
            Console.WriteLine("O caracter " + 'b' +  "tem o valor"+ (int) 'b');
            Console.WriteLine("O caracter " + 'c' +  "tem o valor"+ (int) 'c');
            Console.WriteLine("O caracter " + '0' +  "tem o valor"+ (int) '0');
            Console.WriteLine("O caracter " + '1' +  "tem o valor"+ (int) '1');
            Console.WriteLine("O caracter " + '2' +  "tem o valor"+ (int) '2');
            Console.WriteLine("O caracter " + '$' +  "tem o valor"+ (int) '$');
            Console.WriteLine("O caracter " + '*' +  "tem o valor"+ (int) '*');
            Console.WriteLine("O caracter " + '+' +  "tem o valor"+ (int) '+');
            Console.WriteLine("O caracter " + '/' +  "tem o valor"+ (int) '/');
            Console.WriteLine("O caracter " + ' ' +  "tem o valor"+ (int) ' ');
                 
            
                
        }
    }
}