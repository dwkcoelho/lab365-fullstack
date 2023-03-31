using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace floricultura.Models.Configuration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Preco)
                .HasColumnType("decimal(4,2)");

            builder.HasOne(x => x.Tipo)
                .WithMany(p => p.Produtos)
                .HasForeignKey(x => x.Tipo_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Produto_Tipo");

            builder.HasOne(x => x.Estoque)
                .WithOne(x => x.Produto)
                .HasForeignKey<Produto>(x => x.Estoque_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Produto_Estoque");

            builder.ToTable("Produto");
        }
    }
}
