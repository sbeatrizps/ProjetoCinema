using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaRepository.Mapping
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filme");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)                
                .IsRequired(true)
                .HasMaxLength(50);
            builder.Property(x => x.Classificacao)
                .IsRequired(false)
                .HasMaxLength(20);
            builder.HasOne(x => x.Genero) // relacionamento com genero
                .WithMany()
                .IsRequired(true);
            builder.Navigation(x => x.Genero).AutoInclude(); // sempre carrega o gênero junto
            builder.Property(x => x.Duracao)
                .HasDefaultValue(120);
        }
    }
}
