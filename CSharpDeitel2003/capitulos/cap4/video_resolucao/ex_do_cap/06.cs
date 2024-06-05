using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
 
      // varaiaveis
      int passou, // numero de aprovados
            reprovou, // numero de reprovados
            quantidadeDeEstudantes, // quantidade de alunos
            resultado; // resultado do exame

            passou = 0;
            reprovou = 0;
            quantidadeDeEstudantes  = 1;
            

      // processa 10 alunos, laco controlado por contador
      while (quantidadeDeEstudantes <= 10) 
      {
         Console.WriteLine("Digite o resultado | 1 para aprovado | 2 para reprovado  ");
         resultado = Int32.Parse(Console.ReadLine());

            if (resultado == 1)
            {
               passou = passou + 1;
            }
            else
            // caso digite  qualquer coisa diferente de 1, ele entra no else, se fossse comparar com 2, 
            //não teria a 
            // execao de outro valor digitado  como incorrreto e uma mensagem de erro
            {
               reprovou = reprovou + 1;
            }
         quantidadeDeEstudantes = quantidadeDeEstudantes + 1;      

      }

      // fase de conclusao
      Console.WriteLine();
      Console.WriteLine("Aprovados: "+ passou);
      Console.WriteLine("Reprovados: "+ reprovou);

         if (passou > 8)
         {
            Console.WriteLine("Aumentar  preço do curso ");
         }
      




  
     
    } // fim da main

} // fim do programa
