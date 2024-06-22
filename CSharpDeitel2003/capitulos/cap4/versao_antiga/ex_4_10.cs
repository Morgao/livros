using System;
namespace Algoritmos 
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            double kmRodado, combustivelGasto, total;
            Console.WriteLine("Digite Quantos Kilometros Rodados: ");
            kmRodado = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite Quantos Litros foram gastos: ");
            combustivelGasto = Double.Parse(Console.ReadLine());

            total = kmRodado / combustivelGasto;
            Console.WriteLine("Valor do Km/Litro:" + total);
            
        }
    }

}