using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {

            

            int n1, n2, resto;
            Console.WriteLine("Digite o primerio numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

                resto = n1 % n2;
                if ( resto == 0)
                {
                    Console.WriteLine("O numero {0} é multiplo de {1}", n2,n1);
                }
                else 
                {
                    Console.WriteLine("O numero {0} não é multiplo de {1}",n2,n1);
                }

                 
            
                
        }
    }
}