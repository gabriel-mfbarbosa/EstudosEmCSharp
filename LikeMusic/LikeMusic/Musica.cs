class Musica
{
    public Musica(Banda artista, string nome, Genero genero)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }

    public string Nome {  get; }
    public Genero Genero { get; }
    public Banda Artista {  get; }
    public int Duracao {  get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertece a banda {Artista}";
    


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Gênero: {Genero.Nome}");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}