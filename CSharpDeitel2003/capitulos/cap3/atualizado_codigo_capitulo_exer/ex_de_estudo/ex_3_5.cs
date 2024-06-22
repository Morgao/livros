// a / c / d / e estao corretas
using System;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
       
       int a, x, con, y;
       a = 2;
       x = 2;
       con = 7;
        y  = a *(x*x*x) + 7;
        Console.WriteLine("valor de {0} = {1} * {2} * {3} *{4} + {5}", y, a,x,x,x,con);

    }
}
