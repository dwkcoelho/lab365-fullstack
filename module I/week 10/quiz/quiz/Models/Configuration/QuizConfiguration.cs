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

            builder.ToTable("Quiz");

        }
    }
}
