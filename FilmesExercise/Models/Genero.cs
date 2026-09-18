namespace FilmesAPI.Models;

public class Genero
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    // Relacionamento N:N
    public ICollection<Filme> Filmes { get; set; } = new List<Filme>();

}