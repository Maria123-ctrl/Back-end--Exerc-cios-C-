// See https://aka.ms/new-console-template for more information
/*int soma = 0;
int numero1;
int numero2;
int numero3;

Console.WriteLine("Digite o primeiro numero:");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o primeiro numero:");
numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o primeiro numero:");
numero3 = int.Parse(Console.ReadLine());

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o i número {i}");

}*/

int n, resultado = 0;

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Digite o numero: ");
    n = int.Parse(Console.ReadLine());
    resultado += n;
}
Console.WriteLine($"Somatoria total: {resultado}");
