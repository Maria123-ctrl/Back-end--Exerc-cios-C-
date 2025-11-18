using System.Runtime.CompilerServices;
using Exercicio02;

List<IImprimivel> documentos = new List<IImprimivel>();
List<Relatorio> listarelatorio = new List<Relatorio>();
List<Contrato> listacontrato = new List<Contrato>();
List<Fatura> listafatura = new List<Fatura>();

// Fatura fatEdu = new Fatura("Eduardo", "Izabel Dark Lab", 50, 1);

// fatEdu.Imprimir();

// Criar um menu da seguinte forma:
int opcao;
do
{
    System.Console.WriteLine($"Menu de Opções");
    System.Console.WriteLine($@"
1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
0) Sair
Escolher a opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
        System.Console.WriteLine($"Cadastrar Fatura");
        CadastrarFatura();
        break;
        case 2:
        System.Console.WriteLine($"Cadastrar Relatório");
        CadastrarRelatorio();
        break;
        case 3:
        System.Console.WriteLine($"Cadastrar Contrato");
        CadastrarContato();
        break;
        case 4:
        System.Console.WriteLine($"Listar Fatura");
        ListarFatura();
        break;
        case 5:
        System.Console.WriteLine($"Listar Relatório");
        ListaRelatorio();
        break;
        case 6:
        System.Console.WriteLine($"Listar Contrato");
        ListaContrato();
        break;
        
    }

    System.Console.WriteLine($"Apertar <ENTER> para continuar");
    Console.ReadLine();
} while (opcao != 0);

// Funções Auxiliares

void CadastrarFatura()
{
    System.Console.WriteLine($"Digite o nome do devedor: ");
    string dev = Console.ReadLine();
    System.Console.WriteLine($"Digite o nome do credor: ");
    string cred = Console.ReadLine();
    System.Console.WriteLine($"Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());
    System.Console.WriteLine($"Quantos dias a fatura está em atraso? ");
    int diasAtraso = int.Parse(Console.ReadLine());

    // cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    // cadastra a fatura na lista
    listafatura.Add(f);
}

void CadastrarContato()
{
    System.Console.WriteLine($"Digite o nome do contratante: ");
    string contratante = Console.ReadLine();
    System.Console.WriteLine($"Digite o nome do Funcionario: ");
    string contratada = Console.ReadLine();
    System.Console.WriteLine($"Quais são as cláusulas do contrato? ");
    string txtClausulas = Console.ReadLine();

    Contrato c = new Contrato(contratante, contratada, txtClausulas);

    listacontrato.Add(c);
}

void CadastrarRelatorio()
{
    System.Console.WriteLine($"Digite seu nome: ");
    string responsavel = Console.ReadLine();
    System.Console.WriteLine($"Digite seu Relatório: ");
    string txtRealatorio = Console.ReadLine();

    Relatorio r = new Relatorio(responsavel, txtRealatorio);

    listarelatorio.Add(r);

}

void ListarFatura()
{
    foreach(var item in listafatura)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}
void ListaContrato()
{
    foreach(var item in listacontrato)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}
void ListaRelatorio()
{
    foreach(var item in listarelatorio)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}




