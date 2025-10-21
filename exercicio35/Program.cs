// See https://aka.ms/new-console-template for more information
int nx = 0;
int contador = 0;
int numero1;
int numero2;

Console.WriteLine("Quantas repetições você quer fazer: ");
nx = int.Parse(Console.ReadLine());


while (contador < nx)
{
    Console.WriteLine("Digite o numero1: ");
    numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o numero2: ");
    numero2 = int.Parse(Console.ReadLine());

    if (numero1 > numero2)
    {
        Console.WriteLine($"O numero {numero1} e maior que o numero {numero2}");
    } else if (numero1 < numero2)
    {
        Console.WriteLine($"O numero {numero1} e menor que o numero {numero2}");
    } else
    {
        Console.WriteLine($"Os numeros {numero1} e {numero2} são iguais.");
    }
        contador++;

}