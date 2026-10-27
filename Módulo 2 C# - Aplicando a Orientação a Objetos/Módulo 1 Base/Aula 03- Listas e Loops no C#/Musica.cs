class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida  => 
        $"A música {Nome} pertence a banda {Artista}";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Nome do artista: {Artista}");
        Console.WriteLine($"Duração da música: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano premium!!");
        }
    }
}
