using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraticasSolo.Migrations
{
    /// <inheritdoc />
    public partial class RemoveOldMarcaEMotor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarcaAntiga",
                table: "Carro");

            migrationBuilder.DropColumn(
                name: "MotorAntigo",
                table: "Carro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MarcaAntiga",
                table: "Carro",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MotorAntigo",
                table: "Carro",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
