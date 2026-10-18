//Screen Sound 
string mensagemDeBemVindo = "Boas Vindas ao Screen Sound!";

void ExibirMensagemDeBemVindo()
{
    Console.WriteLine (@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensagemDeBemVindo);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcaoEscolhidaNumerica < 1 || opcaoEscolhidaNumerica > 5)
    {
        Console.WriteLine("Opção inválida, digite um número de 1 a 5");
        ExibirOpcoesDoMenu();
    }
    switch (opcaoEscolhidaNumerica)
        {
            case 1:Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case 2:Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case 3:Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case 4:Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case 5:Console.WriteLine("Até mais!:)");
                break;
        }
}

ExibirMensagemDeBemVindo();
ExibirOpcoesDoMenu();