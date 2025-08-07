using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gerenciador_de_TarefasCRUD.Migrations
{
    /// <inheritdoc />
    public partial class mudanças : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataConclusao",
                table: "Tipos",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Tipos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataConclusao",
                table: "Tipos");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Tipos");
        }
    }
}
