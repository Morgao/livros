using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
 
      // localizar a primeira potencia de 2 maior do que 100

      int produto = 2;
      while ( produto <= 1000)
      {
         produto = 2 * produto;
      }
      Console.WriteLine(produto);
 
    }
}
