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

            builder.ToTable("Discipline");
        }
    }
}
