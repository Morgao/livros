using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {

            // primeiro if
            
            double raio, diametro, circun, area, pi;
            pi = 3.14;

            Console.Write("Digite o primeiro Inteiro: ");
            raio = Convert.ToInt32(Console.ReadLine());

            diametro = 2 * raio;
            circun = (2 * pi) * raio;
            area = pi * (raio*raio);
            
            Console.WriteLine("Diametro: {0}", diametro);
            Console.WriteLine("Circunferencia: {0}", circun);
            Console.WriteLine("Area: {0}", area);

            
                
        }
    }
}