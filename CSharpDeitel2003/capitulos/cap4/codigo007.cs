using System.Reflection.Metadata.Ecma335;
using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {
          
          int numeroAprovados, numeroReprovados, numeroTotalDeAlunos, contador, resultadoExame;

            numeroAprovados = 0;
            numeroReprovados = 0;
            numeroTotalDeAlunos = 1;

            while ( numeroTotalDeAlunos <= 10 )
            {
                Console.Write( "Digite o resultado do Exame: (1=Aprovadp|2=Reprovado) " );
                resultadoExame = Int32.Parse(Console.ReadLine());
                if ( resultadoExame == 1 ) 
                {
                    numeroAprovados = numeroAprovados + 1;
                }
                else
                {
                    numeroReprovados = numeroReprovados +1;
                }
                numeroTotalDeAlunos = numeroTotalDeAlunos +1;
            }

            Console.WriteLine("\nNumero de Aprovado: {0}",numeroAprovados);
            Console.WriteLine("Numero de Reprovados: {0}",numeroReprovados);
            if ( numeroAprovados >= 8 )
            {
                Console.WriteLine("Aumentar o preço do curso");
            }
           
          
    
            
                
        }
    }
}