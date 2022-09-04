using Microsoft.EntityFrameworkCore.Migrations;

namespace Ocorrencia_API.Migrations
{
    public partial class tres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idpedido",
                table: "Ocorrencia",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idpedido",
                table: "Ocorrencia");
        }
    }
}
