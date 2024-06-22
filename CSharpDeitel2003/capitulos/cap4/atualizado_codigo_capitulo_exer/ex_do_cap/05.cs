using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
 
      // digita notas da classe de 10 alunos, faz a media e imprime

      int total, // total das notas
            numeroDeNotas, // numero de notas fornecidas
            valorDaNota; // valor da nota

      double media; // media de todas as notas

      // inicializacao das variaveis
      total = 0;  // limpa total
      numeroDeNotas = 0; // prepra variavel para o laco

      Console.WriteLine("\n Entre com a nota, ou digite -1 para sair: ");
      valorDaNota = Int32.Parse(Console.ReadLine());
      //fase de processamento
      // caso inciiei a variavel numero de notas com 0, faria o while até <10, ou <=9
      while (valorDaNota != -1) {  // repete o laco indeterminadamente

         // soma valordanota no total
         total = total + valorDaNota;

         // soma 1 a numerode nota 
         numeroDeNotas = numeroDeNotas + 1;

         Console.WriteLine("\n  Entre com a nota, ou digite -1 para sair: "); // solicita a entrada  da nota
         valorDaNota = Int32.Parse(Console.ReadLine());  // le a entrada da nota
             
      } // fim do while

      if (numeroDeNotas != 0)
      {// inicio do if
         // calculando a media
         media = (double) total / numeroDeNotas ;

         // exibindo a media da turma
         Console.WriteLine("\n Media da Clase: {0} ", media);
      }
      else 
      {
         Console.WriteLine("\n sem entrada de notas");
      }
      // fim do if


  
     
    } // fim da main

} // fim do programa
