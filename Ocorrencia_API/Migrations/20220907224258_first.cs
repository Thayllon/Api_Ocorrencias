using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ocorrencia_API.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroPedido = table.Column<int>(type: "int", nullable: false),
                    HoraPedido = table.Column<DateTime>(type: "datetime", nullable: false),
                    IndCancelado = table.Column<bool>(nullable: false),
                    IndConcluido = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.IdPedido);
                });

            migrationBuilder.CreateTable(
                name: "Ocorrencia",
                columns: table => new
                {
                    IdOcorrencia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoOcorrencia = table.Column<string>(type: "varchar(50)", nullable: false),
                    HoraOcorrencia = table.Column<DateTime>(type: "datetime", nullable: false),
                    IndFinalizadora = table.Column<bool>(nullable: false),
                    PedidoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocorrencia", x => x.IdOcorrencia);
                    table.ForeignKey(
                        name: "FK_Ocorrencia_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_PedidoId",
                table: "Ocorrencia",
                column: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "Pedido");
        }
    }
}
