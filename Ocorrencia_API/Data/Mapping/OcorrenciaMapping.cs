using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ocorrencia_API.Domain.Models;

namespace Ocorrencia_API.Data.Mapping
{
    public class OcorrenciaMapping : IEntityTypeConfiguration<Ocorrencia>
    {
        public void Configure(EntityTypeBuilder<Ocorrencia> builder)
        {
            builder.ToTable("Ocorrencia");

            builder.HasKey(o => o.IdOcorrencia);

            builder.Property(o => o.TipoOcorrencia)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(o => o.HoraOcorrencia)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(o => o.IndFinalizadora);

            //builder.Property(o => o.PedidoId).IsRequired();

            //builder.HasOne(o => o.Pedido).WithMany(o => o.Ocorrencia).HasForeignKey(o => o.PedidoId).OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
