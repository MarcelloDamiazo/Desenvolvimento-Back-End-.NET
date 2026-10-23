Musica musica1 = new Musica();
musica1.nome = "Aerials";
musica1.artista = "System of a Down";
musica1.duracao = 235;
musica1.disponivel = true;

Console.WriteLine($"Nome da música: {musica1.nome}");
Console.WriteLine($"Nome do artista: {musica1.artista}");

Musica musica2 = new Musica();
musica2.nome = "Walk";
musica2.artista = "Pantera";
musica2.duracao = 315;
musica2.disponivel = false;

Console.WriteLine($"Nome da música: {musica2.nome}");
Console.WriteLine($"Nome do artista: {musica2.artista}");

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();