// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int opcao = -1;

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

Console.Clear();
Console.WriteLine($"FIM DO PROGRAMA");



// tipoDeDado Nome (parâmetros){corpo}

void Coxinha()
{
    Console.WriteLine($"Você escolheu a opção 1 - Coxinha {opcao * 2}");
}

void Pastel()
{
    Console.WriteLine($"Você escolheu a opção 2 - Pastel");
}
void CaldodeCana()
{
    Console.WriteLine($"Você escolheu a opção 3 - Caldo de Cana");
}
void BolodeChocolate()
{
    Console.WriteLine($"Você escolheu sair - Obrigado por usar o programa");
}
void saida()
{
    Console.WriteLine($"Você escolheu sair - Obrigado por usar o programa");
}
void Invalido()
{
    Console.WriteLine($"Não temos esta opção {opcao} !!");
}
