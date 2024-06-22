using System.Reflection.Metadata.Ecma335;
using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {
          
            int total, numeronotas, valornota, media;

            total = 0;
            numeronotas = 1;

            while ( numeronotas <= 10)
            {
                Console.Write("Digite a nota: ");
                valornota = Int32.Parse(Console.ReadLine());

                total = total + valornota;
                numeronotas = numeronotas +1;
            }

            media = total / 10;

            Console.WriteLine("\n Media da Classe" + media);
           
            
                
        }
    }
}