
namespace FilmesAPI.Models;

public class Filme
{
    public int Id { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public int AnoLancamento { get; set; }

    // Chave estrangeira
    public int IdDiretor { get; set; }
    public Diretor? Diretor { get; set; }
    public int DuracaoMinutos { get; set; }
    public ICollection<Genero> Generos { get; set; } = new List<Genero>();
}