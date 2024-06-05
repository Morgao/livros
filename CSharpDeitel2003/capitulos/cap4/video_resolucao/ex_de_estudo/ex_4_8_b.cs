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
 
   
   int genero = 1;

   if (genero == 1)
   {
      Console.WriteLine("Feminino");
   }
   else
   // erro era o ; depois do else, assim ele nao exibiria masculino se fosse diferente de 1
   {
      Console.WriteLine("Masculino");
   }
      




  
     
    } // fim da main

} // fim do programa
