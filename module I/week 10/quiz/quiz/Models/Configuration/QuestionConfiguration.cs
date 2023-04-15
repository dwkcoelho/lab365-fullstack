using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace quiz.Models.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder) 
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Quiz_Id).IsRequired();

            builder.Property(x => x.Enunciation);

            builder.HasOne(x => x.Quiz)
                .WithMany(x => x.Questions)
                .HasForeignKey(x => x.Quiz_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Quiz_Questions");

            builder.Property(x => x.Weight)
                .HasColumnType("decimal(4,3)");
        }
    }
}
