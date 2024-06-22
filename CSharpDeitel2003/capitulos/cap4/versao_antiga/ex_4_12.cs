using System;
namespace Algoritmos 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, contador;
            a = 1;
            contador = 1;
            
            Console.WriteLine("N    10*N    100*N    1000*N");
            Console.WriteLine();

            while(contador<=5)
            {
                Console.WriteLine("{0}    {1}      {2}      {3}",a, a*10, a*100, a*1000);
                a++;
                contador++;
            }


        }
    }

}