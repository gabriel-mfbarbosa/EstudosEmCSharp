//Banda linkinPark = new Banda("Linkin Park");

//Album albumDoLinkinPark = new Album("Hybrid Theory");

//Musica musica1 = new(linkinPark, "Papercut", new Genero { Nome = "Rock" })
//{
//    Duracao = 185,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(linkinPark, "With you", new Genero { Nome = "Rock" })
//{
//    Duracao = 203,
//    Disponivel = false,
//};

//albumDoLinkinPark.AdicionarMusica(musica1);
//albumDoLinkinPark.AdicionarMusica(musica2);
//linkinPark.AdicionarAlbum(albumDoLinkinPark);

//linkinPark.ExibirDiscografia();
//Console.WriteLine("\n");
//albumDoLinkinPark.ExibirMusicasDoAlbum();
//Console.WriteLine("\n");
//musica1.ExibirFichaTecnica();
//Console.WriteLine("\n");
//musica2.ExibirFichaTecnica();


//****************************************************************************************************
// A partir daqui é o desafio
//****************************************************************************************************


Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("José Leandro");
ep1.AdicionarConvidados("Ricardo Augusto");

Episodio ep2 = new(2, "Técnicas de aprendizado", 60);
ep2.AdicionarConvidados("Ronaldo");
ep2.AdicionarConvidados("Elias");
ep2.AdicionarConvidados("Marcella");

Podcast podcast = new("Podcast Facilitadores", "Gabriel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirInformacoes();