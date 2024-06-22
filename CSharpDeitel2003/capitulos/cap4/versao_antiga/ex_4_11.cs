using System;
namespace Algoritmos 
{
    public class Program
    {
        public static void Main(string[] args)
        {

            
            int numeroDaConta, totalDeItensDoMes, limiteDeCredito, novoSaldo;
         
            
            

            Console.WriteLine("Digite o numero da conta: ");
            numeroDaConta = Int32.Parse(Console.ReadLine());                        
            Console.WriteLine("Digite o Valor Do Credito: ");
            limiteDeCredito = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Total Comprado: ");
            totalDeItensDoMes = Int32.Parse(Console.ReadLine());

            novoSaldo = limiteDeCredito - totalDeItensDoMes;

            if (limiteDeCredito >= totalDeItensDoMes)
            {
                Console.WriteLine("Parabens pela compra, Saldo autal: "+ novoSaldo);
            }
            else if (limiteDeCredito < totalDeItensDoMes)
            {
                Console.WriteLine("Limite de credito excedido");

            }
            


        }
    }

}