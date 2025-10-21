// See https://aka.ms/new-console-template for more information
/*2)Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.*/
int placar1, placar2;

Console.WriteLine("Digite o primeiro time: ");
placar1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo time: ");
placar2 = int.Parse(Console.ReadLine());



if (placar1 > placar2)
{
    Console.WriteLine("A vitória foi do primeiro time!!!!");
}
else if (placar1 < placar2)
{
    Console.WriteLine("O segundo time ganhou!!!!");
}
else
{
    Console.WriteLine("Os times empataram.");
}

