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

            if ( x >= 90 )
            {
                Console.WriteLine( "A" );
            }
            else if ( x >=80 )
            {
                
                Console.WriteLine( "B" );
            }
            else if ( x >= 70)
            {
                
                Console.WriteLine( "C" );
            }
            else if ( x >= 60 )
            {
                
                Console.WriteLine( "D" );
            }
            else 
            {
                
                Console.WriteLine( "F" );
            }
            
                
        }
    }
}