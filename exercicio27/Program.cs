// See https://aka.ms/new-console-template for more information
// Faça um programa que pergunte para o usuário a quantidade de números que ele
//quer digitar. Após isso crie um laço que exiba o número que o usuário digitar apenas
//se for PAR. Utilize a estrutura WHILE.
int nEscolhido;

Console.WriteLine("Digite um numero da sua escolha: ");
nEscolhido = int.Parse(Console.ReadLine());

while (nEscolhido >= 1)
{
    Console.WriteLine("Digite um numero de sua preferência");
    int n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)//se o resto da divisão for igual a 0
    {
        Console.WriteLine("O número escolhido é par");
    }
    nEscolhido--;
}


