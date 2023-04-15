using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace quiz.Models.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
                
            builder.Property(x => x.User_Id);

            builder.Property(x => x.Period);

            builder.Property(x => x.Ra);

            builder.ToTable("Student");
        }

    }
}
