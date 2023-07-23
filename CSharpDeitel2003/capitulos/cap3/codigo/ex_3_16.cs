using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {

            int n, dez, mil, cem, dez2, uni;
            Console.WriteLine("Digite o numero de 5 digitos: ");
            n = Convert.ToInt32(Console.ReadLine());

            // como o numero é obrigado a ter 5 algarismos, inicia a decomposicao dividindo por 10.000
            // nao funciona
            // para mais ou menos algarismos que 5.

            dez = n / 10000;
            mil = (n % 10000) / 1000;
            cem = ((n %1000) % 1000) / 100;
            dez2 = (((n%10000)%1000)%100)/10;
            uni = ((((n%10000)%1000)%100)%10)/1;
            Console.WriteLine("{0}   {1}   {2}   {3}   {4}", dez, mil, cem, dez2, uni);
            
                 
            
                
        }
    }
}