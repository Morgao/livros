using System;
namespace teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {

         int contador, n;
         double aux, e;
         contador = 2;

         Console.WriteLine("Digite a Quantidade de passsos da sequencia de Euler [e] ");
         n = Int32.Parse(Console.ReadLine());

         e = 1;
         aux = 1;

         Console.Write("e = {0} +", e); // e = 1

         while (contador <= n)
         {
            e = e + 1/aux;
            Console.Write(" {0} + ",e);  // 1)  2 2)
            aux = aux * contador;
            contador++;

         }

         Console.Write(" = {0}",e);




        }
            
    }
}
