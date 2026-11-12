namespace CinemaApp.Models;

public class IngressoItemViewModel
{
    public int Id { get; set; }
    public int Fileira { get; set; }
    public int Assento { get; set; }
    public bool MeiaEntrada { get; set; }
    public decimal Valor { get; set; }
}
