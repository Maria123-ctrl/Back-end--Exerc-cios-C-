// See https://aka.ms/new-console-template for more information
//Baseado no programa do exercício número 9, crie um programa que contenha o menu para os exercícios de 1 a 6, onde cada programa/menu deve executar uma função.

int escolha;
do
{

    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                   Bem Vindo, Usuário               ");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("   Escolha uma opção no menu abaixo");
    Console.WriteLine("");
    Console.WriteLine("1) Atividade 1");
    Console.WriteLine("2) Atividade 2 ");
    Console.WriteLine("3) Atividade 3");
    Console.WriteLine("4) Atividade 4");
    Console.WriteLine("5) Atividade 5");
    Console.WriteLine("6) Atividade 6");
    Console.WriteLine("0) Sair");
    Console.WriteLine("");
    escolha = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    switch (escolha)
    {
        case 1:
            at1();
            break;
        case 2:
            at2();
            break;
        case 3:
            at3();
            break;
        case 4:
            at4();
            break;
        case 5:
            at5();
            break;
        case 6:
            at6();
            break;
        case 0:
            op0();
            break;
        default:
            invalida();
            break;
    }

} while (escolha != 0);

Console.Clear();

void at1()
{
    Console.WriteLine("1) Faça um programa que o usuário informe o salário recebido e o total gasto.Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário:");
    Console.WriteLine("");


    Console.WriteLine("Qual seu salario?: ");
    int salário = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual seu gasto total?: ");
    int Tgasto = int.Parse(Console.ReadLine());

    int valor = 0;

    if (salário < Tgasto)
    {

        Console.WriteLine("É amigão, seu Orçamento está estourado :/");
    }
    else
    {

        Console.WriteLine("Parabéns!!!! Sálario não estourado :)");
    }

}

void at2()
{
    Console.WriteLine($"2) Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time)e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time:");
    Console.WriteLine("");


    int placar1, placar2;


    Console.WriteLine("Digite o placar do primeiro time: ");
    placar1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o placar do segundo time: ");
    placar2 = int.Parse(Console.ReadLine());

    if (placar1 == placar2)
    {
        Console.WriteLine(" Os times empataram.");
    }
    else if (placar1 > placar2)
    {
        Console.WriteLine($" A vitória foi do primeiro time!!!!");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine($"O segundo time ganhou!!!!");
        Console.WriteLine("");
    }
}

void at3()
{
    Console.WriteLine($"Escreva um programa que leia as medidas dos lados de um triângulo e escreva se ele é Equilátero, Isósceles ou Escaleno. Sendo que:");
    Console.WriteLine("");


    int md1, md2, md3;

    Console.WriteLine("Digite a primeira medida: ");
    md1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda medida: ");
    md2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a terceira medida: ");
    md3 = int.Parse(Console.ReadLine());

    if (md1 == md2 && md3 == md1)
    {
        Console.WriteLine("É um Triângulo Equilatero");
    }
    else if (md1 != md2 && md3 != md2 && md1 != md3)
    {
        Console.WriteLine("É um Triângulo Escaleno");
    }
    else
    {
        Console.WriteLine("É um Triângulo Isósceles");
    }

}
void at4()
{
    Console.WriteLine($"4) Escreva um programa que verifique a validade de uma senha fornecida pelo usuário. A senha válida é o número 1234.Devem ser impressas as seguintes mensagens:");
    Console.WriteLine("");


    double senha;

    Console.WriteLine("Digite a senha: ");
    senha = double.Parse(Console.ReadLine());

    if (senha == 1234)
    {
        Console.WriteLine("ACESSO PERMITIDO");
    }
    else
    {
        Console.WriteLine("ACESSO NEGADO");
    }

}
void at5()
{
    Console.WriteLine($"5) As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze.Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra:");
    Console.WriteLine("");

    double preco, maca;


    Console.WriteLine("Quantas maças você irá comprar?: ");
    maca = double.Parse(Console.ReadLine());

    if (maca < 12)
    {
        preco = maca * 0.30;

        Console.WriteLine($"Você irá comprar {maca} maças. ");
        Console.WriteLine($"O valor total das maças será {preco}. ");
    }
    else if (maca > 12)
    {
        preco = maca * 0.25;

        Console.WriteLine($"Você irá comprar {maca} maças. ");
        Console.WriteLine($"O valor total das maças será {preco}. ");
    }

}
void at6()
{
    Console.WriteLine($"6) Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%.Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito  a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição  se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado,  porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou  reprovado:");
    Console.WriteLine("");


    double frequencia, media;

    Console.WriteLine("Qual frequência o aluno (a) tem?: ");
    frequencia = double.Parse(Console.ReadLine());
    Console.WriteLine("Qual a média do aluno (a)?: ");
    media = double.Parse(Console.ReadLine());

    if (frequencia >= 75)
    {
        if (media >= 7.0)
        {
            Console.WriteLine("APROVADO");
        }
        else if (media <= 6.9)
        {
            Console.WriteLine("RECUPERAÇÂO");
        }
    }
    else
    {
        Console.WriteLine("REPROVADO");
    }
}

void op0()
{
    Console.WriteLine($"opção: Sair");
}
void invalida()
{
    Console.WriteLine($" está opção é invalida");
}
