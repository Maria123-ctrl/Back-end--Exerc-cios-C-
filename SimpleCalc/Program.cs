// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* Pedir o nome do usuário,
    Pedir dois números e
    mostrar a soma dos números no final*/

string Nome;
int numero1;
int numero2;

//pedir os dados
Console.WriteLine("Digite seu nome");
Nome = Console.ReadLine();
//pedir dois números
Console.WriteLine("Digite o primeiro número");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
numero2 = int.Parse(Console.ReadLine());

int soma = numero1 + numero2;
//pede o nome do usuário

Console.WriteLine(Nome);//exibe o nome do usuário
Console.WriteLine(soma);//exibe o nome do usuário


if (numero1 > numero2)
{
    Console.WriteLine("O primeiro número é maior que o segundo: " + numero1);
}
else if (numero1 < numero2)
{
    Console.WriteLine("O primeiro número é menor que o segundo.");
}
else
{
    Console.WriteLine("Os números são iguais.");
}
