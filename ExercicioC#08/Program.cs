// See https://aka.ms/new-console-template for more information
//Faça uma alteração no programa acima do menu para que ele funcione em loop. Pra isso utilize o laço do while do c#.
int opcao;


do
{//todo o programa aqui dentro
 //desenha um menu de opções
Console.WriteLine("-------------------------------------------");
Console.WriteLine("             Bem Vindo, Usuário!           ");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("Escolha uma opção abaixo: ");
Console.WriteLine("Opção 1 ");
Console.WriteLine("Opção 2 ");
Console.WriteLine("Opção 3 ");
Console.WriteLine(" Sair 0");
//captura a opção do usuário
opcao = int.Parse(Console.ReadLine());

//escolhe a opção indicada pelo usuário
switch (opcao)
{
case 1:
Console.WriteLine($"Você escolheu a opção 1 ");
break;
case 2:
Console.WriteLine($"Você escolheu a opção 2 ");
break;
case 3:
Console.WriteLine($"Você escolheu a opção 3 ");
break;

case 4:
Console.WriteLine($"Você escolheu a opção 4 ");
break;
case 0:
Console.WriteLine($"Você escolheu sair - Obrigado por usar o programa");
break;
}

} while (opcao != 0);