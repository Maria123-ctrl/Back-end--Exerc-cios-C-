// See https://aka.ms/new-console-template for more information
//As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.
double preco, maca;


Console.WriteLine("Quantas maças você irá comprar?: ");
maca = double.Parse(Console.ReadLine());

if (maca < 12)
{
    preco = maca * 0.30;

    Console.WriteLine($"Você irá comprar {maca} maças. ");
    Console.WriteLine($"O valor total das maças será {preco}. ");
}
else if (maca > 12)
{
    preco = maca * 0.25;

    Console.WriteLine($"Você irá comprar {maca} maças. ");
    Console.WriteLine($"O valor total das maças será {preco}. ");
}