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
      // x  9 y 11 depois inverte
      int x, y;
      //x = 9;
      //y = 11;
       x = 11;
       y = 9;

      if(x<10)
      {
         if(y>10)
      {
         Console.WriteLine("*****");
      }
      }
      else
      {
         Console.WriteLine("#####");
         Console.WriteLine("$$$$$");
      }

      
      

     
    } // fim da main

} // fim do programa
