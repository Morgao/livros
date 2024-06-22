using System;
namespace Algoritmos 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x, y;
            x = 9;
            y = 11;

            if (x < 10)
                if (y > 10)
                 Console.WriteLine("*****");
                 else
                 Console.WriteLine("###");
            Console.WriteLine ("$$$$");


        }
    }

}


// vai imprimir a primeira e a terceira linha;
// pois a primeira condicao e verdadeira e a segunda nao
// ivnertenadno x e y tudo se torna falso entao so imprime o ultimo console pq nao passa em nenhuma condicao