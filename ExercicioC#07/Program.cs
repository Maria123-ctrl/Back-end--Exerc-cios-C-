// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Crie um menu de console igual ao exibido abaixo, utilizando a estrutra switch do c#:

//-------------------------------------------------------
//        Bem Vindo, Usuário
//-------------------------------------------------------


//Escolha uma opção no menu abaixo:

/* 1) Opção 1
   2) Opção 2
   3) Opção 3
   0) Sair*/
int opcao;


Console.WriteLine("-------------------------------------------");
Console.WriteLine("             Bem Vindo, Usuário!           ");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("Escolha uma opção abaixo: ");
Console.WriteLine("Opção 1 ");
Console.WriteLine("Opção 2 ");
Console.WriteLine("Opção 3 ");
Console.WriteLine("Sair ");
opcao = int.Parse(Console.ReadLine());
Console.WriteLine("Opção escolhida: " + opcao);