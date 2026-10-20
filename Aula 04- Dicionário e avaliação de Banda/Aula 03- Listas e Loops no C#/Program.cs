string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound!";
List<string> listaDasBandas = new List<string>{"Nirvana", "Iron Maiden", "ACDC", "Metallica"};
void ExibirLogo()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    while (true)
    {
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para exibir a média de uma banda");
        Console.WriteLine("Digite 5 para sair");

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;

        if (!int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
        {
            Console.WriteLine("Opção inválida, digite um número de 1 a 5");
            Thread.Sleep(1500);
            Console.Clear();
            continue;
        }

        if (opcaoEscolhidaNumerica < 1 || opcaoEscolhidaNumerica > 5)
        {
            Console.WriteLine("Opção inválida, digite um número de 1 a 5");
            Thread.Sleep(1500);
            Console.Clear();
            continue;
        }

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                RegistrarBanda();
                break;
            case 2: MostrarBandasRegistradas();
                break;
            case 3:
                Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case 4:
                Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case 5:
                Console.WriteLine("Até mais! :)");
                return;
        }
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"a Banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as bandas registradas\n");
    //for (int i= 0; i < listaDasBandas.Count; i++)
    //{
        //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach(string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");

    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
}


ExibirOpcoesDoMenu();