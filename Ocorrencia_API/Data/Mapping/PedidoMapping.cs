using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ocorrencia_API.Domain.Models;

namespace Ocorrencia_API.Data.Mapping
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(p => p.IdPedido);

            builder.Property(p => p.NumeroPedido)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.HoraPedido)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.IndCancelado);

            builder.Property(p => p.IndConcluido);

            builder.HasMany(p => p.Ocorrencias).WithOne(p => p.Pedido).OnDelete(DeleteBehavior.Restrict);

        }
    }
} 
