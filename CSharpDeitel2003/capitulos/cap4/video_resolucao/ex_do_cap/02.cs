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

      // elsei if identado variacas comparacoes

      if (a >= 90)
      {
         Console.WriteLine("A");
      }
      else if (a>=80)
      {
         Console.WriteLine("B");
      }
      else if (a>=70)
      {
         Console.WriteLine("C");
      }
      else if (a>=60)
      {
         Console.WriteLine("D");
      }
      else 
      {
         Console.WriteLine("F");
      }
 
    }
}
