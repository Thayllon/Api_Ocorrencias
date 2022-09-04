using Microsoft.EntityFrameworkCore.Migrations;

namespace Ocorrencia_API.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idpedido",
                table: "Ocorrencia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idpedido",
                table: "Ocorrencia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
