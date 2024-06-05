using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.IO.Compression;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
      int z, soma;
      soma = 0;
      z = 10;
    // erro era o parametro z, sem inicializado ele ficaria em loop
      while ( z >= 0)
      {
         soma += z;
         Console.WriteLine(z);
         z--;

      }



  
     
    } // fim da main

} // fim do programa
