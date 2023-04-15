using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace quiz.Models.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Question_Id).IsRequired();

            builder.Property(x => x.Student_Id).IsRequired();

            builder.Property(x => x.Answer_Result);

            builder.Property(x => x.Score);

            builder.Property(x => x.Observation);

            builder.ToTable("Answer");
        }
    }
}
