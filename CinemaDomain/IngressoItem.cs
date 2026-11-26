using CinemaDomain.Base;

namespace CinemaDomain
{
    public class IngressoItem : BaseEntity
    {
        public Ingresso Ingresso { get; set; } = null!;

        public int Assento { get; set; }

        public int Fileira { get; set; }

        public bool MeiaEntrada { get; set; }
    }
}