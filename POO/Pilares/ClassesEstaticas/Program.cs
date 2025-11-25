// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;

// System.Console.WriteLine($"Bem vindo ao programa");
// System.Console.WriteLine();

// System.Console.WriteLine($"Digite um número: ");
// float a = float.Parse(Console.ReadLine());
// System.Console.WriteLine($"Digite outro número");
// float b = float.Parse(Console.ReadLine());

// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtracao(a, b);
// System.Console.WriteLine($"Subtração: {r}");

// r = CalculosMatematicos.Multiplicacao(a, b);
// System.Console.WriteLine($"Multiplicacao: {r}");

// if (b == 0)
// {
//    System.Console.WriteLine("Divisão Inválida");
// }
// else
// {
//     r = CalculosMatematicos.Divisao(a, b);
//     System.Console.WriteLine($"Diisao: {r}");
// }


//Solicitar ao usuario 2 numeros reais e informar qual e o maior  e qual é o menor dos numeros. Para isso voce deve utilizar a classe Math, utilitaria do C#

System.Console.WriteLine($"Digite o primeiro número real: ");
float reais = float.Parse(Console.ReadLine());
System.Console.WriteLine($"Digite o segundo número real: ");
float reais2 = float.Parse(Console.ReadLine());
if (reais == reais2)
{
    System.Console.WriteLine($"Os dois números são iguais");
}
else
{
    System.Console.WriteLine($"Maior é: {Math.Max(reais, reais2)}");
    System.Console.WriteLine($"Menor é: {Math.Max(reais, reais2)}");

}



