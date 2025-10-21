// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Hello, World!");
string cargo;
double salario;
double Nsalario = 0;

Console.WriteLine("Digite o seu cargo: ");
cargo = Console.ReadLine();
Console.WriteLine("Digite seu sálario: ");
salario = double.Parse(Console.ReadLine());


if (cargo == "Producao")
{
    Nsalario = salario * 1.065;
    Console.WriteLine("Seu novo sálario é de: " + Nsalario);
}
else if (cargo == "Administracao")
{
    Nsalario = salario * 1.075;
    Console.WriteLine("Seu novo sálario é de: " + Nsalario);
}
else if (cargo == "Diretoria")
{
    Nsalario = salario * 1.12;
    Console.WriteLine("Seu novo sálario é de: " + Nsalario);
}
else
{
    Console.WriteLine("Cargo inválido! Tente: Producao, Administracao ou Diretoria.");
}




