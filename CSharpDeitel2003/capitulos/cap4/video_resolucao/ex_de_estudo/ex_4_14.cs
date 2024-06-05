using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.IO.Compression;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
      
      int n;
      int a1,a2,a3,a4,a5;

      Console.WriteLine("digite um  numero de 5 alarismos: ");
      n = Int32.Parse(Console.ReadLine());

      while (n != 0)
      {

      
      if ((n>99999) || (n<10000) )
      {
         Console.WriteLine("error");
         Console.WriteLine("digite outro numero, agora com 5  digitos: ");
         n = Int32.Parse(Console.ReadLine());
      }
      else
      {
         Console.WriteLine("5 digitos");
         a1 = (n/10000);
         a2 = (n%10000)/1000;
         a3 = ((n%10000)%1000)/100;
         a4 = (((n%10000)%1000)%100)/10;
         a5 = ((((n%10000)%1000)%100)%10)/1;

         if((a1==a5)  && (a2==a4))
         {
            Console.WriteLine("o numero {0} é um palindromo",n);
            n = 0;
            Console.WriteLine("Fim do programa");
         }
         else
         {
            Console.WriteLine("o numero {0} //NÃO É // palindromo",n);
         }
      
      }
      

      }
      
      

     
    } // fim da main

} // fim do programa
