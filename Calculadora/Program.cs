// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.InteropServices;
double escolha;
double resultado, n1 = 0, n2 = 0;
do
{
    Console.WriteLine("===== CALCULADORA =====");
    Console.WriteLine("");


    Console.WriteLine("1 - Soma");
    Console.WriteLine(" 2 - Subtração");
    Console.WriteLine(" 2 - Subtração");
    Console.WriteLine(" 3 - Multiplicação");
    Console.WriteLine(" 4 - Divisão");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Escolha uma das opções acima: ");
    escolha = double.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o primeiro número: ");
     n1 = double.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo número: ");
     n2 = double.Parse(Console.ReadLine());

   


    switch (escolha)
    {
        case 1:
            resultado = Soma(n1, n2);
            Console.WriteLine($"Resultado da Soma {resultado}");
            break;
        case 2:
            resultado = Subtracao(n1, n2);
            Console.WriteLine($"Resultado da subtração {resultado}");
            break;
        case 3:
            resultado = multiplicacao(n1, n2);
            Console.WriteLine($"Resultado da multiplicação {resultado}");
            break;
        case 4:
            if (n2 == 0)
            {
                Console.WriteLine($"Divisão por zero");
            }
            else
            {
                resultado = divisao(n1, n2);
                Console.WriteLine($"Resultado da divisao: {resultado}");
            }
            //resultado = divisao(n1, n2);
            //Console.WriteLine($"Resultado da divisão {resultado}");
            break;

        case 0:
            Console.WriteLine($"Obrigado por utilizar o nosso programa!!");
            break;
    } 
    
} while (escolha != 0) ;

    
double Soma(double n1, double n2)
{
    return n1 + n2;
}

double Subtracao(double n1, double n2)
{
    return n1 - n2;
}
double multiplicacao(double n1, double n2)
{
    return n1 * n2;
}
double divisao(double n1, double n2)
{
    return n1 / n2;
}



Console.WriteLine("Pressione qualquer tecla + <Enter> para continuar...");
Console.WriteLine("");