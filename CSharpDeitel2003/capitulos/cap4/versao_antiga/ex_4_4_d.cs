using System.Reflection.Metadata.Ecma335;
using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.IO.Compression;

namespace Codigos {
    internal class CodigoTeste {
        public static void Main(string[] args)
        {
          
        int q, divisor, total;
        q = 2;
        divisor = 4;
        
        total = divisor % q;
        q = total;
        Console.WriteLine(q);
        // ou
        q = 2;
        q = divisor % q;
        Console.WriteLine(q);;

    }
}
}