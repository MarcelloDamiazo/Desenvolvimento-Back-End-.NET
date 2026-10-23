class Musica
{
    public string nome = string.Empty;
    public string artista = string.Empty;
    public int duracao = 0;
    public bool disponivel = true;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {nome}");
        Console.WriteLine($"Nome do artista: {artista}");
        Console.WriteLine($"Duração da música: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("A música está disponível");
        } else
        {
            Console.WriteLine("Adquira o plano premium!!");
        }
    }
}
