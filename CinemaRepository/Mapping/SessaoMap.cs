using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaRepository.Mapping
{
    public class SessaoMap : IEntityTypeConfiguration<Sessao>
    {
        public void Configure(EntityTypeBuilder<Sessao> builder)
        {
            builder.ToTable("Sessao");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Data);
            builder.HasOne(x => x.Filme);
            builder.HasOne(x => x.Sala);
            builder.Property(x => x.Preco);
            // sempre carrega filme e sala junto com a sessão
            builder.Navigation(x => x.Filme).AutoInclude();
            builder.Navigation(x => x.Sala).AutoInclude();

        }
    }
}
