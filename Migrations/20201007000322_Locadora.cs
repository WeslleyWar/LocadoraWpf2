using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Migrations
{
    public partial class Locadora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContatoPessoal",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "PermissãoDirigir",
                table: "Funcionarios");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Cliente",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Cliente");

            migrationBuilder.AddColumn<string>(
                name: "ContatoPessoal",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PermissãoDirigir",
                table: "Funcionarios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
