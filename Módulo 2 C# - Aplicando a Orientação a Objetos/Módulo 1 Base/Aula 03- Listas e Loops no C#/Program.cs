Musica musica1 = new Musica();
musica1.Nome = "Aerials";
musica1.Artista = "System of a Down";
musica1.Duracao = 235;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Walk";
musica2.Artista = "Pantera";
musica2.Duracao = 315;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();