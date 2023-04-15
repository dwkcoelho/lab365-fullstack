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

            builder.HasOne(x => x.Student)
                .WithMany(x => x.Students_Disciplines)
                .HasForeignKey(x => x.Student_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Student_Discipline") ;

            builder.HasOne(x => x.Discipline)
                .WithMany(x => x.Student_Disciplines)
                .HasForeignKey(x => x.Discipline_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Discipline_Student_Discipline");

            builder.ToTable("Student_Discipline");
        }
    }
}
