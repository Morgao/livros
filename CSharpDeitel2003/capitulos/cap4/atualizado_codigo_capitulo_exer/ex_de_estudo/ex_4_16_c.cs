using System;
namespace teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {

         int contador, n;
         double aux, e, x, b,auxdois;
         contador = 2;

         Console.WriteLine("Digite a Quantidade de passsos da sequencia: ");
         n = Int32.Parse(Console.ReadLine());
         Console.WriteLine("Digite o valor de x: ");
         x = Double.Parse(Console.ReadLine());

         e = 1;
         aux = 1;
         auxdois = x;
          

         Console.Write("e = {0} +", e); // e = 1

         while (contador <= n)
         {
            
            
           // auxilar de auxdois pq fazer direto x = x *x nao funcionou
            b = auxdois/aux;
            e = e + b;
            Console.Write(" {0} + ",e);  // 1)  2 2)
            
            auxdois = auxdois * x;                    
            aux = aux * contador;            
            contador++;

         }

         Console.Write(" = {0}",e);




        }
            
    }
}
