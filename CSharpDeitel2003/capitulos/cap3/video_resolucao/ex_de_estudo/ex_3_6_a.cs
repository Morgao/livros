using System;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
      // indique a ordem dos operadores em cada uma a seguir
        //x = 7 + 3 * 6 / 2 - 1;
        //X = 2 % 2 + 2 *2 -2 /2;
        //x = (3 * 9 * (3 (9*3 / (3) ))));

        // a)
        // 1) 3*6 = 18 // x = 7 + 18/2 -1
        // 2) 18/2 = 9; // x = 7 + 9 -1
        // 3) 7 + 9 = 16; // x = 16 -1
        // 4) 16-1 = 15; // x = 15

    }
}
