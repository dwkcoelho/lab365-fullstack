using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace quiz.Models.Configuration
{
    public class Student_DisciplineConfiguration : IEntityTypeConfiguration<Student_Discipline>
    {
        public void Configure(EntityTypeBuilder<Student_Discipline> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Student_Id).IsRequired();

            builder.Property(x => x.Discipline_Id).IsRequired();

            builder.ToTable("Student_Discipline");
        }
    }
}
