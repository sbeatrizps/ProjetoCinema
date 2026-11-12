namespace CinemaApp.Models;

public class IngressoViewModel
{
    public int Id { get; set; }
    public int SessaoId { get; set; }
    public string FilmeNome { get; set; } = string.Empty;
    public DateTime SessaoData { get; set; }
    public int SalaNumero { get; set; }
    public string Documento { get; set; } = string.Empty;
    public DateTime DataCompra { get; set; }
    public string FormaPagamento { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal ValorTotal { get; set; }
}
