using System;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        // pede dois numeros
        //imprime soma diferenca produto quociente
    int a,b, soma, diferenca, produto, quociente;
      Console.WriteLine("Digite o primeiro numero: ");
      a = Convert.ToInt32(Console.ReadLine());
      // o convert.toint32 nao da mensagem de warning ja int32.parse da  possivel null expect
      Console.WriteLine("Digite o segundo numero: ");
      b = Convert.ToInt32(Console.ReadLine());

      soma = a + b;
      diferenca = a - b;
      produto = a * b;
      quociente = a % b;

      Console.WriteLine("a soma é: {0},a diferenca é: {1},a produto é: {2},a quociente é: {3}", soma, diferenca, produto, quociente);

      


    }
}
