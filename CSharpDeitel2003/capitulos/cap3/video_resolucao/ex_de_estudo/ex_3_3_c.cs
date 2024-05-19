using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
       
      // programa de folha de pagamento

      // variaveis salario, imposto beneficio

      int salario;
      double imposto, beneficio, total;

      salario = 1400;
      imposto = 0.14; //  14 %
      beneficio = 0.20;    // 20%

      total = (salario*imposto) + (salario*beneficio) + salario;
      Console.WriteLine("custo da folha {0} ", total);

    }
}
