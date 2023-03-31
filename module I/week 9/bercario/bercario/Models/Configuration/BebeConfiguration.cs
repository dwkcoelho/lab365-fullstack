using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bercario.Models.Configuration
{
    public class BebeConfiguration : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataNascimento)
                .HasColumnName("Data_Nascimento");

            builder.Property(x => x.PesoNascimento)
                .HasColumnType("decimal(4,3)")
                .HasColumnName("Peso_Nascimento");

            builder.Property(x => x.Altura);

            builder.Property(x => x.MaeId)
                .HasColumnName("Id_Mae");

            builder.Property(x => x.PartoId)
                .HasColumnName("Id_Parto");

            builder.ToTable("Bebe");

        }
    }
}
