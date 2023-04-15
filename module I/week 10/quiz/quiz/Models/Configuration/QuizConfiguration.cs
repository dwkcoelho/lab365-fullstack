using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace quiz.Models.Configuration
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder) 
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Discipline_Id).IsRequired();

            builder.Property(x => x.Title);

            builder.Property(x => x.Date_Open);

            builder.Property(x => x.Date_Close);

            builder.HasOne(x => x.Discipline)
                .WithMany(x => x.Quizzes)
                .HasForeignKey(x => x.Discipline_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Discipline_Quizzes");

            builder.ToTable("Quiz");

        }
    }
}
