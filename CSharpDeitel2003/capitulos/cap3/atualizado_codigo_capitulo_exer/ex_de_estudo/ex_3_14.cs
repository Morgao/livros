using System;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
 
        int a,b, mult;
        Console.WriteLine("digite o primerio numero: ");
        a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("digite o segundo numero: ");
        b = Int32.Parse(Console.ReadLine());

        
        if ((a % b) == 0){
            Console.WriteLine("o numero{0} é multiplo de {1}",a,b);
        }
        if ((a % b) != 0){
            Console.WriteLine("o numero{0} não é multiplo de {1}",a,b);
        }

       
       


     

      


    }
}
