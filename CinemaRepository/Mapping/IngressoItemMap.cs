using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaRepository.Mapping
{
    public class IngressoItemMap : IEntityTypeConfiguration<IngressoItem>
    {
        public void Configure(EntityTypeBuilder<IngressoItem> builder)
        {
            builder.ToTable("IngressoItem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Assento);
            builder.Property(x => x.Fileira);
            builder.Property(x => x.MeiaEntrada);
            builder.HasOne(x => x.Ingresso).WithMany(x => x.IngressoItens).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
