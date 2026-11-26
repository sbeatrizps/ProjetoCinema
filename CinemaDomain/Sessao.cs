using CinemaDomain.Base;

namespace CinemaDomain
{
    public class Sessao : BaseEntity
    {
        public Filme Filme { get; set; } = null!;
        public DateTime Data { get; set; }
        public Sala Sala { get; set; } = null!;
        public decimal Preco { get; set; }
    }
}