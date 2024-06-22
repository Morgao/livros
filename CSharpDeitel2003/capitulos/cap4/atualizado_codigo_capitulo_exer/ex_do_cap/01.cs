using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
 
      int a;

      Console.WriteLine("Digite a Nota: ");
      a = Convert.ToInt32(Console.ReadLine());


      // operacao ternaria para express bool com valor de resposa pra veradeiro e falso
      Console.WriteLine(a >= 60 ? "Passou" : "Reprovou");

      /* usando dois if para faazer 2 comparacoes

      if (a >= 60)
      {
         Console.WriteLine("Passou");
      }
      
      if ( a < 60)
      {
         Console.WriteLine("Reprovou");
      }


     
      
      // usando if else para verdadeiro e falso

      if (a>= 60)
      {
         Console.WriteLine("Passou");
      }
      else
      {
         Console.WriteLine("Reprovou");
      }
      */
    }
}
