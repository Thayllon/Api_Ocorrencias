// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ocorrencia_API.Data.Context;

namespace Ocorrencia_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220904215705_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ocorrencia_API.Domain.Models.Ocorrencia", b =>
                {
                    b.Property<int>("IdOcorrencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("HoraOcorrencia")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IndFinalizadora")
                        .HasColumnType("bit");

                    b.Property<int?>("PedidoIdPedido")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TipoOcorrencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdOcorrencia");

                    b.HasIndex("PedidoIdPedido");

                    b.ToTable("Ocorrencia");
                });

            modelBuilder.Entity("Ocorrencia_API.Domain.Models.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("HoraPedido")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IndCancelado")
                        .HasColumnType("bit");

                    b.Property<bool>("IndConcluido")
                        .HasColumnType("bit");

                    b.Property<int>("NumeroPedido")
                        .HasColumnType("int");

                    b.HasKey("IdPedido");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Ocorrencia_API.Domain.Models.Ocorrencia", b =>
                {
                    b.HasOne("Ocorrencia_API.Domain.Models.Pedido", null)
                        .WithMany("Ocorrencia")
                        .HasForeignKey("PedidoIdPedido");
                });
#pragma warning restore 612, 618
        }
    }
}
