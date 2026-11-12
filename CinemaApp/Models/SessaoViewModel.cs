namespace CinemaApp.Models;

public class SessaoViewModel
{
    public int Id { get; set; }
    public int FilmeId { get; set; }
    public string FilmeNome { get; set; } = string.Empty;
    public int SalaId { get; set; }
    public int SalaNumero { get; set; }
    public DateTime Data { get; set; }
    public decimal Preco { get; set; }

    // Texto exibido nos combos (ex.: venda de ingresso)
    public string Descricao => $"{Data:dd/MM/yyyy HH:mm} - {FilmeNome} - Sala {SalaNumero}";
}
