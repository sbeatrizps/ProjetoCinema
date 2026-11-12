namespace CinemaApp.Models;

public class SalaViewModel
{
    public int Id { get; set; }
    public int Numero { get; set; }
    public int Fileiras { get; set; }
    public int Assentos { get; set; }
    public int Capacidade { get; set; }

    // Texto exibido nos combos (ex.: cadastro de sessão)
    public string Descricao => $"Sala {Numero} ({Capacidade} lugares)";
}
