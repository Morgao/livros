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
 
   
    int q, divisor, resto;
    q = 10;
    divisor =  3;
    // maneira 1
    q = resto = q % divisor;
    Console.WriteLine(q);
    // maneira 2
   q = resto = q - (q / divisor) * divisor ;
   Console.WriteLine(q);

      




  
     
    } // fim da main

} // fim do programa
