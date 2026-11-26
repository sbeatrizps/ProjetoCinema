using CinemaDomain.Base;

namespace CinemaDomain
{
    public class Ingresso : BaseEntity
    {
        public string Documento { get; set; } = string.Empty;

        public DateTime DataCompra { get; set; }

        public List<IngressoItem> IngressoItens { get; set; } = new();

        public Sessao Sessao { get; set; } = null!;

        public decimal ValorTotal { get; set; }

        public string FormaPagamento { get; set; } = string.Empty;
    }
}