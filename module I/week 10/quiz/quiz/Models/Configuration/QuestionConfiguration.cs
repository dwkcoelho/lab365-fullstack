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

            builder.Property(x => x.Weight)
                .HasColumnType("decimal(4,3)");
        }
    }
}
