// Arrays
using System.Runtime.InteropServices.Marshalling;

int[] inteiros = new int [4];
inteiros [0] = 32;
Console.WriteLine(inteiros[0]);
// outra forma de declarar
int [] inteirosComValores = new int [4] {24, 17, 26, 4};
Console.WriteLine(inteirosComValores[2]);

int[] numeros = {4, 3, 2, 5};
Console.WriteLine(numeros[2]);
Console.WriteLine("");
// arrays de strings
string[] nomes = {"Claudia", "Cris", "Pedro"};

// utilizando um for para percorrer a arrays e mostrar os nomes na saida.
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}
Console.WriteLine("");
//função

static void imprimirtexto()
{
    Console.WriteLine("Olá, mundo!");
}

Console.WriteLine("");
//função com parametro
imprimirtexto();

static void imprimirNome(string nome)
{
    Console.WriteLine(nome);
}
imprimirNome("Altemir");

//Biblioteca de funções
//não precisa fazer as importações no cabeçalho do código
// mas pode ser necessario fazer a importação do system.io para utilização de algumas bibliotecas
Console.WriteLine("");
Random dado = new Random();
int lados = dado.Next(1, 7);
Console.WriteLine(lados);

// biblioteca Math não precisa ser chamada pode ser declarada diretamente nas linhas de codigo
Console.WriteLine("");
float num = 81;
Console.WriteLine(Math.Sqrt(num));
Console.WriteLine("");
//Caminho do arquivo
string CaminhoDoArquivo = @"C:\Users\altem\OneDrive\Área de Trabalho\Aulas\arrays\arquivo.txt";

//Instancia objeto do tipo StreamWriter com o caminho do arquivo como argumento
var stream = new StreamWriter(CaminhoDoArquivo);

//escreve as linhas no arquivo
stream.WriteLine("linha 1...");
stream.WriteLine("linha 2...");
stream.WriteLine("Linha 3...");
//fecha o arquivo atual e o fluxo adjacente
stream.Close();
//finaliza a escrita no arquivo e fecha o arquivo, a partir daqui vai ver as linhas que foram escritas no arquivo
using (var reader = new StreamReader(CaminhoDoArquivo))
{
    //vai ler linha por linha do arquivo
    var linha = " ";
    while((linha = reader.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }
}
