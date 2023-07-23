using System.Reflection.Metadata.Ecma335;
using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {
          
           // flag para terminar um loop while
           // setinela

           int total, numeroNota, valorNota;
           
           double media;

           total = 0;
           numeroNota = 0;

           Console.Write("Digite um numero de nota, -1 Para Sair: ");
           valorNota = Int32.Parse(Console.ReadLine());

           while ( valorNota != -1 )
           {

            total = total + valorNota;

            numeroNota = numeroNota + 1;

            Console.Write("Digite um numero de nota, -1 Para Sair: ");
            valorNota = Int32.Parse(Console.ReadLine());

           }

           if ( numeroNota != 0 )
           {
             media = (double)total/numeroNota;

             Console.WriteLine("\n Media da CLasse é {0}",media);

           }
           else 
           {
                Console.WriteLine("Sem Notas Inseridas.");

           }
    
            
                
        }
    }
}