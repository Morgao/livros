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
      // n 10 100 1000
      int n = 1;
         Console.Write("N");
         Console.Write("   N*10");
         Console.Write("   N*100");
         Console.Write("   N*1000\n");

      while (n <= 5)
      {
         Console.Write(n);
         Console.Write("    {0}",n*10);
         Console.Write("     {0}",n*100);
         Console.Write("     {0}\n",n*1000);
         n++;

      }

     
    } // fim da main

} // fim do programa
