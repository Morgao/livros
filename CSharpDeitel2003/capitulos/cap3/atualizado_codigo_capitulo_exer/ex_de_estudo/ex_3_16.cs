using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
 
      //42339
      // 5 digitos

      int num;
      int a,b,c,d,e;
      

      Console.WriteLine("digite o primeiro numero: ");
      num = Int32.Parse(Console.ReadLine());
   // 43333/10000 = 4 resto 3333
      a = num / 10000;
      
    
      
      
      b = (num - (a * 10000) ) / 1000;
    

      c = (num -(a * 10000) - (b*1000)) / 100;
     

      d = (num -(a * 10000) - (b*1000) - (c*100)) / 10;
      

      e = (num -(a * 10000) - (b*1000) - (c*100) -  (d*10)) / 1;
      

     Console.WriteLine("  " + a + "  " + b + "  " + c + "  " + d + "  " + e);
     
      


    // a1 // 5321 / 1000 = 5  5 e divisao exata por 1000
      // resultado de a * 1000 - numero digitado vai sobrar 321
    //  a2// 321 / 100 = 3  3 e divisao exata por 100
      // resultado  a * 1000 + resultado +  b * 100 - numero digitado vai sobrar 21
      // 21 / 10 = 2 2 e visao exata por 10
      // resultado  a * 1000 + resultado + b * 100 + c *10 - numero digitado vai sobrar 1
      // 1/1 = 1 1 divisao exata por 1 e ultimo algarismo



  // pra numero menor ele acerta, para maior erra
       
       


     

      


    }
}
