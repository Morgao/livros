using System;
using System.ComponentModel;

namespace Algoritmos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int algarimso1, algarismo2, algarismo3, algarismo4, numero;
            int a1mais7, a2mais7, a3mais7, a4mais7;
            int a1quo, a2quo, a3quo, a4quo;
            int a1resto, a2resto, a3resto, a4resto;
            int novoNumero, voltarNumero;
            int teste, resposta;
            int ab1, ab2,ab3,ab4;
            resposta = 0;

            Console.WriteLine("Digite o Numero a Ser criptografado: ");
            numero = Int32.Parse(Console.ReadLine());


         while(resposta != -1)
         {
            algarimso1 = numero / 1000;
            algarismo2 = ((numero % 1000) / 100);
            algarismo3 = (((numero % 1000)%100)/10);
            algarismo4 = ((((numero%1000)%100)%10)/1);
          

            a1mais7 = algarimso1 + 7;
            a2mais7 = algarismo2 + 7;
            a3mais7 = algarismo3 + 7;
            a4mais7 = algarismo4 + 7;

            a1quo = a1mais7 / 10;
            a2quo = a2mais7 / 10;
            a3quo = a3mais7 / 10;
            a4quo = a4mais7 / 10;

            
            a1resto = a1mais7 % 10;
            a2resto = a2mais7 % 10;
            a3resto = a3mais7 % 10;
            a4resto = a4mais7 % 10;

            
            novoNumero = (a3resto * 1000) + (a4resto * 100) + (a1resto * 10)+ (a2resto * 1)  ;


            voltarNumero =(((a1quo* 10  + a1resto)-7 )*1000) +  (((a2quo *10 + a2resto)-7)*100) + (((a3quo * 10 + a3resto)-7)*10) +    (((a4quo * 10 + a4resto)-7)*1);

            
            Console.WriteLine("Deja ver o numero Criptografado digite [1]: ");
            Console.WriteLine("deseja descriptografar digite[2]:  ");
            Console.WriteLine("deseja sair digite [-1] ");            
            resposta = Int32.Parse(Console.ReadLine());

            if(resposta == 1)
            {
                Console.WriteLine("Novo numero: {0} ", novoNumero);
            }
            else if (resposta ==2)
            {
                Console.WriteLine("Numero antigo: {0}", voltarNumero);
            }
         }
            
            


                


            

        }
    }

}
