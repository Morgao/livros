using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.IO.Compression;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
     // determinar se o limite de credito foi excedido
     // n da conta
     // saldo do mes
     // total de todos itens cobrados no mes
     // total de todo credito aplicado no cliente
     // limite de credito permitido
     // calcular novo saldo = saldo inicial + cobrancas - credito
     // exibir novo saldo e detemrianr se ultrapassa limite de  creditod o cliente
     // para os clientes que ultrapassar limite de credito mensagem de limite de credito excedido

     int numeroDaConta, limiteDeCredito,  totalDeItensCobrados, totalDeCreditoAplicado, novoSaldo;
     
     limiteDeCredito = 5000;     
     totalDeItensCobrados = 0;
     totalDeCreditoAplicado = 0;

     Console.WriteLine("Digite o numero da conta: ");
     numeroDaConta = Int32.Parse(Console.ReadLine());
     
     if (numeroDaConta == 0001)
     {
      Console.WriteLine("Digite o valor do item: ");
      totalDeCreditoAplicado = Int32.Parse(Console.ReadLine());
      while(totalDeCreditoAplicado != -1)
      {
      totalDeItensCobrados =  totalDeItensCobrados + totalDeCreditoAplicado;
      Console.WriteLine("Digite o valor do item: ");
      totalDeCreditoAplicado = Int32.Parse(Console.ReadLine());
      }
     
     }

     novoSaldo =  limiteDeCredito  - totalDeItensCobrados;
     if (novoSaldo <= limiteDeCredito)
     {
      Console.WriteLine("Seu novo saldo é: {0}",novoSaldo);
     }
     else
     {
      Console.WriteLine("Saldo insuficiente");
     }

     
    } // fim da main

} // fim do programa
