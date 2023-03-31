using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bercario.Models.Configuration
{
    public class PartoConfiguration : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.MedicoId)
                .HasColumnName("Id_medico");

            builder.Property(x => x.DataParto);

            builder.Property(x => x.HorarioParto);

            builder.ToTable("Parto");
        }
    }
}
