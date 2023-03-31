using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace floricultura.Models.Configuration
{
    public class PedidoProdutoConfiguration : IEntityTypeConfiguration<PedidoProduto>
    {
        public void Configure(EntityTypeBuilder<PedidoProduto> builder)
        {
           builder.HasKey(x => x.Id);

           builder.HasOne(x => x.Produto)
                .WithMany(x => x.Pedidos)
                .HasForeignKey(x => x.Produto_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Produto_Pedido");

            builder.HasOne(x => x.Pedido)
                 .WithMany(x => x.Produtos)
                 .HasForeignKey(x => x.Pedido_Id)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("FK_Pedido_Produto");

            builder.ToTable("PedidoProduto");
        }
    }
}
