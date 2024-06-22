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
      /*
      entrada km rodado , combustivel gasto
      60 litros
      20 km
      5 l
      1 tanque  media por lirtro 5 l * 20
      media por litro * pelo 60 l / media por tanque
      media de todos os tanques
      media de km / litro

      // quanto cabe no tanque cheio
      // quantos km rodado
      // quantos litros gastos

      */
      
      double tqCheio, kmRodado, lGasto;
      double mediaPorKmL,  mediaTodosKmL;
      
      mediaPorKmL = 0;      
      mediaTodosKmL = 0;
     


      Console.WriteLine("quantos litros cabe no carro: ");
      tqCheio = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Digite km rodado: ou -1 para sair");
      kmRodado = Convert.ToDouble(Console.ReadLine());      
      Console.WriteLine("Digite litros gastos: ");
      lGasto = Convert.ToDouble(Console.ReadLine());

      while (kmRodado != -1)
      {
         mediaPorKmL = kmRodado / lGasto;         
         Console.WriteLine("media por km / l {0}",mediaPorKmL);      

         mediaTodosKmL = mediaTodosKmL + mediaPorKmL;
         

         Console.WriteLine("Digite km rodado: ou -1 para sair");
         kmRodado = Convert.ToDouble(Console.ReadLine());
         
         Console.WriteLine("Digite litros gastos: ");
         lGasto = Convert.ToDouble(Console.ReadLine());
         // nao sei pq precisa digitar -1 duas vezes
    
         

      }

      Console.WriteLine("Media de KM rodado {0}",mediaTodosKmL);
      

     
    } // fim da main

} // fim do programa
