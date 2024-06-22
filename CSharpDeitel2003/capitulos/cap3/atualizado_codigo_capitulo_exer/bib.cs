Console.WriteLine
// comentario de uma linha
Padrao de escrita - // nome do arquivo letra maiscula por que ele é uma classe.
/* eesse comentario
é d emais de uma linha */
uso da bilbiote System _ para usar o wiretline
idetencaao tabulacao e espaco em branco, não é levado em cotna
plavra chave/ palavra reservada
class
minusculo e maiuscolo sao diferentes
nao comeca co numeros, so pode ter @ como primeira letra, nao escrever nome com espaco em branco. pode usar underline e numeros depois da primeira letra
strings 
entender a diretiva using no caso system
caso nao use a diretiva
System.Console.WriteLine("Welcome To C# Programming!");
Console.Write nao pula linha escreve na mesma linha
Consolw.WriteLine Escreve e pula linha

tabulacao
caracter de escape \
\n pula linha mesmo se for no write(tabulacao dentro da string)
\n nova linha, cursor no inicio da proxima linha
\t tabulacao horizontal move o cursor de tela para o proximo ponto de tabulacao
\r retorno de carro posicioona o cursor de tela no inicio da linha atual, nao avanca para a proxima linha, toda saida de caracteres apos o retorno de carro sobrepoe a saida de caracteres anterio ness alinha
\\ barra invertida ussada imprimir um caracter de barra invertida
\" aspas usada para imp4rimir um caracter de aspas

para usuar o messagebox dentro de uma aplicacao windows forms precisamos do System.Windows.Forms.dll

Console.ReadLine();
tipos de dados primitidos, string, int, double e char


 Console.WriteLine("\n A soma num1 = {0}, num2 = {1}, num3 = {2} ", num1,num1,num3);
as duas formas de converter]
com variavel temporaria ou auxiliar e nao
/* Console.WriteLine("Digite o primeiro Número: ");
        primeiro = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo Número: ");
        segundoNumero = Console.ReadLine();


        
        segundo = Int32.Parse((segundoNumero));

        soma = primeiro + segundo;*/


parentese aninhados
os parentes mais interneos sao aplicados primmrio


OPERADORES ARITMETICOS 
ORDEM DE PRECEDENCIA

OPERADORES DE IGUALDADE  E RELACIONAIS

concatecao
de string com string
string com outro tipo de dado "string" + "dado"
o operador igual é da direita para esquerda na ordem de precedencia

x = 2;
y = 3;
("x = ", +x);
("O valor de x + x é " + (x+x));
("x =");
((x + y) + " = " + (y + x ));


x = 7 + 3 * 6 / 2 - 1;
X = 2 % 2 + 2 *2 -2 /2;
x _ (3 *9 * (3 (9*3 / (3) ))));


A B C a b c 0 1 2 $ * + /
Console.WriteLine("o caracter " + `A´ + " tem valor " + (int) `A´);
