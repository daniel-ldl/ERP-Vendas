using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendas.Migrations
{
    public partial class RefreshDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Cliente",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Cliente",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Cliente",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RG",
                table: "Cliente",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Cliente",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Cliente",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Cliente",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "RG",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Cliente");
        }
    }
}
