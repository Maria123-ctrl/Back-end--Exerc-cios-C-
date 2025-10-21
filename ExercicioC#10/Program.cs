// See https://aka.ms/new-console-template for more information

        int opcao = -1;

        do
        {
            Console.Clear();
            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("6 - Exercício 6");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("==========================");
            Console.Write("Escolha uma opção: ");
            
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    

    // ===== FUNÇÕES =====
    static void Exercicio1()
    {
        Console.WriteLine("Executando Exercício 1...");
        // Aqui entra o código do exercício 1
    }

    static void Exercicio2()
    {
        Console.WriteLine("Executando Exercício 2...");
        // Aqui entra o código do exercício 2
    }

    static void Exercicio3()
    {
        Console.WriteLine("Executando Exercício 3...");
        // Aqui entra o código do exercício 3
    }

    static void Exercicio4()
    {
        Console.WriteLine("Executando Exercício 4...");
        // Aqui entra o código do exercício 4
    }

    static void Exercicio5()
    {
        Console.WriteLine("Executando Exercício 5...");
        // Aqui entra o código do exercício 5
    }

    static void Exercicio6()
    {
        Console.WriteLine("Executando Exercício 6...");
        // Aqui entra o código do exercício 6
    }
