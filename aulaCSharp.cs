Console.WriteLine("Hello, world!");
Console.WriteLine(@"Mensagem formatada
        que termina aqui!");

int idd = 24;
Console.WriteLine("Olá, eu tenha " + idd + " anos");
Console.WriteLine($"Olá, eu tenho {idd} anos");
Console.WriteLine("");
//operadores

int valorUm = 10;
int valorDois = 5;

Console.WriteLine(valorUm + valorDois);
Console.WriteLine(valorUm - valorDois);
Console.WriteLine(valorUm * valorDois);
Console.WriteLine(valorUm / valorDois);
Console.WriteLine(valorUm % valorDois);
Console.WriteLine("");

// Operadores de atribuição combinados com alguma operação
float valor = 10;
Console.WriteLine(valor += 1); //valor = valor + 1 = 11
Console.WriteLine(valor -= 2); // valor = valor - 2 = 9
Console.WriteLine(valor *= 5); // valor = valor * 5 = 45
Console.WriteLine(valor /= 5); // valor = valor / 5 = 9
Console.WriteLine(valor %= 3); // valor = valor % 3 = 0
Console.WriteLine("");

// operadores de incremento e decremento
//incremento
valor++; // o ultimo numero que foi atribuido ao valor foi 0, então valor++, esta incrementando +1. O atual valor de valo9r é 1

//decremento
valor--; // devido ao incremento na ultima liunha de codigo o valor é 1, agora com o incremento valor volta a 0


//if
int idadeMinima = 16;
int idadeClaudia = 23;

if (idadeClaudia >= idadeMinima) // programa faz uma comparação entre as idades, se for verdadeira irá ler as linhas de codigo dentro do if
{
    Console.WriteLine("Você pode fazer o curso");
}else  // caso o if não seja atendido o else é ativo e então é lido as linhas de codigo
{
    Console.WriteLine("Infelizmente você não pode participar do curso.");
}

Console.WriteLine("");

//ternário 

int idadeCris = 22;
int idadeArthur = 20;
Console.WriteLine(idadeCris > idadeArthur ? "Cris" : "Arthur"); // é feito também uma comparação no entanto direto na saida, caso seja verdadeira apresenta a primeira string como resposta senão é apresentada a segunda alternativa.
Console.WriteLine("");

//switch

int numeroDoMes = 3;
string mes = "";
switch (numeroDoMes) //entendi e não sei explicar, basicamente um if cheio de elif.
{
    case 1:
        mes = "Janeiro";
        break;
    case 2:
        mes = "Fevereiro";
        break;
    case 3:
        mes = "Março";
        break;
    case 4:
        mes = "Abril";
        break;    
    default:
        mes = "mês inválido!";
        break;
}
Console.WriteLine(mes);
Console.WriteLine("");

float num1 = 10;
float num2 = 20;
string operacao = "+";

switch (operacao)
{
    case "+":
        Console.WriteLine(num1 + num2);
        break;
    case "-":
        Console.WriteLine(num1 - num2);
        break;
    case "*":
        Console.WriteLine(num1 * num2);
        break;
    case "/":
        Console.WriteLine(num1 / num2);
        break;
    default:
        Console.WriteLine("Operação Invalida");
        break;
}
Console.WriteLine("");
//estruturas de repetição, enquanto uma condição for verdadeira ele vai se repetir, quando a condição não for verdadeira o codigo continuará após a estrutura de repetição
//while

int inicializacao = 0;
while (inicializacao <= 5)
{
    Console.WriteLine("instrução do laço: " + inicializacao);
    inicializacao++;
}
Console.WriteLine("");
//do While ---> primeiro faz as intruções e depois verifica a condição
int init = 0;
do
{
    Console.WriteLine("teste: " + init);
    init++;
} while (init <= 4);
Console.WriteLine("");

//for

for (int inicio = 0; inicio <= 10; inicio ++)
{
    Console.WriteLine($"contando... {inicio}");
}
