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
            numeroDeNotas, // qnumero de notas fornecidas
            valorDaNota, // valor da nota
            media; // media de todas as notas

      // inicializacao das variaveis
      total = 0;  // limpa total
      numeroDeNotas = 1; // prepra variavel para o laco

      //fase de processamento
      // caso inciiei a variavel numero de notas com 0, faria o while até <10, ou <=9
      while (numeroDeNotas<=10) {  // repete o laco 10 vezez
         Console.WriteLine("Digite a nota: "); // solicita a entrada  da nota
         valorDaNota = Int32.Parse(Console.ReadLine());  // le a entrada da nota

         // soma valordanota no total
         total = total + valorDaNota;

         // soma 1 a numerode nota 
         numeroDeNotas = numeroDeNotas + 1;
         
      }

      // calculando a media
      media = total / 10 ;

      // exibindo a media da turma
      Console.WriteLine("\n Media da Clase: {0} ", media);

     
    }
}
