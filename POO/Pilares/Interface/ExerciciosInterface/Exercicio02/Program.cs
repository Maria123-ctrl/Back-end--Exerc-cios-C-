using Exercicio02;

List<IImprimivel> documentos = new List<IImprimivel>();

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

System.Console.WriteLine($"Apertar <ENTER> para continuar");
Console.WriteLine();
}while (opcao != 0);




