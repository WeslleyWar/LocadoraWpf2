using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Migrations
{
    public partial class Lcadora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Potencia",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CnhCliente",
                table: "Locacoes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CpfCliente",
                table: "Locacoes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CpfFuncionario",
                table: "Locacoes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataInicio",
                table: "Locacoes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Locacoes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modelo",
                table: "Locacoes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeCliente",
                table: "Locacoes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeFuncionario",
                table: "Locacoes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "Locacoes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Locacoes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CnhCliente",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "CpfCliente",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "CpfFuncionario",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "NomeCliente",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "NomeFuncionario",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "Placa",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Locacoes");

            migrationBuilder.AlterColumn<int>(
                name: "Potencia",
                table: "Veiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
