// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Digite seu nomsobrenome: ");
string sobrenome = Console.ReadLine();

Console.WriteLine($"ok, {nome}! Agora vamos dar as boas vindas a você!!");


Console.WriteLine($"por favor escolha uma opção abaixo: ");
Console.WriteLine($"    1 - Saudar com nome ");
Console.WriteLine($"    2- Saudar com sobrenome ");
Console.WriteLine($"    3- Saudar comnome e sobrenome");
Console.WriteLine($"    0- Apenas saudação genérica ");

int opcao = 0;
switch (opcao)
{

    case 0:
    SaudacaoGenerica()


        break;
    case 1:
        SaudarComNome(nome);
        break;
    case 2:
        SaudarComSobrenome(sobrenome);
        break;
    case 3:
        string nomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem vindo {nomeCompleto}");
        break;
    default:
        break;
}

void SaudarComSobrenome(string sobrenomeRecebido)
{
    Console.WriteLine($"Olá, seja bem-vindo {sobrenomeRecebido}");
}

void SaudacaoGenerica()
{
    Console.WriteLine($"Ola, seja bem vindo ao nosso programa, tenha um ótimo dia :)");
}

void SaudarComNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem vindo, {nomeRecebido}");
}

string DevolveNomeCompleto(string nomeRecebido, string sobrenomeRecebido)
{
    return $"{nomeRecebido} {sobrenomeRecebido}";
}

