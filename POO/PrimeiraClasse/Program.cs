using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using PrimeiraClasse;

// string nome = "Eduardo Costa";



// Hello cumprimento = new Hello();

// cumprimento.TextoHello = "Olá usuário";

// cumprimento.SaldarUsuario();
// cumprimento.SaldarComNome("Eduardo Mendes");


Carro c1 = new Carro();
c1.marca = "Lamborghini";
c1.modelo = "Urus";
c1.cor = "Vermelha";
c1.qtdPortas = 4;
c1.qtdRodas = 4;
c1.Ligar();
c1.Acelerar();
c1.Frear();
c1.Desligar();

Carro c2 = new Carro();
c2.marca = "Chevrolet";
c2.modelo = "Camaro";
c2.cor = "Amarela";
c2.qtdRodas = 4;

Console.WriteLine($"Ligando o {c2.modelo}");
Console.WriteLine($"Acelerando o {c2.modelo}");
Console.WriteLine($"Freando o {c2.modelo}");
Console.WriteLine($"desligando o {c2.modelo}");

Console.WriteLine();
Console.WriteLine($"Características");
Console.WriteLine();

Console.WriteLine($"Carro: ---------{c1.marca}---------");
Console.WriteLine($"Modelo {c1.marca}");
Console.WriteLine($"Modelo {c1.modelo}");
Console.WriteLine($"Cor {c1.cor}");
Console.WriteLine($"Quantidade de Portas{c1.cor}");
Console.WriteLine();
Console.WriteLine($"Quantidade de Portas{c1.cor}");
Console.WriteLine($"Quantidade de Portas{c1.cor}");

Console.WriteLine($"Carro: ---------{c1.marca}---------");
Console.WriteLine($"Marca: {c1.marca}");
Console.WriteLine($"Marca: {c1.marca}");
Console.WriteLine($"Modelo: {c1.modelo}");
Console.WriteLine($"Cor: {c1.cor}");
Console.WriteLine($"Quantidade de Portas: {c1.qtdPortas}");


//Moto



/*Moto m1 = new Moto();
m1.marca = "Honda";
m1.modelo = "Scooter";
m1.cor = "Preto";
m1.qtdRodas = 2;
m1.Ligar();
m1.Acelerar();
m1.Frear();
m1.Desligar();

Moto m2 = new Moto();
m2.marca = "Yahama";
m2.modelo = "Yamaha XVS 1100.";
m2.cor = "Branca";
m2.qtdRodas = 2;

Console.WriteLine($"Ligando o {m2.modelo}");
Console.WriteLine($"Acelerando o {m2.modelo}");
Console.WriteLine($"Freando o {m2.modelo}");
Console.WriteLine($"desligando o {m2.modelo}");

Console.WriteLine();
Console.WriteLine($"Características");
Console.WriteLine();

Console.WriteLine($"Carro: ---------{m1.marca}---------");
Console.WriteLine($"Modelo {m1.marca}");
Console.WriteLine($"Modelo {m1.modelo}");
Console.WriteLine($"Cor {m1.cor}");
Console.WriteLine($"Quantidade de Portas{m1.cor}");
Console.WriteLine();
Console.WriteLine($"Quantidade de Portas{m1.cor}");
Console.WriteLine($"Quantidade de Portas{m1.cor}");

Console.WriteLine($"Carro: ---------{m1.marca}---------");
Console.WriteLine($"Marca: {m1.marca}");
Console.WriteLine($"Marca: {m1.marca}");
Console.WriteLine($"Modelo: {m1.modelo}");
Console.WriteLine($"Cor: {m1.cor}");
Console.WriteLine($"Quantidade de Rodas: {m1.qtdRodas}");*/

/*Garrafa g1 = new Garrafa();
g1.quantidade = 0;
g1.marca = "";
g1.modelo = "";
g1.cor = "";
g1.Esvaziar();
g1.Encher();
g1.Lavar();
g1.Secar();*/

Garrafa g1 = new Garrafa();

Console.WriteLine("--GARRAFA--");

Console.WriteLine("Digite a quantidade máxima da sua garrafa: ");
g1.quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a marca da garrafa: ");
g1.marca = Console.ReadLine();

Console.WriteLine("Digite o modelo da garrafa: ");
g1.modelo = Console.ReadLine();

Console.WriteLine("Digite a cor da garrafa: ");
g1.cor = Console.ReadLine();

g1.Esvaziar();
g1.Encher();
g1.Lavar();
g1.Secar();
