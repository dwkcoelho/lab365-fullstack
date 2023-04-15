using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace quiz.Models.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.User_Id).IsRequired();

            builder.Property(x => x.Department);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Teachers)
                .HasForeignKey(x => x.User_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Teachers");

            builder.ToTable("Teacher");
        }
    }
}
