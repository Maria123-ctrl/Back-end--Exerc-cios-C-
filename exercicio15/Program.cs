// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");
// Faça um programa que receba 4 notas de um aluno, calxule e imprima a média 
// aritmética das notas e a mensagem de APROVADO para média superior ou igual a 
// 7,0 RECUPERAÇÂO para notas entre 5.0 e 7,0 ou a mensagem de REPROVADO 
// para média inferior a 5,0.

String aluno;
double nota1, nota2, nota3, nota4;
double média;

//Console.WriteLine("Digite o nome do aluno");
//aluno = String.Parse(Console.ReadLine());
Console.WriteLine("Digite a primeira nota");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota");
nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota");
nota4 = double.Parse(Console.ReadLine());

média = (nota1 + nota2 + nota3 + nota4) / 4;
Console.WriteLine("Média da nota: " + média);

if (média >= 7)
{
    Console.WriteLine("APROVADO");
}
else if (média >= 5)
{
    Console.WriteLine("RECUPERAÇÃO");
}
else if (média <= 5)
{
    Console.WriteLine("REPROVADO");
}
