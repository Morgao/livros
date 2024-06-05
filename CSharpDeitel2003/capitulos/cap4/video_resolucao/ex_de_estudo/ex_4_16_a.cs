using System;
namespace teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, fatorial, x;
            Console.WriteLine("Digite o numero que deseja calcular o Fatorial: ");
            n = Int32.Parse(Console.ReadLine());

            fatorial = 1;
            x = n;

            while (x > 0)
            {
                if (x > 1)
                {
                    Console.Write("{0} x ", x);
                }
                else
                {
                    Console.Write("{0} = ", x);
                }
                
               
                fatorial = fatorial * x;
                x = x - 1;
            }

            Console.WriteLine(fatorial);
        }
    }
}
