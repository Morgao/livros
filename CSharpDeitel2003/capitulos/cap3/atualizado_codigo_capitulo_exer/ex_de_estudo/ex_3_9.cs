using System;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
     // pede raio
     // imprime diametro, circunferencia e o area
     // d = 2 r
     // c = 2 pi r
     // a = pi r*r

     double d,c,a,r, pi;
     pi = 3.14;

     Console.WriteLine("digite o raio: ");
     r = Int32.Parse(Console.ReadLine());

     d = 2 *r;
     c = 2 * pi * r;
     a = pi *(r*r);

     Console.WriteLine("o diametro é {0},a circunferencia é {1},a area é {2}", d,c,a);
     

      


    }
}
