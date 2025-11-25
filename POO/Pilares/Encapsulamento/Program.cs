using System.Diagnostics.Contracts;
using Encapsulamento;

float dinheiro = -200;

ContaBancaria contaEdu = new ContaBancaria();
ContaBancaria contaMaria = new ContaBancaria(dinheiro);

// System.Console.WriteLine($"Saldo da Conta {contaEdu.Saldo}");
contaEdu.Depositar(dinheiro);

// contaEdu.Saldo = dinheiro;
System.Console.WriteLine($"Saldo da Conta R${contaEdu.GetSaldo()}");
System.Console.WriteLine($"Saldo da Conta R${contaMaria.GetSaldo()}");

contaEdu.Sacar(100);
System.Console.WriteLine($"Saldo após o saque do Edu: R${contaEdu.GetSaldo()}");

Carro volvo = new Carro();

volvo.DefinirMarca("Volvo");
volvo.DefinirModelo("Volvo 81");

volvo.Acelerar(100);
volvo.Acelerar(50);

volvo.Frear(10);

System.Console.WriteLine($"Marca: {volvo.ObterMarca()}");
System.Console.WriteLine($"Modelo: {volvo.ObterModelo()}");
System.Console.WriteLine($"Velocidade Atual: {volvo.ObeterVelocidade()}");
