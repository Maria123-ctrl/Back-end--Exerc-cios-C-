// See https://aka.ms/new-console-template for more information
/*1)Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.*/
int salario;
int Tgasto;

Console.WriteLine("Qual é o seu sálario?: ");
salario = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu total gasto?: ");
Tgasto = int.Parse(Console.ReadLine());

int valor = 0;

if (salario < Tgasto)
{
    Console.WriteLine("É amigão, seu Orçamento está estourado :/");
}
else
{
    Console.WriteLine("Parabéns!!!! Sálario não estourado :)");
}
 