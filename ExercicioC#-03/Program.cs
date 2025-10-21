// See https://aka.ms/new-console-template for more information
//Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     
//Triângulo    Equilátero:    possui    os    3    lados    iguais.     
//Triângulo    Isóscele:    possui    2    lados    iguais.     
// Triângulo    Escaleno:    possui    3    lados    diferentes.

int md1, md2, md3;

Console.WriteLine("Digite a primeira medida: ");
md1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda medida: ");
md2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira medida: ");
md3 = int.Parse(Console.ReadLine());

if (md1 == md2 && md3 == md1 )
{
    Console.WriteLine("É um Triângulo Equilatero");
}
else if (md1 != md2 && md3 != md2 && md1 != md3 )
{
    Console.WriteLine("É um Triângulo Escaleno");
}
else
{
    Console.WriteLine("É um Triângulo Isósceles");
}

