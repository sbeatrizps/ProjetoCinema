using CinemaDomain.Base;

namespace CinemaDomain
{
    public class Filme : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;

        public string Classificacao { get; set; } = string.Empty;

        public Genero Genero { get; set; } = null!;

        public int Duracao { get; set; }
    }
}