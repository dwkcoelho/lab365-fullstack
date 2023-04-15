using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace quiz.Models.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name);

            builder.Property(x => x.Email);

            builder.Property(x => x.Cpf);

            builder.Property(x => x.Password);

            builder.ToTable("User");
        }
    }
}
