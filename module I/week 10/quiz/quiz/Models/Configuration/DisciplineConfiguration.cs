using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace quiz.Models.Configuration
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder) 
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Teacher_Id).IsRequired();

            builder.Property(x => x.Name_Discipline);

            builder.HasOne(x => x.Teacher)
                .WithMany(x => x.Disciplines)
                .HasForeignKey(x => x.Teacher_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Teacher_Disciplines");

            builder.ToTable("Discipline");
        }
    }
}
