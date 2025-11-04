using System.ComponentModel;
using ClassesEObjetos;

/*Pessoa joao = new Pessoa();

joao.Nome = "João Silva";

Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");*/

/*joao.Envelhecer(17);*/
/*int novaIdade = joao.Envelhecer(17);
Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

novaIdade = joao.Envelhecer(-50);
Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");*/


Console.WriteLine($"-- Agência Bancária --");
Console.WriteLine($"Digite o nome do titular da conta: ");
string nomeT = Console.ReadLine();

ContaBancaria cb = new ContaBancaria();

Console.WriteLine();
Console.WriteLine($"Bem vindo, {cb.titular}");
Console.WriteLine($"Saldo inicial: R$ {cb.saldo:F2}");
Console.WriteLine();

int opcao = 0;
do
{
    Console.WriteLine($"\n Menu");
    Console.WriteLine($"1 - Depositar");
    Console.WriteLine($"2 - Sacar");
    Console.WriteLine($"0 - Sair");

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Digite o valor do depósito: R$");
            double deposito = Convert.ToDouble(Console.ReadLine());
            cb.Depositar(deposito);
            break;

        case 2:
            Console.WriteLine($"Digite o valor do depósito: R$");
            double saque = Convert.ToDouble(Console.ReadLine());
            cb.sacar(saque);
            break;
        case 0:
            Console.WriteLine($"Saindo.");
            break;

        default:
            Console.WriteLine($"Opcção inválida, escolhe uma das opções acima.");
            break;
    }
} while (opcao != 0);

Console.WriteLine($"Qual valor você gostaria de depositar?: ");
double ValorDp = double.Parse(Console.ReadLine());
Console.WriteLine("Em qual conta você deseja depositar?: ");
string contaDp = Console.ReadLine();