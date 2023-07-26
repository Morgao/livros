using System;
namespace Algoritmos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x1, x2, x3, x4, x5, aux, flag;
            flag = 0;






            while (flag != -1)
            {
                Console.WriteLine("Digite um numero Palidromo de 5 Digitos | (-1) para sair");
                flag = Int32.Parse(Console.ReadLine());
                x1 = (flag / 10000);
                x2 = ((flag % 10000) / 1000);
                x3 = (((flag % 10000) % 1000) / 100);
                x4 = ((((flag % 10000) % 1000) % 100) / 10);
                x5 = (((((flag % 10000) % 1000) % 100) % 10) / 1);

                if ((x1 == x5) && (x2 == x4))
                {
                    Console.WriteLine("este numero é um ,palindromo: ", flag);
                }
                else
                {
                    Console.WriteLine("digitou errado quer tentar de novo?");
                    Console.WriteLine("Digite um numero Palidromo de 5 Digitos | (-1) para sair");
                    flag = Int32.Parse(Console.ReadLine());
                    x1 = (flag / 10000);
                    x2 = ((flag % 10000) / 1000);
                    x3 = (((flag % 10000) % 1000) / 100);
                    x4 = ((((flag % 10000) % 1000) % 100) / 10);
                    x5 = (((((flag % 10000) % 1000) % 100) % 10) / 1);
                    if ((x1 == x5) && (x2 == x4))
                    {
                        Console.WriteLine("este numero é um ,palindromo: ", flag);
                        Console.WriteLine("-1 para sair");
                    }


                }


            }

        }
    }

}