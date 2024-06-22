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
 
   
   int c, produto;
   c = 1;
   produto = 0;

   while (c <= 5)
   {
      produto *= c;
      Console.WriteLine(c);
      ++c;
   }
      




  
     
    } // fim da main

} // fim do programa
