using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {
          
          double x;
          Console.WriteLine("Digite a nota: ");
          x = Convert.ToDouble(Console.ReadLine());

          if ( x >= 60)
          {
            Console.WriteLine("Passou");
          }
          else
          {
            Console.WriteLine("Reprovou");
          }
                 
            
                
        }
    }
}